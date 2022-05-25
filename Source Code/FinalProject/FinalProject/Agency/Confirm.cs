using Nhom01.DTO;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class Confirm : Form
    {
        string id;
        SqlConnection conn;
        public Confirm(string id)
        {
            InitializeComponent();
            this.id = id;
        }
        private void Confirm_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(DataP.Instance.connectSTR);
        }
        private void btnYes_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string command = "exec nhanduocHang '" + id + "'";
                SqlCommand cmd = new SqlCommand(command, conn);
                SqlDataReader read = cmd.ExecuteReader();
                read.Read();
                read.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            this.Close();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
