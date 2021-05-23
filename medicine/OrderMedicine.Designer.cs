namespace medicine
{
    partial class OrderMedicine
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
            this.labelMedicine = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtMName = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblMName = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblAQuantity = new System.Windows.Forms.Label();
            this.txtTPrice = new System.Windows.Forms.TextBox();
            this.lblDAddress = new System.Windows.Forms.Label();
            this.rtxtDAddress = new System.Windows.Forms.RichTextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.dgvOrderInfo = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // labelMedicine
            // 
            this.labelMedicine.AutoSize = true;
            this.labelMedicine.BackColor = System.Drawing.Color.Transparent;
            this.labelMedicine.Font = new System.Drawing.Font("Matura MT Script Capitals", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMedicine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelMedicine.Location = new System.Drawing.Point(341, 22);
            this.labelMedicine.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelMedicine.Name = "labelMedicine";
            this.labelMedicine.Size = new System.Drawing.Size(257, 47);
            this.labelMedicine.TabIndex = 1;
            this.labelMedicine.Text = "Order Details";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Controls.Add(this.labelMedicine);
            this.panel1.Location = new System.Drawing.Point(-5, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(934, 96);
            this.panel1.TabIndex = 2;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(845, 70);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(75, 23);
            this.btnLogOut.TabIndex = 3;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(245, 152);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(302, 31);
            this.txtPrice.TabIndex = 15;
            // 
            // txtMName
            // 
            this.txtMName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMName.Location = new System.Drawing.Point(245, 109);
            this.txtMName.Name = "txtMName";
            this.txtMName.Size = new System.Drawing.Size(302, 31);
            this.txtMName.TabIndex = 14;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(32, 155);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(121, 25);
            this.lblPrice.TabIndex = 13;
            this.lblPrice.Text = "Price(unit)";
            // 
            // lblMName
            // 
            this.lblMName.AutoSize = true;
            this.lblMName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMName.Location = new System.Drawing.Point(32, 112);
            this.lblMName.Name = "lblMName";
            this.lblMName.Size = new System.Drawing.Size(174, 25);
            this.lblMName.TabIndex = 12;
            this.lblMName.Text = "Medicine Name";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.Location = new System.Drawing.Point(32, 242);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(126, 25);
            this.lblTotalPrice.TabIndex = 16;
            this.lblTotalPrice.Text = "Total Price";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(245, 193);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(302, 31);
            this.txtQuantity.TabIndex = 18;
            // 
            // lblAQuantity
            // 
            this.lblAQuantity.AutoSize = true;
            this.lblAQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAQuantity.Location = new System.Drawing.Point(32, 193);
            this.lblAQuantity.Name = "lblAQuantity";
            this.lblAQuantity.Size = new System.Drawing.Size(100, 25);
            this.lblAQuantity.TabIndex = 17;
            this.lblAQuantity.Text = "Quantity";
            // 
            // txtTPrice
            // 
            this.txtTPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTPrice.Location = new System.Drawing.Point(245, 239);
            this.txtTPrice.Name = "txtTPrice";
            this.txtTPrice.Size = new System.Drawing.Size(302, 31);
            this.txtTPrice.TabIndex = 19;
            // 
            // lblDAddress
            // 
            this.lblDAddress.AutoSize = true;
            this.lblDAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDAddress.Location = new System.Drawing.Point(32, 335);
            this.lblDAddress.Name = "lblDAddress";
            this.lblDAddress.Size = new System.Drawing.Size(191, 25);
            this.lblDAddress.TabIndex = 20;
            this.lblDAddress.Text = "Delivery Address";
            // 
            // rtxtDAddress
            // 
            this.rtxtDAddress.Location = new System.Drawing.Point(245, 292);
            this.rtxtDAddress.Name = "rtxtDAddress";
            this.rtxtDAddress.Size = new System.Drawing.Size(302, 96);
            this.rtxtDAddress.TabIndex = 21;
            this.rtxtDAddress.Text = "";
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.Maroon;
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.Location = new System.Drawing.Point(416, 415);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(122, 51);
            this.btnConfirm.TabIndex = 23;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.confirmOrder);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Black;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(245, 415);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(122, 51);
            this.btnBack.TabIndex = 24;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dgvOrderInfo
            // 
            this.dgvOrderInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderInfo.Location = new System.Drawing.Point(553, 109);
            this.dgvOrderInfo.Name = "dgvOrderInfo";
            this.dgvOrderInfo.Size = new System.Drawing.Size(376, 330);
            this.dgvOrderInfo.TabIndex = 25;
            // 
            // OrderMedicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(942, 537);
            this.Controls.Add(this.dgvOrderInfo);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.rtxtDAddress);
            this.Controls.Add(this.lblDAddress);
            this.Controls.Add(this.txtTPrice);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.lblAQuantity);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtMName);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblMName);
            this.Controls.Add(this.panel1);
            this.Name = "OrderMedicine";
            this.Text = "OrderMedicine";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelMedicine;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtMName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblMName;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblAQuantity;
        private System.Windows.Forms.TextBox txtTPrice;
        private System.Windows.Forms.Label lblDAddress;
        private System.Windows.Forms.RichTextBox rtxtDAddress;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.DataGridView dgvOrderInfo;
    }
}