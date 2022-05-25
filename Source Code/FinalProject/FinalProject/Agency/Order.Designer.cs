
namespace FinalProject
{
    partial class Order
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Order));
            this.dataProduct = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBank = new System.Windows.Forms.RadioButton();
            this.btnMomo = new System.Windows.Forms.RadioButton();
            this.btnOrder = new System.Windows.Forms.Button();
            this.orderInfo = new System.Windows.Forms.Panel();
            this.txtTotal = new System.Windows.Forms.Label();
            this.dataOrder = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnYes = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TT2 = new System.Windows.Forms.NotifyIcon(this.components);
            this.TT1 = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataProduct)).BeginInit();
            this.orderInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // dataProduct
            // 
            this.dataProduct.AllowUserToAddRows = false;
            this.dataProduct.AllowUserToDeleteRows = false;
            this.dataProduct.AllowUserToResizeColumns = false;
            this.dataProduct.AllowUserToResizeRows = false;
            this.dataProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataProduct.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataProduct.Location = new System.Drawing.Point(12, 66);
            this.dataProduct.Name = "dataProduct";
            this.dataProduct.RowHeadersVisible = false;
            this.dataProduct.RowHeadersWidth = 51;
            this.dataProduct.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.dataProduct.RowTemplate.Height = 36;
            this.dataProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataProduct.Size = new System.Drawing.Size(758, 475);
            this.dataProduct.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(391, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Payment Method: ";
            // 
            // btnBank
            // 
            this.btnBank.BackColor = System.Drawing.Color.Transparent;
            this.btnBank.ForeColor = System.Drawing.Color.White;
            this.btnBank.Location = new System.Drawing.Point(548, 12);
            this.btnBank.Name = "btnBank";
            this.btnBank.Size = new System.Drawing.Size(100, 24);
            this.btnBank.TabIndex = 2;
            this.btnBank.TabStop = true;
            this.btnBank.Text = "Banking";
            this.btnBank.UseVisualStyleBackColor = false;
            // 
            // btnMomo
            // 
            this.btnMomo.AutoSize = true;
            this.btnMomo.BackColor = System.Drawing.Color.Transparent;
            this.btnMomo.ForeColor = System.Drawing.Color.White;
            this.btnMomo.Location = new System.Drawing.Point(548, 41);
            this.btnMomo.Name = "btnMomo";
            this.btnMomo.Size = new System.Drawing.Size(66, 20);
            this.btnMomo.TabIndex = 3;
            this.btnMomo.TabStop = true;
            this.btnMomo.Text = "Momo";
            this.btnMomo.UseVisualStyleBackColor = false;
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(664, 12);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(106, 48);
            this.btnOrder.TabIndex = 4;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // orderInfo
            // 
            this.orderInfo.Controls.Add(this.txtTotal);
            this.orderInfo.Controls.Add(this.dataOrder);
            this.orderInfo.Controls.Add(this.label3);
            this.orderInfo.Controls.Add(this.btnCancel);
            this.orderInfo.Controls.Add(this.btnYes);
            this.orderInfo.Controls.Add(this.label2);
            this.orderInfo.Location = new System.Drawing.Point(12, 12);
            this.orderInfo.Name = "orderInfo";
            this.orderInfo.Size = new System.Drawing.Size(758, 529);
            this.orderInfo.TabIndex = 5;
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(21, 410);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(723, 25);
            this.txtTotal.TabIndex = 5;
            this.txtTotal.Text = "Tổng";
            this.txtTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataOrder
            // 
            this.dataOrder.AllowUserToAddRows = false;
            this.dataOrder.AllowUserToDeleteRows = false;
            this.dataOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataOrder.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataOrder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataOrder.Location = new System.Drawing.Point(24, 54);
            this.dataOrder.Name = "dataOrder";
            this.dataOrder.ReadOnly = true;
            this.dataOrder.RowHeadersVisible = false;
            this.dataOrder.RowHeadersWidth = 51;
            this.dataOrder.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.dataOrder.RowTemplate.Height = 36;
            this.dataOrder.RowTemplate.ReadOnly = true;
            this.dataOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataOrder.Size = new System.Drawing.Size(720, 340);
            this.dataOrder.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(510, 435);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 39);
            this.label3.TabIndex = 3;
            this.label3.Text = "Bạn có đồng ý đặt hàng?";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(514, 477);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 37);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Không";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnYes
            // 
            this.btnYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYes.Location = new System.Drawing.Point(652, 477);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(92, 37);
            this.btnYes.TabIndex = 0;
            this.btnYes.Text = "Có";
            this.btnYes.UseVisualStyleBackColor = true;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(758, 51);
            this.label2.TabIndex = 2;
            this.label2.Text = "Thông tin đơn hàng";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TT2
            // 
            this.TT2.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            this.TT2.BalloonTipText = "Quantity must >=0";
            this.TT2.BalloonTipTitle = "Wrong format";
            this.TT2.Icon = ((System.Drawing.Icon)(resources.GetObject("TT2.Icon")));
            this.TT2.Text = "notifyIcon1";
            this.TT2.Visible = true;
            // 
            // TT1
            // 
            this.TT1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            this.TT1.BalloonTipText = "Quantity must be \"integer\"";
            this.TT1.BalloonTipTitle = "Wrong format";
            this.TT1.Icon = ((System.Drawing.Icon)(resources.GetObject("TT1.Icon")));
            this.TT1.Text = "notifyIcon2";
            this.TT1.Visible = true;
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FinalProject.Properties.Resources.income_spend;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.orderInfo);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.btnMomo);
            this.Controls.Add(this.btnBank);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataProduct);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Order";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order";
            this.Load += new System.EventHandler(this.Order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataProduct)).EndInit();
            this.orderInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton btnBank;
        private System.Windows.Forms.RadioButton btnMomo;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Panel orderInfo;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.DataGridView dataOrder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtTotal;
        private System.Windows.Forms.NotifyIcon TT2;
        private System.Windows.Forms.NotifyIcon TT1;
    }
}