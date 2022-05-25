
namespace FinalProject
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.txtuser = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.lblTaiKhoan = new System.Windows.Forms.Label();
            this.lblMatKhau = new System.Windows.Forms.Label();
            this.btnlogin = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.ttllogin3 = new System.Windows.Forms.NotifyIcon(this.components);
            this.TTlogin = new System.Windows.Forms.NotifyIcon(this.components);
            this.ttloginsuccess = new System.Windows.Forms.NotifyIcon(this.components);
            this.ttlogin2 = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // txtuser
            // 
            this.txtuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuser.Location = new System.Drawing.Point(203, 89);
            this.txtuser.Margin = new System.Windows.Forms.Padding(4);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(197, 30);
            this.txtuser.TabIndex = 0;
            this.txtuser.Text = "ketoan01";
            this.txtuser.Click += new System.EventHandler(this.txtTaiKhoan_TextChanged);
            this.txtuser.TextChanged += new System.EventHandler(this.txtTaiKhoan_TextChanged);
            // 
            // txtpass
            // 
            this.txtpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpass.Location = new System.Drawing.Point(203, 139);
            this.txtpass.Margin = new System.Windows.Forms.Padding(4);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(197, 30);
            this.txtpass.TabIndex = 1;
            this.txtpass.Text = "ketoan123";
            this.txtpass.UseSystemPasswordChar = true;
            this.txtpass.TextChanged += new System.EventHandler(this.txtMatKhau_TextChanged);
            // 
            // lblTaiKhoan
            // 
            this.lblTaiKhoan.AutoSize = true;
            this.lblTaiKhoan.BackColor = System.Drawing.Color.Transparent;
            this.lblTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaiKhoan.Location = new System.Drawing.Point(40, 89);
            this.lblTaiKhoan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTaiKhoan.Name = "lblTaiKhoan";
            this.lblTaiKhoan.Size = new System.Drawing.Size(108, 25);
            this.lblTaiKhoan.TabIndex = 2;
            this.lblTaiKhoan.Text = "Tài khoản";
            // 
            // lblMatKhau
            // 
            this.lblMatKhau.AutoSize = true;
            this.lblMatKhau.BackColor = System.Drawing.Color.Transparent;
            this.lblMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatKhau.Location = new System.Drawing.Point(40, 139);
            this.lblMatKhau.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(101, 25);
            this.lblMatKhau.TabIndex = 3;
            this.lblMatKhau.Text = "Mật khẩu";
            // 
            // btnlogin
            // 
            this.btnlogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlogin.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.Location = new System.Drawing.Point(45, 217);
            this.btnlogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(150, 35);
            this.btnlogin.TabIndex = 4;
            this.btnlogin.Text = "Đăng nhập";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnexit
            // 
            this.btnexit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnexit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Location = new System.Drawing.Point(250, 217);
            this.btnexit.Margin = new System.Windows.Forms.Padding(4);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(150, 35);
            this.btnexit.TabIndex = 5;
            this.btnexit.Text = "Thoát";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // ttllogin3
            // 
            this.ttllogin3.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Error;
            this.ttllogin3.BalloonTipText = "Sai tên tài khoản hoặc mật khẩu";
            this.ttllogin3.BalloonTipTitle = "Lỗi đăng nhập";
            this.ttllogin3.Icon = ((System.Drawing.Icon)(resources.GetObject("ttllogin3.Icon")));
            this.ttllogin3.Visible = true;
            // 
            // TTlogin
            // 
            this.TTlogin.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            this.TTlogin.BalloonTipText = "Tên tài khoản và mật khẩu không thể trống";
            this.TTlogin.BalloonTipTitle = "Lỗi đăng nhập";
            this.TTlogin.Icon = ((System.Drawing.Icon)(resources.GetObject("TTlogin.Icon")));
            this.TTlogin.Text = "notifyIcon1";
            this.TTlogin.Visible = true;
            // 
            // ttloginsuccess
            // 
            this.ttloginsuccess.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ttloginsuccess.BalloonTipText = "Đang sử dụng bởi tài khoản:";
            this.ttloginsuccess.BalloonTipTitle = "Đăng nhập thành công";
            this.ttloginsuccess.Icon = ((System.Drawing.Icon)(resources.GetObject("ttloginsuccess.Icon")));
            this.ttloginsuccess.Text = "notifyIcon1";
            this.ttloginsuccess.Visible = true;
            // 
            // ttlogin2
            // 
            this.ttlogin2.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            this.ttlogin2.BalloonTipText = "Mật khẩu dài hơn 6 kí tự";
            this.ttlogin2.BalloonTipTitle = "Lỗi đăng nhập";
            this.ttlogin2.Icon = ((System.Drawing.Icon)(resources.GetObject("ttlogin2.Icon")));
            this.ttlogin2.Text = "notifyIcon1";
            this.ttlogin2.Visible = true;
            // 
            // Login
            // 
            this.AcceptButton = this.btnlogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FinalProject.Properties.Resources.income_spend;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(444, 300);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.lblMatKhau);
            this.Controls.Add(this.lblTaiKhoan);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtuser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(444, 300);
            this.MinimumSize = new System.Drawing.Size(333, 300);
            this.Name = "Login";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "      ";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Label lblTaiKhoan;
        private System.Windows.Forms.Label lblMatKhau;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.NotifyIcon ttllogin3;
        private System.Windows.Forms.NotifyIcon TTlogin;
        private System.Windows.Forms.NotifyIcon ttloginsuccess;
        private System.Windows.Forms.NotifyIcon ttlogin2;
    }
}

