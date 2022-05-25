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
    public partial class ExportInfo : Form
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

        public ExportInfo(string id, SqlConnection conn)
        {
            InitializeComponent();
            this.billid = id;
            this.conn = conn;
        }

        private void ExportForm_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                loadExportData();

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void loadExportData()
        {
            exportBillid.Text = "Export Bill's ID: " + billid;

            command = "Select HovaTen ";
            command += "From PhieuXuatKho XK ";
            command += "Left Join PhieuDatHang DH on DH.SoPhieu  = XK.SoPhieuDat ";
            command += "Left Join Taikhoan TK on DH.ID_NguoiDat = TK.ID_Taikhoan ";
            command += "Where XK.SoPhieu = '" + billid + "'";
            cmd = new SqlCommand(command, conn);
            reader = cmd.ExecuteReader();
            reader.Read();
            ordererName.Text = "Orderer's Name: " + reader.GetString(0);
            reader.Close();

            command = "Select HH.MaHang [ProductID],HH.TenMatHang [ProductName],Cast(HH.GiaBan as bigint) [ExportPrice],HH.DonVi [UnitType],DS.SoLuong [Quantity]";
            command += "From PhieuXuatKho XK ";
            command += "Left Join PhieuDatHang DH on DH.SoPhieu  = XK.SoPhieuDat ";
            command += "Left Join DanhSachDatHang DS on DS.MaDanhSach = DH.SoPhieu ";
            command += "Left Join HangHoa HH on HH.MaHang = DS.MaHangHoa ";
            command += "Where XK.SoPhieu = '" + billid + "'";
            adapter = new SqlDataAdapter(command, conn);
            dt = new DataTable();
            adapter.Fill(dt);
            dataExport.DataSource = dt;

            command = "Select TK.HovaTen From PhieuXuatKho XK Left Join Taikhoan TK on TK.Id_Taikhoan = XK.IDNguoiXuat Where SoPhieu = '" + billid + "'";
            cmd = new SqlCommand(command, conn);
            reader = cmd.ExecuteReader();
            reader.Read();
            exporterName.Text = reader.GetString(0);
            reader.Close();

        }

        private string[] InfoNguoiDat()
        {
            string[] info = { };
            List<string> tmp = new List<string>();
            command = "Select HovaTen,DiaChi,SoDienThoai ";
            command += "From PhieuXuatKho XK ";
            command += "Left Join PhieuDatHang DH on DH.SoPhieu  = XK.SoPhieuDat ";
            command += "Left Join Taikhoan TK on DH.ID_NguoiDat = TK.ID_Taikhoan ";
            command += "Where XK.SoPhieu = '" + billid + "'";
            cmd = new SqlCommand(command, conn);
            reader = cmd.ExecuteReader();
            reader.Read();
            tmp.Add(reader.GetString(0));
            tmp.Add(reader.GetString(1));
            tmp.Add(reader.GetString(2));
            info = tmp.ToArray();
            reader.Close();
            return info;
        }

        private string DeliveryDate()
        {
            string date = "";
            command = "Select XK.NgayXuatKho ";
            command += "From PhieuXuatKho XK ";
            command += "Where XK.SoPhieu = '" + billid + "'";
            cmd = new SqlCommand(command, conn);
            reader = cmd.ExecuteReader();
            reader.Read();

            date = DateTime.Parse(reader.GetDateTime(0).ToString()).ToLongDateString();

            reader.Close();
            return date;
        }

        private string PaidDate()
        {
            string payment = "";

            command = "Select DH.PT_ThanhToan, DH.NgayNhanHang ";
            command += "From PhieuXuatKho XK ";
            command += "Left Join PhieuDatHang DH on DH.SoPhieu  = XK.SoPhieuDat ";
            command += "Left Join Taikhoan TK on DH.ID_NguoiDat = TK.ID_Taikhoan ";
            command += "Where XK.SoPhieu = '" + billid + "' and DH.NgayNhanHang is not null";

            cmd = new SqlCommand(command, conn);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                payment = "Paid on " + DateTime.Parse(reader.GetDateTime(1).ToString()).ToLongDateString() + " by " + reader.GetString(0);
            }

            reader.Close();
            return payment;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            var CurrentDirectory =
                Directory.GetParent(Directory.GetParent(
                    Directory.GetParent(Directory.GetCurrentDirectory())
                    .ToString()).ToString());
            var formFile = CurrentDirectory + @"\1-Form\ExportForm.xlsx";
            var saveFile = CurrentDirectory + @"\1-Export\" + billid;
            try
            {
                conn.Open();

                var template = new XLTemplate(formFile);
                string[] info = InfoNguoiDat();
                string exDate = DeliveryDate();
                string payDate = PaidDate();

                template.AddVariable("OrdererName", info[0]);
                template.AddVariable("Address", info[1]);
                template.AddVariable("Telno", info[2]);
                if (!payDate.Equals(""))
                {
                    template.AddVariable("PaymentStatus", payDate);
                    saveFile += "_Paid";
                }
                else
                {
                    template.AddVariable("PaymentStatus", "Agent haven't paid for this bill");
                    saveFile += "_Unpaid";
                }


                ClosedXML.Excel.IXLWorkbook book = template.Workbook;
                ClosedXML.Excel.IXLWorksheet sheet = book.Worksheet("Form");

                if (dataExport.Rows.Count > 2)
                {
                    sheet.Row(14).InsertRowsAbove(dataExport.Rows.Count - 2);
                }

                int rowstart = 13;
                Int64 total = 0;
                // col: C-D-E-F-G 
                for (int i = 0; i < dataExport.Rows.Count; i++)
                {
                    sheet.Cells("C" + (rowstart + i)).Value = dataExport.Rows[i].Cells[0].Value.ToString();
                    sheet.Cells("D" + (rowstart + i)).Value = dataExport.Rows[i].Cells[1].Value.ToString();
                    sheet.Cells("E" + (rowstart + i)).Value = dataExport.Rows[i].Cells[2].Value.ToString();
                    sheet.Cells("F" + (rowstart + i)).Value = dataExport.Rows[i].Cells[3].Value.ToString();
                    sheet.Cells("G" + (rowstart + i)).Value = dataExport.Rows[i].Cells[4].Value.ToString();
                    total += Int64.Parse(dataExport.Rows[i].Cells[2].Value.ToString()) * Int64.Parse(dataExport.Rows[i].Cells[4].Value.ToString());
                }

                template.AddVariable("Total", "   " + total + " K");
                template.AddVariable("DeliveryDate", exDate);
                template.AddVariable("ExporterName", exporterName.Text);

                template.Generate();

                // DataGridView

                if (File.Exists(saveFile+ ".xlsx")) {
                    File.Delete(saveFile + ".xlsx");
                }
                else { }
                
                template.SaveAs(saveFile + ".xlsx");
                MessageBox.Show("Success send file to excel. Check in Source Code/FinalProject/1-Export");

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
