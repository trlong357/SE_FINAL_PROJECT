
namespace FinalProject
{
    partial class FormThongkeDT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormThongkeDT));
            this.statisticTables = new System.Windows.Forms.DataGridView();
            this.cbmonth = new System.Windows.Forms.ComboBox();
            this.cbyear = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtcome = new System.Windows.Forms.Label();
            this.txtspen = new System.Windows.Forms.Label();
            this.txtover = new System.Windows.Forms.Label();
            this.btntotal = new System.Windows.Forms.Button();
            this.noData = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.statisticTables)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // statisticTables
            // 
            this.statisticTables.AllowUserToAddRows = false;
            this.statisticTables.AllowUserToDeleteRows = false;
            this.statisticTables.AllowUserToResizeColumns = false;
            this.statisticTables.AllowUserToResizeRows = false;
            this.statisticTables.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.statisticTables.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.statisticTables.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.statisticTables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.statisticTables.Location = new System.Drawing.Point(13, 284);
            this.statisticTables.Margin = new System.Windows.Forms.Padding(4);
            this.statisticTables.Name = "statisticTables";
            this.statisticTables.ReadOnly = true;
            this.statisticTables.RowHeadersVisible = false;
            this.statisticTables.RowHeadersWidth = 51;
            this.statisticTables.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.statisticTables.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.statisticTables.RowTemplate.Height = 36;
            this.statisticTables.RowTemplate.ReadOnly = true;
            this.statisticTables.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.statisticTables.Size = new System.Drawing.Size(1129, 256);
            this.statisticTables.TabIndex = 3;
            this.statisticTables.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.statisticTables_CellContentClick);
            // 
            // cbmonth
            // 
            this.cbmonth.DropDownHeight = 160;
            this.cbmonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbmonth.FormattingEnabled = true;
            this.cbmonth.IntegralHeight = false;
            this.cbmonth.Location = new System.Drawing.Point(122, 20);
            this.cbmonth.MaxDropDownItems = 20;
            this.cbmonth.Name = "cbmonth";
            this.cbmonth.Size = new System.Drawing.Size(175, 28);
            this.cbmonth.TabIndex = 5;
            this.cbmonth.SelectedIndexChanged += new System.EventHandler(this.comboMonth_SelectedIndexChanged);
            // 
            // cbyear
            // 
            this.cbyear.DropDownHeight = 160;
            this.cbyear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbyear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbyear.FormattingEnabled = true;
            this.cbyear.IntegralHeight = false;
            this.cbyear.Location = new System.Drawing.Point(122, 65);
            this.cbyear.MaxDropDownItems = 20;
            this.cbyear.Name = "cbyear";
            this.cbyear.Size = new System.Drawing.Size(175, 28);
            this.cbyear.TabIndex = 6;
            this.cbyear.SelectedIndexChanged += new System.EventHandler(this.comboYear_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 28);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tháng";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 28);
            this.label2.TabIndex = 8;
            this.label2.Text = "Năm";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(256, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 30);
            this.label3.TabIndex = 9;
            this.label3.Text = "Thu nhập";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(572, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 30);
            this.label4.TabIndex = 10;
            this.label4.Text = "Chi tiêu";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(427, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 30);
            this.label5.TabIndex = 11;
            this.label5.Text = "Doanh thu";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtcome
            // 
            this.txtcome.BackColor = System.Drawing.Color.LightCyan;
            this.txtcome.Location = new System.Drawing.Point(261, 159);
            this.txtcome.Name = "txtcome";
            this.txtcome.Size = new System.Drawing.Size(231, 30);
            this.txtcome.TabIndex = 13;
            this.txtcome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtspen
            // 
            this.txtspen.BackColor = System.Drawing.Color.LightCyan;
            this.txtspen.Location = new System.Drawing.Point(577, 159);
            this.txtspen.Name = "txtspen";
            this.txtspen.Size = new System.Drawing.Size(231, 30);
            this.txtspen.TabIndex = 14;
            this.txtspen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtover
            // 
            this.txtover.BackColor = System.Drawing.Color.LightCyan;
            this.txtover.Location = new System.Drawing.Point(432, 232);
            this.txtover.Name = "txtover";
            this.txtover.Size = new System.Drawing.Size(231, 30);
            this.txtover.TabIndex = 15;
            this.txtover.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btntotal
            // 
            this.btntotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btntotal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btntotal.Location = new System.Drawing.Point(312, 40);
            this.btntotal.Name = "btntotal";
            this.btntotal.Size = new System.Drawing.Size(108, 34);
            this.btntotal.TabIndex = 17;
            this.btntotal.Text = "Tổng";
            this.btntotal.UseVisualStyleBackColor = false;
            this.btntotal.Click += new System.EventHandler(this.allBtn_Click);
            // 
            // noData
            // 
            this.noData.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.noData.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noData.Location = new System.Drawing.Point(10, 284);
            this.noData.Name = "noData";
            this.noData.Size = new System.Drawing.Size(1132, 256);
            this.noData.TabIndex = 18;
            this.noData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::FinalProject.Properties.Resources.more2;
            this.pictureBox2.Location = new System.Drawing.Point(1033, 216);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 65);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FinalProject.Properties.Resources.back3;
            this.pictureBox1.Location = new System.Drawing.Point(846, 216);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FormThongkeDT
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1145, 553);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btntotal);
            this.Controls.Add(this.txtover);
            this.Controls.Add(this.txtspen);
            this.Controls.Add(this.txtcome);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbyear);
            this.Controls.Add(this.cbmonth);
            this.Controls.Add(this.noData);
            this.Controls.Add(this.statisticTables);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormThongkeDT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "      ";
            this.Load += new System.EventHandler(this.FrmTKDT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.statisticTables)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView statisticTables;
        private System.Windows.Forms.ComboBox cbmonth;
        private System.Windows.Forms.ComboBox cbyear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label txtcome;
        private System.Windows.Forms.Label txtspen;
        private System.Windows.Forms.Label txtover;
        private System.Windows.Forms.Button btntotal;
        private System.Windows.Forms.Label noData;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}