using Nhom01.DTO;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class Daily_home : Form
    {
        SqlConnection ConnectionSTR;
        string user;
        string userid;
        public Daily_home(string user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void FrmTrangChu_Daily_Load(object sender, EventArgs e)
        {
            ConnectionSTR = new SqlConnection(DataP.Instance.connectSTR);
            CreatePage();
        }
        private void CreatePage()
        {
            string command = "Select Id_Taikhoan,HovaTen,SoDienThoai,DiaChi From Taikhoan Where Tendangnhap = '" + user + "'";

            try
            {
                ConnectionSTR.Open();

                SqlCommand cmd = new SqlCommand(command, ConnectionSTR);
                SqlDataReader reader = cmd.ExecuteReader();

                reader.Read();

                userid = reader.GetString(0);
                Txt_SOPHIEU.Text = "ID: " + userid;
                TXT_HOTEN.Text = "Name: " + reader.GetString(1);
                TXTSODIENTHOAI.Text = "Phoneno: " + reader.GetString(2);
                TXTDIACHI.Text = "Address: " + reader.GetString(3);


                reader.Close();

                Tinhtrangdonhang();
                loadShipped();
                loadHistory();

                PANEL_XU_LI.Visible = true;
                shippedPanel.Visible = false;
                historyPanel.Visible = false;
                ConnectionSTR.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Có lỗi xảy ra");
            }
        }
        
        private void Tinhtrangdonhang()
        {
            string command = "Select SoPhieu [Order ID],NgayDatHang  [Order date],PT_ThanhToan [Payment Method] ";
            command += "From PhieuDatHang ";
            command += "Where ID_NguoiDat = '" + userid + "' and TrangThai ='on pending'";

            SqlDataAdapter adapter = new SqlDataAdapter(command, ConnectionSTR);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                LISTXULI.DataSource = dt;

                LISTXULI.Columns[0].Width = 125;
                LISTXULI.Columns[1].DefaultCellStyle.Format = "MMM dd  yyyy";
                LISTXULI.Columns[2].Width = 150;

                LISTXULI.Rows[0].Cells[0].Selected = true;
            }
            else
            {}
        }

        private void loadShipped()
        {
            string command = "Select SoPhieu [Order ID],NgayDatHang  [Order date],PT_ThanhToan [Payment Method] ";
            command += "From PhieuDatHang ";
            command += "Where ID_NguoiDat = '" + userid + "' and TrangThai ='On being shipped'";

            SqlDataAdapter adapter = new SqlDataAdapter(command, ConnectionSTR);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                dataShipped.DataSource = dt;

                dataShipped.Columns[0].Width = 125;
                dataShipped.Columns[1].DefaultCellStyle.Format = "MMM dd  yyyy";
                dataShipped.Columns[2].Width = 150;

                dataShipped.Rows[0].Cells[0].Selected = true;
            }
            else
            { }
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login back = new Login();
            this.Hide();
            back.ShowDialog();
            this.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Order order = new Order(userid);
            order.ShowDialog();
            try
            {
                ConnectionSTR.Open();
                Tinhtrangdonhang();
                loadShipped();
                loadHistory();
                ConnectionSTR.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("We got some mistake in FrmTrangChu_Daily");
            }
        }

        private void loadHistory()
        {
            string command = "Select SoPhieu [Order ID],NgayDatHang  [Order date],NgayNhanHang [Paid on],PT_ThanhToan [Payment Method] ";
            command += "From PhieuDatHang ";
            command += "Where ID_NguoiDat = '" + userid + "' and TrangThai ='Have arrived'";

            SqlDataAdapter adapter = new SqlDataAdapter(command, ConnectionSTR);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                dataHistory.DataSource = dt;

                dataHistory.Columns[0].Width = 125;
                dataHistory.Columns[1].DefaultCellStyle.Format = "MMM dd  yyyy";
                dataHistory.Columns[2].DefaultCellStyle.Format = "MMM dd  yyyy";
                dataHistory.Columns[3].Width = 150;

                dataHistory.Rows[0].Cells[0].Selected = true;
            }
            else
            { }
        }

        private void Tailai_Table()
        {
            try
            {
                DataTable dt = new DataTable();
                LISTXULI.DataSource = dt;
                dataShipped.DataSource = dt;
                dataHistory.DataSource = dt;

                Tinhtrangdonhang();
                loadShipped();
                loadHistory();
                ConnectionSTR.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void btnPending_Click(object sender, EventArgs e)
        {
            BTNXULI.BackColor = Color.FromArgb(128, 128, 255);
            BTNXULI.ForeColor = Color.White;

            BTNDANGGIAOHANG.BackColor = Color.FromArgb(224, 224, 224);
            BTNDANGGIAOHANG.ForeColor = Color.Black;
            BTNLICHSUGIAOHANG.BackColor = Color.FromArgb(224, 224, 224);
            BTNLICHSUGIAOHANG.ForeColor = Color.Black;

            if (dataShipped.RowCount > 0)
            {
                dataShipped.Rows[0].Cells[0].Selected = true;
            }
            if (dataHistory.RowCount > 0)
            {
                dataHistory.Rows[0].Cells[0].Selected = true;
            }

            PANEL_XU_LI.Visible = true;
            shippedPanel.Visible = false;
            historyPanel.Visible = false;
        }

        private void btnShipped_Click(object sender, EventArgs e)
        {
            BTNDANGGIAOHANG.BackColor = Color.FromArgb(128, 128, 255);
            BTNDANGGIAOHANG.ForeColor = Color.White;

            BTNXULI.BackColor = Color.FromArgb(224, 224, 224);
            BTNXULI.ForeColor = Color.Black;
            BTNLICHSUGIAOHANG.BackColor = Color.FromArgb(224, 224, 224);
            BTNLICHSUGIAOHANG.ForeColor = Color.Black;

            if (LISTXULI.RowCount > 0)
            {
                LISTXULI.Rows[0].Cells[0].Selected = true;
            }
            if (dataHistory.RowCount > 0)
            {
                dataHistory.Rows[0].Cells[0].Selected = true;
            }

            PANEL_XU_LI.Visible = false;
            shippedPanel.Visible = true;
            historyPanel.Visible = false;
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            BTNLICHSUGIAOHANG.BackColor = Color.FromArgb(128, 128, 255);
            BTNLICHSUGIAOHANG.ForeColor = Color.White;

            BTNXULI.BackColor = Color.FromArgb(224, 224, 224);
            BTNXULI.ForeColor = Color.Black;
            BTNDANGGIAOHANG.BackColor = Color.FromArgb(224, 224, 224);
            BTNDANGGIAOHANG.ForeColor = Color.Black;

            if (LISTXULI.RowCount > 0)
            {
                LISTXULI.Rows[0].Cells[0].Selected = true;
            }
            if (dataShipped.RowCount > 0)
            {
                dataShipped.Rows[0].Cells[0].Selected = true;
            }

            PANEL_XU_LI.Visible = false;
            shippedPanel.Visible = false;
            historyPanel.Visible = true;
        }

       
        private void dataShipped_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dataShipped.SelectedRows[0].Index;
            string id = dataShipped.Rows[index].Cells[0].Value.ToString();

            Confirm cfm = new Confirm(id);
            cfm.ShowDialog();
            Tailai_Table();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            Tailai_Table();
        }
    }
}
