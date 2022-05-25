using ClosedXML.Report;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class ImportInfo : Form
    {
        string billid;
        SqlConnection conn;

        string command;
        SqlCommand cmd;
        SqlDataReader reader;
        SqlDataAdapter adapter;
        DataTable dt;
        DataColumn dc;
        DataRow dr;
        public ImportInfo(string billID,SqlConnection conn)
        {
            InitializeComponent();
            this.billid = billID;
            this.conn = conn;
        }

        private void ImportInfo_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                loadImportData();

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void loadImportData()
        {
            
            importBillid.Text = "Import Bill's ID: " + billid;

            command = "Select HH.MaHang [ProductID],HH.TenMatHang [ProductName],Cast(HH.GiaNhap as bigint) [ImportPrice],HH.DonVi [UnitType],NK.SoLuong [Quantity] ";
            command += "From PhieuNhapKho NK ";
            command += "Left Join HangHoa HH on HH.MaHang = NK.MaHangHoa ";
            command += "Where NK.SoPhieu = '" + billid + "'";
            adapter = new SqlDataAdapter(command, conn);
            dt = new DataTable();
            adapter.Fill(dt);
            dataImport.DataSource = dt;

            command = "Select TK.HovaTen From PhieuNhapKho NK Left Join Taikhoan TK on TK.Id_Taikhoan = NK.IDNguoiNhap Where SoPhieu = '" + billid + "'";
            cmd = new SqlCommand(command, conn);
            reader = cmd.ExecuteReader();
            reader.Read();
            importerName.Text = reader.GetString(0);
            reader.Close();

        }
        private string ImportDate()
        {
            string date = "";
            command = "Select NK.NgayNhapKho ";
            command += "From PhieuNhapKho NK ";
            command += "Where NK.SoPhieu = '" + billid + "'";
            cmd = new SqlCommand(command, conn);
            reader = cmd.ExecuteReader();
            reader.Read();

            date = DateTime.Parse(reader.GetDateTime(0).ToString()).ToLongDateString();

            reader.Close();
            return date;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            var CurrentDirectory =
                   Directory.GetParent(Directory.GetParent(
                       Directory.GetParent(Directory.GetCurrentDirectory())
                       .ToString()).ToString());
            var formFile = CurrentDirectory + @"\1-Form\ImportForm.xlsx";
            var saveFile = CurrentDirectory + @"\1-Import\" + billid;
            try
            {
                conn.Open();

                var template = new XLTemplate(formFile);
                string imdate = ImportDate();


                ClosedXML.Excel.IXLWorkbook book = template.Workbook;
                ClosedXML.Excel.IXLWorksheet sheet = book.Worksheet("Form");

                if (dataImport.Rows.Count > 2)
                {
                    sheet.Row(9).InsertRowsAbove(dataImport.Rows.Count - 2);
                }

                int rowstart = 8;
                Int64 total = 0;
                // col: C-D-E-F-G 
                for (int i = 0; i < dataImport.Rows.Count; i++)
                {
                    sheet.Cells("C" + (rowstart + i)).Value = dataImport.Rows[i].Cells[0].Value.ToString();
                    sheet.Cells("D" + (rowstart + i)).Value = dataImport.Rows[i].Cells[1].Value.ToString();
                    sheet.Cells("E" + (rowstart + i)).Value = dataImport.Rows[i].Cells[2].Value.ToString();
                    sheet.Cells("F" + (rowstart + i)).Value = dataImport.Rows[i].Cells[3].Value.ToString();
                    sheet.Cells("G" + (rowstart + i)).Value = dataImport.Rows[i].Cells[4].Value.ToString();
                    total += Int64.Parse(dataImport.Rows[i].Cells[2].Value.ToString()) * Int64.Parse(dataImport.Rows[i].Cells[4].Value.ToString());
                }

                template.AddVariable("Total", "   " + total + " K");
                template.AddVariable("ImportDate", imdate);
                template.AddVariable("ImporterName", importerName.Text);

                template.Generate();

                // DataGridView

                if (File.Exists(saveFile + ".xlsx"))
                {
                    File.Delete(saveFile + ".xlsx");
                }
                else { }

                template.SaveAs(saveFile + ".xlsx");
                MessageBox.Show("Success send file to excel. Check in Source Code/FinalProject/1-Import");

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

    }
}
