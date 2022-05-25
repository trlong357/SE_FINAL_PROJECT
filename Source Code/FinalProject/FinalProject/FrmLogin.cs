using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using Nhom01.DTO;

namespace FinalProject
{
    public partial class Login : Form
    {
        SqlConnection conn;
        public Login()
        {
            InitializeComponent();
        }
        private void FrmLogin_Load(object sender, EventArgs e)
        {
         conn = new SqlConnection(DataP.Instance.connectSTR);

        }
        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {
            TTlogin.Visible = false;
            ttlogin2.Visible = false;
            ttllogin3.Visible = false;
        }

        private void txtTaiKhoan_TextChanged(object sender, EventArgs e)
        {
            TTlogin.Visible = false;
            ttlogin2.Visible = false;
            ttllogin3.Visible = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtuser.Text;
            string pass = txtpass.Text;

            string command = "Exec dbo.loginResult '" + user + "','" + pass + "'";
            if(user.Trim().Length==0 || pass.Trim().Length == 0)
            {
                TTlogin.Visible = true;
                TTlogin.ShowBalloonTip(100);
            }else if(pass.Length < 6)
            {
                ttlogin2.Visible = false;
                ttlogin2.ShowBalloonTip(100);
            }
            else
            {
                SqlCommand cmd = new SqlCommand(command, conn);
                loginProcess(cmd, user);
                
            }
        }

        public void loginProcess(SqlCommand cmd,String user)
        {
            try
            {
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                string result = reader.GetString(0);

                if (result.Contains("Hợp lệ"))
                {
                    string[] splitResult = result.Split(',');
                    string vaitro = splitResult[1];

                    ttloginsuccess.BalloonTipText += " " + user;
                    ttloginsuccess.ShowBalloonTip(50);

                    if (vaitro.Equals("Đại lý"))
                    {
                        reader.Close();
                        conn.Close();
                        movetoAgentForm(user);
                    }
                    else
                    {
                        reader.Close();
                        conn.Close();
                        movetoAccountantForm(user);
                    }
                }
                else
                {
                    reader.Close();
                    conn.Close();
                    ttllogin3.Visible = true;
                    ttllogin3.ShowBalloonTip(50);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        public void movetoAgentForm(string user)
        {
            Daily_home go = new Daily_home(user);
            this.Hide();
            go.ShowDialog();
            this.Close();



        }

        public void movetoAccountantForm(string user)
        {
            FormMain_kt go = new FormMain_kt(user);
            this.Hide();
            go.ShowDialog();
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
