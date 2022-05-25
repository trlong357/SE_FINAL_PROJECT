
namespace FinalProject
{
    partial class ExportInfo
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
            this.btnPrint = new System.Windows.Forms.Button();
            this.exportBillid = new System.Windows.Forms.Label();
            this.exporterName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ordererName = new System.Windows.Forms.Label();
            this.dataExport = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataExport)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(777, 16);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(93, 41);
            this.btnPrint.TabIndex = 13;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // exportBillid
            // 
            this.exportBillid.Location = new System.Drawing.Point(8, 79);
            this.exportBillid.Name = "exportBillid";
            this.exportBillid.Size = new System.Drawing.Size(862, 28);
            this.exportBillid.TabIndex = 12;
            this.exportBillid.Text = "Export Bill\'s ID: ";
            this.exportBillid.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // exporterName
            // 
            this.exporterName.Location = new System.Drawing.Point(672, 509);
            this.exporterName.Name = "exporterName";
            this.exporterName.Size = new System.Drawing.Size(198, 63);
            this.exporterName.TabIndex = 11;
            this.exporterName.Text = "Exporter\'s Name";
            this.exporterName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(668, 468);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 28);
            this.label3.TabIndex = 10;
            this.label3.Text = "Exporter";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ordererName
            // 
            this.ordererName.Location = new System.Drawing.Point(5, 107);
            this.ordererName.Name = "ordererName";
            this.ordererName.Size = new System.Drawing.Size(862, 28);
            this.ordererName.TabIndex = 9;
            this.ordererName.Text = "Orderer\'s name: ";
            this.ordererName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataExport
            // 
            this.dataExport.AllowUserToAddRows = false;
            this.dataExport.AllowUserToDeleteRows = false;
            this.dataExport.AllowUserToResizeRows = false;
            this.dataExport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataExport.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataExport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataExport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataExport.Location = new System.Drawing.Point(8, 138);
            this.dataExport.Name = "dataExport";
            this.dataExport.ReadOnly = true;
            this.dataExport.RowHeadersVisible = false;
            this.dataExport.RowHeadersWidth = 51;
            this.dataExport.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dataExport.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.dataExport.RowTemplate.Height = 36;
            this.dataExport.RowTemplate.ReadOnly = true;
            this.dataExport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataExport.Size = new System.Drawing.Size(862, 327);
            this.dataExport.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(882, 64);
            this.label1.TabIndex = 7;
            this.label1.Text = "Delivery Note";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ExportInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 653);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.exportBillid);
            this.Controls.Add(this.exporterName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ordererName);
            this.Controls.Add(this.dataExport);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(900, 700);
            this.MinimumSize = new System.Drawing.Size(900, 700);
            this.Name = "ExportInfo";
            this.Text = "ExportForm";
            this.Load += new System.EventHandler(this.ExportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataExport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label exportBillid;
        private System.Windows.Forms.Label exporterName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ordererName;
        private System.Windows.Forms.DataGridView dataExport;
        private System.Windows.Forms.Label label1;
    }
}