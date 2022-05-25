
namespace FinalProject
{
    partial class Daily_home
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Daily_home));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BTNTAILAI = new System.Windows.Forms.Button();
            this.BTNDANGXUAT = new System.Windows.Forms.Button();
            this.TXT_HOTEN = new System.Windows.Forms.Label();
            this.BTNTAOMOI = new System.Windows.Forms.Button();
            this.TXTDIACHI = new System.Windows.Forms.Label();
            this.TXTSODIENTHOAI = new System.Windows.Forms.Label();
            this.Txt_SOPHIEU = new System.Windows.Forms.Label();
            this.BTNXULI = new System.Windows.Forms.Button();
            this.BTNDANGGIAOHANG = new System.Windows.Forms.Button();
            this.BTNLICHSUGIAOHANG = new System.Windows.Forms.Button();
            this.PANEL_XU_LI = new System.Windows.Forms.Panel();
            this.LISTXULI = new System.Windows.Forms.DataGridView();
            this.historyPanel = new System.Windows.Forms.Panel();
            this.dataHistory = new System.Windows.Forms.DataGridView();
            this.shippedPanel = new System.Windows.Forms.Panel();
            this.dataShipped = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.PANEL_XU_LI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LISTXULI)).BeginInit();
            this.historyPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataHistory)).BeginInit();
            this.shippedPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataShipped)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.BTNTAILAI);
            this.panel1.Controls.Add(this.BTNDANGXUAT);
            this.panel1.Controls.Add(this.TXT_HOTEN);
            this.panel1.Controls.Add(this.BTNTAOMOI);
            this.panel1.Controls.Add(this.TXTDIACHI);
            this.panel1.Controls.Add(this.TXTSODIENTHOAI);
            this.panel1.Controls.Add(this.Txt_SOPHIEU);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 528);
            this.panel1.TabIndex = 0;
            // 
            // BTNTAILAI
            // 
            this.BTNTAILAI.Location = new System.Drawing.Point(108, 399);
            this.BTNTAILAI.Name = "BTNTAILAI";
            this.BTNTAILAI.Size = new System.Drawing.Size(142, 47);
            this.BTNTAILAI.TabIndex = 8;
            this.BTNTAILAI.Text = "Tải lại";
            this.BTNTAILAI.UseVisualStyleBackColor = true;
            this.BTNTAILAI.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // BTNDANGXUAT
            // 
            this.BTNDANGXUAT.Location = new System.Drawing.Point(17, 467);
            this.BTNDANGXUAT.Name = "BTNDANGXUAT";
            this.BTNDANGXUAT.Size = new System.Drawing.Size(142, 44);
            this.BTNDANGXUAT.TabIndex = 7;
            this.BTNDANGXUAT.Text = "Đăng xuất";
            this.BTNDANGXUAT.UseVisualStyleBackColor = true;
            this.BTNDANGXUAT.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // TXT_HOTEN
            // 
            this.TXT_HOTEN.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.TXT_HOTEN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_HOTEN.Location = new System.Drawing.Point(14, 74);
            this.TXT_HOTEN.Name = "TXT_HOTEN";
            this.TXT_HOTEN.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.TXT_HOTEN.Size = new System.Drawing.Size(320, 40);
            this.TXT_HOTEN.TabIndex = 6;
            this.TXT_HOTEN.Text = "Họ tên";
            this.TXT_HOTEN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BTNTAOMOI
            // 
            this.BTNTAOMOI.Location = new System.Drawing.Point(192, 467);
            this.BTNTAOMOI.Name = "BTNTAOMOI";
            this.BTNTAOMOI.Size = new System.Drawing.Size(142, 44);
            this.BTNTAOMOI.TabIndex = 4;
            this.BTNTAOMOI.Text = "Đơn hàng mới";
            this.BTNTAOMOI.UseVisualStyleBackColor = true;
            this.BTNTAOMOI.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // TXTDIACHI
            // 
            this.TXTDIACHI.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.TXTDIACHI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTDIACHI.Location = new System.Drawing.Point(14, 174);
            this.TXTDIACHI.Name = "TXTDIACHI";
            this.TXTDIACHI.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.TXTDIACHI.Size = new System.Drawing.Size(320, 80);
            this.TXTDIACHI.TabIndex = 2;
            this.TXTDIACHI.Text = "Địa chỉ";
            // 
            // TXTSODIENTHOAI
            // 
            this.TXTSODIENTHOAI.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.TXTSODIENTHOAI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTSODIENTHOAI.Location = new System.Drawing.Point(14, 114);
            this.TXTSODIENTHOAI.Name = "TXTSODIENTHOAI";
            this.TXTSODIENTHOAI.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.TXTSODIENTHOAI.Size = new System.Drawing.Size(320, 40);
            this.TXTSODIENTHOAI.TabIndex = 1;
            this.TXTSODIENTHOAI.Text = "Số điện thoại";
            this.TXTSODIENTHOAI.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Txt_SOPHIEU
            // 
            this.Txt_SOPHIEU.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Txt_SOPHIEU.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_SOPHIEU.Location = new System.Drawing.Point(14, 14);
            this.Txt_SOPHIEU.Name = "Txt_SOPHIEU";
            this.Txt_SOPHIEU.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Txt_SOPHIEU.Size = new System.Drawing.Size(320, 40);
            this.Txt_SOPHIEU.TabIndex = 0;
            this.Txt_SOPHIEU.Text = "Số phiếu";
            this.Txt_SOPHIEU.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BTNXULI
            // 
            this.BTNXULI.BackColor = System.Drawing.Color.Goldenrod;
            this.BTNXULI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNXULI.ForeColor = System.Drawing.Color.White;
            this.BTNXULI.Location = new System.Drawing.Point(462, 499);
            this.BTNXULI.Name = "BTNXULI";
            this.BTNXULI.Size = new System.Drawing.Size(142, 44);
            this.BTNXULI.TabIndex = 1;
            this.BTNXULI.Text = "Đang xử lí";
            this.BTNXULI.UseVisualStyleBackColor = false;
            this.BTNXULI.Click += new System.EventHandler(this.btnPending_Click);
            // 
            // BTNDANGGIAOHANG
            // 
            this.BTNDANGGIAOHANG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BTNDANGGIAOHANG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNDANGGIAOHANG.Location = new System.Drawing.Point(610, 497);
            this.BTNDANGGIAOHANG.Name = "BTNDANGGIAOHANG";
            this.BTNDANGGIAOHANG.Size = new System.Drawing.Size(142, 44);
            this.BTNDANGGIAOHANG.TabIndex = 2;
            this.BTNDANGGIAOHANG.Text = "Đang giao";
            this.BTNDANGGIAOHANG.UseVisualStyleBackColor = false;
            this.BTNDANGGIAOHANG.Click += new System.EventHandler(this.btnShipped_Click);
            // 
            // BTNLICHSUGIAOHANG
            // 
            this.BTNLICHSUGIAOHANG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BTNLICHSUGIAOHANG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNLICHSUGIAOHANG.Location = new System.Drawing.Point(758, 497);
            this.BTNLICHSUGIAOHANG.Name = "BTNLICHSUGIAOHANG";
            this.BTNLICHSUGIAOHANG.Size = new System.Drawing.Size(142, 44);
            this.BTNLICHSUGIAOHANG.TabIndex = 3;
            this.BTNLICHSUGIAOHANG.Text = "Lịch sử ";
            this.BTNLICHSUGIAOHANG.UseVisualStyleBackColor = false;
            this.BTNLICHSUGIAOHANG.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // PANEL_XU_LI
            // 
            this.PANEL_XU_LI.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.PANEL_XU_LI.Controls.Add(this.LISTXULI);
            this.PANEL_XU_LI.Location = new System.Drawing.Point(392, 60);
            this.PANEL_XU_LI.Name = "PANEL_XU_LI";
            this.PANEL_XU_LI.Size = new System.Drawing.Size(578, 414);
            this.PANEL_XU_LI.TabIndex = 4;
            // 
            // LISTXULI
            // 
            this.LISTXULI.AllowUserToAddRows = false;
            this.LISTXULI.AllowUserToDeleteRows = false;
            this.LISTXULI.AllowUserToResizeColumns = false;
            this.LISTXULI.AllowUserToResizeRows = false;
            this.LISTXULI.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.LISTXULI.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.LISTXULI.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.LISTXULI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LISTXULI.Location = new System.Drawing.Point(-11, -48);
            this.LISTXULI.Name = "LISTXULI";
            this.LISTXULI.ReadOnly = true;
            this.LISTXULI.RowHeadersVisible = false;
            this.LISTXULI.RowHeadersWidth = 51;
            this.LISTXULI.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LISTXULI.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LISTXULI.RowTemplate.Height = 36;
            this.LISTXULI.RowTemplate.ReadOnly = true;
            this.LISTXULI.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.LISTXULI.Size = new System.Drawing.Size(589, 541);
            this.LISTXULI.TabIndex = 0;
            // 
            // historyPanel
            // 
            this.historyPanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.historyPanel.Controls.Add(this.dataHistory);
            this.historyPanel.Location = new System.Drawing.Point(392, 60);
            this.historyPanel.Name = "historyPanel";
            this.historyPanel.Size = new System.Drawing.Size(578, 420);
            this.historyPanel.TabIndex = 5;
            // 
            // dataHistory
            // 
            this.dataHistory.AllowUserToAddRows = false;
            this.dataHistory.AllowUserToDeleteRows = false;
            this.dataHistory.AllowUserToResizeColumns = false;
            this.dataHistory.AllowUserToResizeRows = false;
            this.dataHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataHistory.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataHistory.Location = new System.Drawing.Point(3, 3);
            this.dataHistory.Name = "dataHistory";
            this.dataHistory.ReadOnly = true;
            this.dataHistory.RowHeadersVisible = false;
            this.dataHistory.RowHeadersWidth = 51;
            this.dataHistory.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dataHistory.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.dataHistory.RowTemplate.Height = 36;
            this.dataHistory.RowTemplate.ReadOnly = true;
            this.dataHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataHistory.Size = new System.Drawing.Size(572, 475);
            this.dataHistory.TabIndex = 0;
            // 
            // shippedPanel
            // 
            this.shippedPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.shippedPanel.Controls.Add(this.dataShipped);
            this.shippedPanel.Location = new System.Drawing.Point(392, 61);
            this.shippedPanel.Name = "shippedPanel";
            this.shippedPanel.Size = new System.Drawing.Size(578, 413);
            this.shippedPanel.TabIndex = 6;
            // 
            // dataShipped
            // 
            this.dataShipped.AllowUserToAddRows = false;
            this.dataShipped.AllowUserToDeleteRows = false;
            this.dataShipped.AllowUserToResizeColumns = false;
            this.dataShipped.AllowUserToResizeRows = false;
            this.dataShipped.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataShipped.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataShipped.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataShipped.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataShipped.Location = new System.Drawing.Point(3, 3);
            this.dataShipped.Name = "dataShipped";
            this.dataShipped.ReadOnly = true;
            this.dataShipped.RowHeadersVisible = false;
            this.dataShipped.RowHeadersWidth = 51;
            this.dataShipped.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dataShipped.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.dataShipped.RowTemplate.Height = 36;
            this.dataShipped.RowTemplate.ReadOnly = true;
            this.dataShipped.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataShipped.Size = new System.Drawing.Size(572, 474);
            this.dataShipped.TabIndex = 0;
            this.dataShipped.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataShipped_CellContentClick);
            // 
            // Daily_home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.ControlBox = false;
            this.Controls.Add(this.BTNLICHSUGIAOHANG);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BTNDANGGIAOHANG);
            this.Controls.Add(this.PANEL_XU_LI);
            this.Controls.Add(this.BTNXULI);
            this.Controls.Add(this.historyPanel);
            this.Controls.Add(this.shippedPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1000, 600);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "Daily_home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Trang chủ";
            this.Load += new System.EventHandler(this.FrmTrangChu_Daily_Load);
            this.panel1.ResumeLayout(false);
            this.PANEL_XU_LI.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LISTXULI)).EndInit();
            this.historyPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataHistory)).EndInit();
            this.shippedPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataShipped)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label TXT_HOTEN;
        private System.Windows.Forms.Button BTNTAOMOI;
        private System.Windows.Forms.Label TXTDIACHI;
        private System.Windows.Forms.Label TXTSODIENTHOAI;
        private System.Windows.Forms.Label Txt_SOPHIEU;
        private System.Windows.Forms.Button BTNXULI;
        private System.Windows.Forms.Button BTNDANGGIAOHANG;
        private System.Windows.Forms.Button BTNLICHSUGIAOHANG;
        private System.Windows.Forms.Button BTNDANGXUAT;
        private System.Windows.Forms.Panel PANEL_XU_LI;
        private System.Windows.Forms.DataGridView LISTXULI;
        private System.Windows.Forms.Panel historyPanel;
        private System.Windows.Forms.DataGridView dataHistory;
        private System.Windows.Forms.Panel shippedPanel;
        private System.Windows.Forms.DataGridView dataShipped;
        private System.Windows.Forms.Button BTNTAILAI;
    }
}