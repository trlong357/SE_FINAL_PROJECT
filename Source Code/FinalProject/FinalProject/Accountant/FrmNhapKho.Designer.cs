
namespace FinalProject
{
    partial class FrmNhapKho
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNhapKho));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.productList = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.HistoryList = new System.Windows.Forms.DataGridView();
            this.delebtn = new System.Windows.Forms.Button();
            this.updatebtn = new System.Windows.Forms.Button();
            this.backbtn = new System.Windows.Forms.Button();
            this.notifyWrongValue1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.ConfirmUpdate = new System.Windows.Forms.Panel();
            this.ListUpdate = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.rjupdate = new System.Windows.Forms.PictureBox();
            this.acpbtn = new System.Windows.Forms.PictureBox();
            this.notifyWrongValue2 = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifyUpdateSucces = new System.Windows.Forms.NotifyIcon(this.components);
            this.showbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.productList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HistoryList)).BeginInit();
            this.ConfirmUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rjupdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acpbtn)).BeginInit();
            this.SuspendLayout();
            // 
            // productList
            // 
            this.productList.AllowUserToAddRows = false;
            this.productList.AllowUserToDeleteRows = false;
            this.productList.AllowUserToResizeRows = false;
            this.productList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productList.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.productList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.productList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productList.Location = new System.Drawing.Point(13, 49);
            this.productList.Margin = new System.Windows.Forms.Padding(4);
            this.productList.MultiSelect = false;
            this.productList.Name = "productList";
            this.productList.RowHeadersVisible = false;
            this.productList.RowHeadersWidth = 51;
            this.productList.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.productList.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.productList.RowTemplate.Height = 36;
            this.productList.Size = new System.Drawing.Size(756, 300);
            this.productList.TabIndex = 8;
            this.productList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productList_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 36);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tất cả sản phẩm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 359);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 36);
            this.label3.TabIndex = 11;
            this.label3.Text = "Lịch sử nhập";
            // 
            // HistoryList
            // 
            this.HistoryList.AllowUserToAddRows = false;
            this.HistoryList.AllowUserToDeleteRows = false;
            this.HistoryList.AllowUserToResizeRows = false;
            this.HistoryList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.HistoryList.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.HistoryList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.HistoryList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HistoryList.Location = new System.Drawing.Point(13, 402);
            this.HistoryList.Margin = new System.Windows.Forms.Padding(4);
            this.HistoryList.MultiSelect = false;
            this.HistoryList.Name = "HistoryList";
            this.HistoryList.RowHeadersVisible = false;
            this.HistoryList.RowHeadersWidth = 51;
            this.HistoryList.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.HistoryList.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.HistoryList.RowTemplate.Height = 36;
            this.HistoryList.Size = new System.Drawing.Size(756, 333);
            this.HistoryList.TabIndex = 12;
            this.HistoryList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.historyList_CellContentClick);
            // 
            // delebtn
            // 
            this.delebtn.Location = new System.Drawing.Point(612, 5);
            this.delebtn.Name = "delebtn";
            this.delebtn.Size = new System.Drawing.Size(136, 40);
            this.delebtn.TabIndex = 14;
            this.delebtn.Text = "Xóa trắng";
            this.delebtn.UseVisualStyleBackColor = true;
            this.delebtn.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // updatebtn
            // 
            this.updatebtn.Location = new System.Drawing.Point(455, 5);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(136, 40);
            this.updatebtn.TabIndex = 15;
            this.updatebtn.Text = "Cập nhật";
            this.updatebtn.UseVisualStyleBackColor = true;
            this.updatebtn.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // backbtn
            // 
            this.backbtn.Location = new System.Drawing.Point(612, 355);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(136, 40);
            this.backbtn.TabIndex = 16;
            this.backbtn.Text = "Trở lại";
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // notifyWrongValue1
            // 
            this.notifyWrongValue1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            this.notifyWrongValue1.BalloonTipText = "Add.. must be \"integer\"";
            this.notifyWrongValue1.BalloonTipTitle = "Wrong format";
            this.notifyWrongValue1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyWrongValue1.Icon")));
            this.notifyWrongValue1.Text = "notifyIcon1";
            this.notifyWrongValue1.Visible = true;
            // 
            // ConfirmUpdate
            // 
            this.ConfirmUpdate.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ConfirmUpdate.Controls.Add(this.ListUpdate);
            this.ConfirmUpdate.Controls.Add(this.label2);
            this.ConfirmUpdate.Controls.Add(this.rjupdate);
            this.ConfirmUpdate.Controls.Add(this.acpbtn);
            this.ConfirmUpdate.Location = new System.Drawing.Point(13, 48);
            this.ConfirmUpdate.Name = "ConfirmUpdate";
            this.ConfirmUpdate.Size = new System.Drawing.Size(756, 301);
            this.ConfirmUpdate.TabIndex = 17;
            // 
            // ListUpdate
            // 
            this.ListUpdate.AllowUserToAddRows = false;
            this.ListUpdate.AllowUserToDeleteRows = false;
            this.ListUpdate.AllowUserToOrderColumns = true;
            this.ListUpdate.AllowUserToResizeRows = false;
            this.ListUpdate.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ListUpdate.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ListUpdate.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.ListUpdate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListUpdate.Location = new System.Drawing.Point(13, 14);
            this.ListUpdate.Name = "ListUpdate";
            this.ListUpdate.ReadOnly = true;
            this.ListUpdate.RowHeadersVisible = false;
            this.ListUpdate.RowHeadersWidth = 51;
            this.ListUpdate.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ListUpdate.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.ListUpdate.RowTemplate.Height = 36;
            this.ListUpdate.RowTemplate.ReadOnly = true;
            this.ListUpdate.Size = new System.Drawing.Size(728, 181);
            this.ListUpdate.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(284, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(443, 40);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hành động không thể hoàn tác. Bạn có muốn tiếp tục?";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // rjupdate
            // 
            this.rjupdate.BackColor = System.Drawing.Color.Transparent;
            this.rjupdate.BackgroundImage = global::FinalProject.Properties.Resources.cance;
            this.rjupdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rjupdate.Image = global::FinalProject.Properties.Resources.cance;
            this.rjupdate.Location = new System.Drawing.Point(620, 249);
            this.rjupdate.Name = "rjupdate";
            this.rjupdate.Size = new System.Drawing.Size(43, 44);
            this.rjupdate.TabIndex = 1;
            this.rjupdate.TabStop = false;
            this.rjupdate.Click += new System.EventHandler(this.rejectUpdate_Click);
            // 
            // acpbtn
            // 
            this.acpbtn.BackColor = System.Drawing.Color.Transparent;
            this.acpbtn.BackgroundImage = global::FinalProject.Properties.Resources.acept;
            this.acpbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.acpbtn.Image = global::FinalProject.Properties.Resources.acept;
            this.acpbtn.Location = new System.Drawing.Point(683, 249);
            this.acpbtn.Name = "acpbtn";
            this.acpbtn.Size = new System.Drawing.Size(44, 44);
            this.acpbtn.TabIndex = 0;
            this.acpbtn.TabStop = false;
            this.acpbtn.Click += new System.EventHandler(this.acceptUpdate_Click);
            // 
            // notifyWrongValue2
            // 
            this.notifyWrongValue2.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            this.notifyWrongValue2.BalloonTipText = "Input value must >=0";
            this.notifyWrongValue2.BalloonTipTitle = "Wrong format";
            this.notifyWrongValue2.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyWrongValue2.Icon")));
            this.notifyWrongValue2.Text = "notifyIcon1";
            this.notifyWrongValue2.Visible = true;
            // 
            // notifyUpdateSucces
            // 
            this.notifyUpdateSucces.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyUpdateSucces.BalloonTipText = "1 item has been added to history";
            this.notifyUpdateSucces.BalloonTipTitle = "UpdateSucces";
            this.notifyUpdateSucces.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyUpdateSucces.Icon")));
            this.notifyUpdateSucces.Text = "notifyIcon1";
            this.notifyUpdateSucces.Visible = true;
            // 
            // showbtn
            // 
            this.showbtn.Location = new System.Drawing.Point(297, 355);
            this.showbtn.Name = "showbtn";
            this.showbtn.Size = new System.Drawing.Size(136, 40);
            this.showbtn.TabIndex = 18;
            this.showbtn.Text = "Hiển thị";
            this.showbtn.UseVisualStyleBackColor = true;
            this.showbtn.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // FrmNhapKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(782, 748);
            this.ControlBox = false;
            this.Controls.Add(this.showbtn);
            this.Controls.Add(this.ConfirmUpdate);
            this.Controls.Add(this.productList);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.updatebtn);
            this.Controls.Add(this.delebtn);
            this.Controls.Add(this.HistoryList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(800, 766);
            this.MinimumSize = new System.Drawing.Size(800, 766);
            this.Name = "FrmNhapKho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmNhapKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HistoryList)).EndInit();
            this.ConfirmUpdate.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ListUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rjupdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acpbtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView productList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView HistoryList;
        private System.Windows.Forms.Button delebtn;
        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.NotifyIcon notifyWrongValue1;
        private System.Windows.Forms.Panel ConfirmUpdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox rjupdate;
        private System.Windows.Forms.PictureBox acpbtn;
        private System.Windows.Forms.DataGridView ListUpdate;
        private System.Windows.Forms.NotifyIcon notifyWrongValue2;
        private System.Windows.Forms.NotifyIcon notifyUpdateSucces;
        private System.Windows.Forms.Button showbtn;
    }
}