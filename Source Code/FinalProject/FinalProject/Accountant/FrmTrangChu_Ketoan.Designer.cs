
namespace FinalProject
{
    partial class FormMain_kt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain_kt));
            this.Menubar = new System.Windows.Forms.MenuStrip();
            this.Nhapvao = new System.Windows.Forms.ToolStripMenuItem();
            this.xuatra = new System.Windows.Forms.ToolStripMenuItem();
            this.thongke = new System.Windows.Forms.ToolStripMenuItem();
            this.itemTKDT = new System.Windows.Forms.ToolStripMenuItem();
            this.itemTKHH = new System.Windows.Forms.ToolStripMenuItem();
            this.dangxuat = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.Menubar.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // Menubar
            // 
            this.Menubar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Menubar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Nhapvao,
            this.xuatra,
            this.thongke,
            this.dangxuat});
            this.Menubar.Location = new System.Drawing.Point(0, 0);
            this.Menubar.Name = "Menubar";
            this.Menubar.Size = new System.Drawing.Size(582, 28);
            this.Menubar.TabIndex = 0;
            this.Menubar.Text = "menuStrip1";
            // 
            // Nhapvao
            // 
            this.Nhapvao.Name = "Nhapvao";
            this.Nhapvao.Size = new System.Drawing.Size(109, 24);
            this.Nhapvao.Text = "Nhập dữ liệu";
            this.Nhapvao.Click += new System.EventHandler(this.itemNhapKho_Click);
            // 
            // xuatra
            // 
            this.xuatra.Name = "xuatra";
            this.xuatra.Size = new System.Drawing.Size(103, 24);
            this.xuatra.Text = "Xuất dữ liệu";
            this.xuatra.Click += new System.EventHandler(this.itemXuatKho_Click);
            // 
            // thongke
            // 
            this.thongke.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemTKDT,
            this.itemTKHH});
            this.thongke.Name = "thongke";
            this.thongke.Size = new System.Drawing.Size(84, 24);
            this.thongke.Text = "Thống kê";
            this.thongke.Click += new System.EventHandler(this.thongke_Click);
            // 
            // itemTKDT
            // 
            this.itemTKDT.Name = "itemTKDT";
            this.itemTKDT.Size = new System.Drawing.Size(300, 26);
            this.itemTKDT.Text = "Thống kê doanh thu theo tháng";
            this.itemTKDT.Click += new System.EventHandler(this.itemTKDT_Click);
            // 
            // itemTKHH
            // 
            this.itemTKHH.Name = "itemTKHH";
            this.itemTKHH.Size = new System.Drawing.Size(300, 26);
            this.itemTKHH.Text = "Thống kê hàng xuất khẩu";
            this.itemTKHH.Click += new System.EventHandler(this.itemTKHH_Click);
            // 
            // dangxuat
            // 
            this.dangxuat.Name = "dangxuat";
            this.dangxuat.Size = new System.Drawing.Size(91, 24);
            this.dangxuat.Text = "Đăng xuất";
            this.dangxuat.Click += new System.EventHandler(this.itemLogout_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox4, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 31);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(558, 377);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 431);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(480, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "PHẦN MỀM ĐƯỢC THIẾT KẾ BỞI: LONG TRẦN";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FinalProject.Properties.Resources.import;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(273, 182);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::FinalProject.Properties.Resources.ex;
            this.pictureBox2.Location = new System.Drawing.Point(282, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(273, 182);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::FinalProject.Properties.Resources.statistic;
            this.pictureBox3.Location = new System.Drawing.Point(3, 191);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(273, 183);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::FinalProject.Properties.Resources.logout;
            this.pictureBox4.Location = new System.Drawing.Point(282, 191);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(273, 183);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // FormMain_kt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 465);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.Menubar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.Menubar;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(600, 600);
            this.MinimumSize = new System.Drawing.Size(600, 500);
            this.Name = "FormMain_kt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý";
            this.Load += new System.EventHandler(this.FrmTrangChu_Load);
            this.Menubar.ResumeLayout(false);
            this.Menubar.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Menubar;
        private System.Windows.Forms.ToolStripMenuItem Nhapvao;
        private System.Windows.Forms.ToolStripMenuItem xuatra;
        private System.Windows.Forms.ToolStripMenuItem thongke;
        private System.Windows.Forms.ToolStripMenuItem itemTKDT;
        private System.Windows.Forms.ToolStripMenuItem itemTKHH;
        private System.Windows.Forms.ToolStripMenuItem dangxuat;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}