using Nhom01.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class FormMain_kt : Form
    {
        SqlConnection Connection;
        string Guest;

        public FormMain_kt(string Guest)
        {
            InitializeComponent();
            this.Guest = Guest;
        }


        private void FrmTrangChu_Load(object sender, EventArgs e)
        {
           Connection = new SqlConnection(DataP.Instance.connectSTR);
            string command = "Select HovaTen From Taikhoan Where Tendangnhap = '" + Guest + "'";

            try
            {
                Connection.Open();
                SqlCommand cmd = new SqlCommand(command, Connection);
                Connection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Đã có lỗi xảy ra");
            }
        }

        private void itemNhapKho_Click(object sender, EventArgs e)
        {
            FrmNhapKho nhapKho = new FrmNhapKho(Guest);
            this.Hide();
            nhapKho.ShowDialog();
            this.Close();
        }

        private void itemXuatKho_Click(object sender, EventArgs e)
        {
            Xuat xuatKho = new Xuat(Guest);
            this.Hide();
            xuatKho.ShowDialog();
            this.Close();
        }

        private void itemTKDT_Click(object sender, EventArgs e)
        {
            FormThongkeDT tkdt = new FormThongkeDT(Guest);
            this.Hide();
            tkdt.ShowDialog();
            this.Close();
        }

        private void itemTKHH_Click(object sender, EventArgs e)
        {
            ThongKeHangHoa tkhh = new ThongKeHangHoa(Guest);
            this.Hide();
            tkhh.ShowDialog();
            this.Close();
        }

        private void itemLogout_Click(object sender, EventArgs e)
        {
            Login reload = new Login();
            this.Hide();
            reload.ShowDialog();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmNhapKho nhapKho = new FrmNhapKho(Guest);
            this.Hide();
            nhapKho.ShowDialog();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Xuat xuatKho = new Xuat(Guest);
            this.Hide();
            xuatKho.ShowDialog();
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            string message = "Vui lòng chọn hình thức thống kê";
            string title = "System Infomation";
            MessageBoxManager.Yes = "Hàng Tháng";
            MessageBoxManager.No = "Xuất khẩu";
            MessageBoxManager.Register();
            DialogResult result = MessageBox.Show(message, title, MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Xuat xuatKho = new Xuat(Guest);
                this.Hide();
                xuatKho.ShowDialog();
                this.Close();
            }
            else if (result == DialogResult.No)
            {
                FormThongkeDT tkdt = new FormThongkeDT(Guest);
                this.Hide();
                tkdt.ShowDialog();
                this.Close();
            }
           
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Login reload = new Login();
            this.Hide();
            reload.ShowDialog();
            this.Close();
        }

        private void thongke_Click(object sender, EventArgs e)
        {

        }
    }
}
