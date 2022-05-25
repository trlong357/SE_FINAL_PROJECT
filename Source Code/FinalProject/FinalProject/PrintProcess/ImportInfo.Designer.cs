
namespace FinalProject
{
    partial class ImportInfo
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
            this.importBillid = new System.Windows.Forms.Label();
            this.importerName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataImport = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataImport)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(774, 12);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(93, 41);
            this.btnPrint.TabIndex = 20;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // importBillid
            // 
            this.importBillid.Location = new System.Drawing.Point(8, 96);
            this.importBillid.Name = "importBillid";
            this.importBillid.Size = new System.Drawing.Size(862, 28);
            this.importBillid.TabIndex = 19;
            this.importBillid.Text = "Import Bill\'s ID: ";
            this.importBillid.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // importerName
            // 
            this.importerName.Location = new System.Drawing.Point(672, 513);
            this.importerName.Name = "importerName";
            this.importerName.Size = new System.Drawing.Size(198, 68);
            this.importerName.TabIndex = 18;
            this.importerName.Text = "Importer\'s Name";
            this.importerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(668, 485);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 28);
            this.label3.TabIndex = 17;
            this.label3.Text = "Importer";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataImport
            // 
            this.dataImport.AllowUserToAddRows = false;
            this.dataImport.AllowUserToDeleteRows = false;
            this.dataImport.AllowUserToResizeRows = false;
            this.dataImport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataImport.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataImport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataImport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataImport.Location = new System.Drawing.Point(8, 155);
            this.dataImport.Name = "dataImport";
            this.dataImport.ReadOnly = true;
            this.dataImport.RowHeadersVisible = false;
            this.dataImport.RowHeadersWidth = 51;
            this.dataImport.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dataImport.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.dataImport.RowTemplate.Height = 36;
            this.dataImport.RowTemplate.ReadOnly = true;
            this.dataImport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataImport.Size = new System.Drawing.Size(862, 327);
            this.dataImport.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(882, 64);
            this.label1.TabIndex = 14;
            this.label1.Text = "Import Note";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ImportInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 653);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.importBillid);
            this.Controls.Add(this.importerName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataImport);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(900, 700);
            this.MinimumSize = new System.Drawing.Size(900, 700);
            this.Name = "ImportInfo";
            this.Text = "ImportInfo";
            this.Load += new System.EventHandler(this.ImportInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataImport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label importBillid;
        private System.Windows.Forms.Label importerName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataImport;
        private System.Windows.Forms.Label label1;
    }
}