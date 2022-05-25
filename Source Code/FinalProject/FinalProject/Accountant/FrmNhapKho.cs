using Nhom01.DTO;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class FrmNhapKho : Form
    {
        SqlConnection ConnectionSTR;
        string Guest;
        string ID_bill = "";
        public FrmNhapKho(string Guest)
        {
            InitializeComponent();
            this.Guest = Guest;
        }
        private void FrmNhapKho_Load(object sender, EventArgs e)
        {
            ConnectionSTR = new SqlConnection(DataP.Instance.connectSTR);
            ProductInclude();
            HistoryInclude();
            PageCreate();
        }
        private void PageCreate()
        {
            updatebtn.Enabled = false;
            delebtn.Enabled = false;
            showbtn.Enabled = false;

            ListUpdate.Refresh();
            ConfirmUpdate.Visible = false;

            for(int i = 0; i < productList.RowCount; i++)
            {
                productList.Rows[i].Cells[4].Value = "0";
            }

            productList.SelectionMode = DataGridViewSelectionMode.CellSelect;
            HistoryList.SelectionMode = DataGridViewSelectionMode.CellSelect;

            productList.Rows[0].Cells[0].Selected = true;
            HistoryList.Rows[0].Cells[0].Selected = true;
        }

        private void LoadPageRV()
        {
            FrmNhapKho rl = new FrmNhapKho(Guest);
            this.Hide();
            rl.ShowDialog();
            this.Close();
        }
      
        private void rejectUpdate_Click(object sender, EventArgs e)
        {
            ListUpdate.Refresh();
            ConfirmUpdate.Visible = false;

            updatebtn.Enabled = true;
            delebtn.Enabled = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            updatebtn.Enabled = false;
            delebtn.Enabled = false;


            productList.ClearSelection();

            for (int i = 0; i < productList.RowCount; i++)
            {
                productList.Rows[i].Cells[4].Value = "0";
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FormMain_kt back = new FormMain_kt(Guest);
            this.Hide();
            back.ShowDialog();
            this.Close();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            ImportInfo print = new ImportInfo(ID_bill, ConnectionSTR);
            print.ShowDialog();
        }
        private void ProductInclude()
        {
            try
            {
                ConnectionSTR.Open();

                string command = "SELECT MaHang [Product ID], TenMatHang [Product's name], TonKho [Inventory], Cast(GiaNhap as bigint) [I.Price (k)] FROM HangHoa";
                SqlCommand cmd = new SqlCommand(command, ConnectionSTR);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                productList.DataSource = dt;
                productList.Columns.Add("Column", "Add...");

                productList.Columns[0].Width = 125;
                productList.Columns[2].Width = 100;
                productList.Columns[3].Width = 100;
                productList.Columns[4].Width = 100;

                productList.Columns[0].ReadOnly = true;

                productList.Columns[1].ReadOnly = true;

                productList.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                productList.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                productList.Columns[2].ReadOnly = true;

                productList.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                productList.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                productList.Columns[3].ReadOnly = true;


                for (int i = 0; i < productList.ColumnCount; i++)
                {
                    productList.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                }

                productList.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                productList.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                productList.ClearSelection();

                ConnectionSTR.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Có lỗi xảy ra");
                LoadPageRV();
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void HistoryInclude()
        {
            try
            {
                ConnectionSTR.Open();
                string command = "";
                command += "Select NK.SoPhieu [Bill ID], Sum(Cast((HH.GiaNhap*NK.SoLuong) as bigint))[Paid (k)], NK.NgayNhapKho [Imported At], TK.HovaTen [Entered By] ";
                command += "From PhieuNhapKho NK ";
                command += "Left join HangHoa HH On HH.MaHang = NK.MaHangHoa ";
                command += "Left join TaiKhoan TK On TK.ID_Taikhoan = NK.IDNguoiNhap ";
                command += "Group by NK.SoPhieu,NK.NgayNhapKho,TK.HovaTen Order by NK.NgayNhapKho DESC";

                SqlCommand cmd = new SqlCommand(command, ConnectionSTR);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                HistoryList.DataSource = dt;

                HistoryList.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;

                HistoryList.Columns[0].ReadOnly = true;

                HistoryList.Columns[1].ReadOnly = true;

                HistoryList.Columns[2].ReadOnly = true;
                HistoryList.Columns[2].DefaultCellStyle.Format = "MMM dd yyy";

                HistoryList.Columns[3].ReadOnly = true;

                HistoryList.ClearSelection();

                ConnectionSTR.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Có lỗi xảy ra");
                LoadPageRV();
            }
        }

        private void LoadFormUpdate(int row)
        {
            DataTable dt = new DataTable();

            DataColumn dc = new DataColumn("Product ID", typeof(String));
            dt.Columns.Add(dc);

            dc = new DataColumn("Product Name", typeof(String));
            dt.Columns.Add(dc);

            dc = new DataColumn("Import Price", typeof(String));
            dt.Columns.Add(dc);

            dc = new DataColumn("Import", typeof(String));
            dt.Columns.Add(dc);

            dc = new DataColumn("Unit", typeof(String));
            dt.Columns.Add(dc);

            int i = 0;

            for (int j = 0; j < productList.RowCount & i<row; j++)
            {
                string id = productList.Rows[j].Cells[0].Value.ToString();
                string name = productList.Rows[j].Cells[1].Value.ToString();
                string price = productList.Rows[j].Cells[3].Value.ToString();
                string add = productList.Rows[j].Cells[4].Value.ToString();
                
                
                if (int.Parse(add) > 0)
                {
                    DataRow dr = dt.NewRow();
                    
                    dr["Product ID"] = id;
                    dr["Product Name"] = name;
                    dr["Import Price"] = price;
                    dr["Import"] = add;

                    try
                    {
                        ConnectionSTR.Open();
                        string command = "Select DonVi From HangHoa Where MaHang = '"+id+"'";
                        SqlCommand cmd = new SqlCommand(command, ConnectionSTR);
                        SqlDataReader reader = cmd.ExecuteReader();
                        reader.Read();
                        dr["Unit"] = reader.GetString(0);
                        reader.Close();
                        ConnectionSTR.Close();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }

                    dt.Rows.InsertAt(dr,i);
                    i++;
                }
            }
            ListUpdate.DataSource = dt;

            ListUpdate.Columns[0].Width = 100;

            ListUpdate.Columns[2].Width = 100;
            ListUpdate.Columns[3].Width = 100;
            ListUpdate.Columns[4].Width = 100;

            ListUpdate.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
            ListUpdate.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
            ListUpdate.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;

            ListUpdate.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ListUpdate.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ListUpdate.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            ListUpdate.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ListUpdate.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ListUpdate.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            ListUpdate.ClearSelection();
            if (ListUpdate.RowCount > 0)
            {
                ListUpdate.Rows[0].Cells[0].Selected = true;
            }
        }
        private void productList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = productList.SelectedCells[0].RowIndex;
            productList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            productList.Rows[rowindex].Selected = true;

            updatebtn.Enabled = true;
            delebtn.Enabled = true;
            showbtn.Enabled = false;


            HistoryList.SelectionMode = DataGridViewSelectionMode.CellSelect;
            HistoryList.Rows[0].Cells[0].Selected = true;
        }

        private void historyList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = HistoryList.SelectedCells[0].RowIndex;
            HistoryList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            HistoryList.Rows[rowindex].Selected = true;
            ID_bill = HistoryList.Rows[rowindex].Cells[0].Value.ToString();

            showbtn.Enabled = true;
            updatebtn.Enabled = false;
            delebtn.Enabled = false;
            ConfirmUpdate.Visible = false;

            productList.SelectionMode = DataGridViewSelectionMode.CellSelect;
            productList.Rows[0].Cells[0].Selected = true;
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int rowcount = 0;
            for(int i = 0; i < productList.RowCount; i++)
            {
                string testcase = "";

                if (productList.Rows[i].Cells[4].Value == null)
                {
                    productList.Rows[i].Cells[4].Value = "0";
                }

                if (productList.Rows[i].Cells[4].Value.ToString().Trim().Length != 0)
                {
                    testcase = productList.Rows[i].Cells[4].Value.ToString().Trim();
                    if (int.TryParse(testcase,out int value))
                    {
                        if (int.Parse(testcase) > 0) { 
                            rowcount += 1;
                        }
                        else if(int.Parse(testcase) < 0)
                        {
                            notifyWrongValue2.ShowBalloonTip(50);
                            return;
                        }
                        else { }
                    }
                    else
                    {
                        notifyWrongValue1.ShowBalloonTip(50);
                        return;
                    }
                }
            }

            if (rowcount == 0)
            {
                MessageBox.Show("Không có thay đổi để cập nhật");
                return;
            }
            else {
                LoadFormUpdate(rowcount);
                ConfirmUpdate.Visible = true;
                updatebtn.Enabled = false;
                delebtn.Enabled = false;
            }


        }

        private void acceptUpdate_Click(object sender, EventArgs e)
        {
            string command;
            SqlCommand cmd;
            SqlDataReader reader;
            string sophieu,Guestid;
            try
            {
                ConnectionSTR.Open();
                command = "exec dbo.taoPhieuNhapKho";
                cmd = new SqlCommand(command, ConnectionSTR);
                reader = cmd.ExecuteReader();
                reader.Read();

                sophieu = reader.GetString(0);

                reader.Close();
                command = "Select Id_Taikhoan From Taikhoan Where Tendangnhap = '"+Guest+"'";
                cmd = new SqlCommand(command, ConnectionSTR);
                reader = cmd.ExecuteReader();
                reader.Read();

                Guestid = reader.GetString(0);

                reader.Close();
                for (int i = 0; i < ListUpdate.RowCount; i++)
                {
                    string mahanghoa = ListUpdate.Rows[i].Cells[0].Value.ToString();
                    Int64 soluong = Int64.Parse(ListUpdate.Rows[i].Cells[3].Value.ToString());

                    command = "Exec dbo.themPhieuNhapKho '"+sophieu+"','"+mahanghoa+"',"+soluong+",'"+ Guestid + "'";
                    cmd = new SqlCommand(command, ConnectionSTR);
                    reader = cmd.ExecuteReader();
                    reader.Close();
                }
                ConnectionSTR.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }
            productList.Columns.RemoveAt(4);
            ProductInclude();
            HistoryInclude();

            for(int i=0; i < HistoryList.RowCount; i++)
            {
                if (HistoryList.Rows[i].Cells[0].Value.ToString().Equals(sophieu))
                {
                    HistoryList.Rows[i].Cells[0].Selected = true;
                    break;
                }
            }

            notifyUpdateSucces.ShowBalloonTip(50);
            PageCreate();
        }

    
    }
}
