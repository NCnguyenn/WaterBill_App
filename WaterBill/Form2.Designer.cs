namespace WaterBill
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblCustomerType = new System.Windows.Forms.Label();
            this.lbNumberOfPeople = new System.Windows.Forms.Label();
            this.lblTotalWaterBill = new System.Windows.Forms.Label();
            this.lblPaymentTime = new System.Windows.Forms.Label();
            this.btnConfirmPayment = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.BackColor = System.Drawing.Color.Transparent;
            this.lblCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.Location = new System.Drawing.Point(254, 130);
            this.lblCustomerName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(106, 37);
            this.lblCustomerName.TabIndex = 0;
            this.lblCustomerName.Text = "label1";
            // 
            // lblCustomerType
            // 
            this.lblCustomerType.AutoSize = true;
            this.lblCustomerType.BackColor = System.Drawing.Color.Transparent;
            this.lblCustomerType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerType.Location = new System.Drawing.Point(252, 223);
            this.lblCustomerType.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCustomerType.Name = "lblCustomerType";
            this.lblCustomerType.Size = new System.Drawing.Size(108, 37);
            this.lblCustomerType.TabIndex = 1;
            this.lblCustomerType.Text = "label2";
            // 
            // lbNumberOfPeople
            // 
            this.lbNumberOfPeople.AutoSize = true;
            this.lbNumberOfPeople.BackColor = System.Drawing.Color.Transparent;
            this.lbNumberOfPeople.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumberOfPeople.Location = new System.Drawing.Point(532, 223);
            this.lbNumberOfPeople.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbNumberOfPeople.Name = "lbNumberOfPeople";
            this.lbNumberOfPeople.Size = new System.Drawing.Size(108, 37);
            this.lbNumberOfPeople.TabIndex = 2;
            this.lbNumberOfPeople.Text = "label3";
            // 
            // lblTotalWaterBill
            // 
            this.lblTotalWaterBill.AutoSize = true;
            this.lblTotalWaterBill.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalWaterBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalWaterBill.Location = new System.Drawing.Point(254, 318);
            this.lblTotalWaterBill.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTotalWaterBill.Name = "lblTotalWaterBill";
            this.lblTotalWaterBill.Size = new System.Drawing.Size(108, 37);
            this.lblTotalWaterBill.TabIndex = 3;
            this.lblTotalWaterBill.Text = "label4";
            // 
            // lblPaymentTime
            // 
            this.lblPaymentTime.AutoSize = true;
            this.lblPaymentTime.BackColor = System.Drawing.Color.Transparent;
            this.lblPaymentTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentTime.Location = new System.Drawing.Point(254, 401);
            this.lblPaymentTime.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPaymentTime.Name = "lblPaymentTime";
            this.lblPaymentTime.Size = new System.Drawing.Size(108, 37);
            this.lblPaymentTime.TabIndex = 5;
            this.lblPaymentTime.Text = "label6";
            // 
            // btnConfirmPayment
            // 
            this.btnConfirmPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmPayment.Location = new System.Drawing.Point(304, 518);
            this.btnConfirmPayment.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnConfirmPayment.Name = "btnConfirmPayment";
            this.btnConfirmPayment.Size = new System.Drawing.Size(320, 57);
            this.btnConfirmPayment.TabIndex = 6;
            this.btnConfirmPayment.Text = "Confirm Payment";
            this.btnConfirmPayment.UseVisualStyleBackColor = true;
            this.btnConfirmPayment.Click += new System.EventHandler(this.btnConfirmPayment_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(343, 35);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(315, 73);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "Water Bill";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(923, 607);
            this.Controls.Add(this.btnConfirmPayment);
            this.Controls.Add(this.lblPaymentTime);
            this.Controls.Add(this.lblTotalWaterBill);
            this.Controls.Add(this.lbNumberOfPeople);
            this.Controls.Add(this.lblCustomerType);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.lblName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblCustomerType;
        private System.Windows.Forms.Label lbNumberOfPeople;
        private System.Windows.Forms.Label lblTotalWaterBill;
        private System.Windows.Forms.Label lblPaymentTime;
        private System.Windows.Forms.Button btnConfirmPayment;
        private System.Windows.Forms.Label lblName;
    }
}