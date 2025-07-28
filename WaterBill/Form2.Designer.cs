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
            this.lalName = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblTotalWaterBill = new System.Windows.Forms.Label();
            this.lblCustomerType = new System.Windows.Forms.Label();
            this.lblNumberOfPeople = new System.Windows.Forms.Label();
            this.lblPaymentTime = new System.Windows.Forms.Label();
            this.btnConfirmPayment = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lalName
            // 
            this.lalName.AutoSize = true;
            this.lalName.BackColor = System.Drawing.Color.Transparent;
            this.lalName.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lalName.Location = new System.Drawing.Point(375, 39);
            this.lalName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lalName.Name = "lalName";
            this.lalName.Size = new System.Drawing.Size(260, 61);
            this.lalName.TabIndex = 0;
            this.lalName.Text = "Water Bill";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.BackColor = System.Drawing.Color.Transparent;
            this.lblCustomerName.Location = new System.Drawing.Point(380, 166);
            this.lblCustomerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(92, 31);
            this.lblCustomerName.TabIndex = 1;
            this.lblCustomerName.Text = "label2";
            // 
            // lblTotalWaterBill
            // 
            this.lblTotalWaterBill.AutoSize = true;
            this.lblTotalWaterBill.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalWaterBill.Location = new System.Drawing.Point(380, 350);
            this.lblTotalWaterBill.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalWaterBill.Name = "lblTotalWaterBill";
            this.lblTotalWaterBill.Size = new System.Drawing.Size(92, 31);
            this.lblTotalWaterBill.TabIndex = 2;
            this.lblTotalWaterBill.Text = "label3";
            // 
            // lblCustomerType
            // 
            this.lblCustomerType.AutoSize = true;
            this.lblCustomerType.BackColor = System.Drawing.Color.Transparent;
            this.lblCustomerType.Location = new System.Drawing.Point(380, 261);
            this.lblCustomerType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustomerType.Name = "lblCustomerType";
            this.lblCustomerType.Size = new System.Drawing.Size(92, 31);
            this.lblCustomerType.TabIndex = 3;
            this.lblCustomerType.Text = "label4";
            // 
            // lblNumberOfPeople
            // 
            this.lblNumberOfPeople.AutoSize = true;
            this.lblNumberOfPeople.BackColor = System.Drawing.Color.Transparent;
            this.lblNumberOfPeople.Location = new System.Drawing.Point(717, 261);
            this.lblNumberOfPeople.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumberOfPeople.Name = "lblNumberOfPeople";
            this.lblNumberOfPeople.Size = new System.Drawing.Size(92, 31);
            this.lblNumberOfPeople.TabIndex = 4;
            this.lblNumberOfPeople.Text = "label5";
            // 
            // lblPaymentTime
            // 
            this.lblPaymentTime.AutoSize = true;
            this.lblPaymentTime.BackColor = System.Drawing.Color.Transparent;
            this.lblPaymentTime.Location = new System.Drawing.Point(380, 440);
            this.lblPaymentTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPaymentTime.Name = "lblPaymentTime";
            this.lblPaymentTime.Size = new System.Drawing.Size(92, 31);
            this.lblPaymentTime.TabIndex = 5;
            this.lblPaymentTime.Text = "label6";
            // 
            // btnConfirmPayment
            // 
            this.btnConfirmPayment.Location = new System.Drawing.Point(386, 585);
            this.btnConfirmPayment.Name = "btnConfirmPayment";
            this.btnConfirmPayment.Size = new System.Drawing.Size(290, 50);
            this.btnConfirmPayment.TabIndex = 6;
            this.btnConfirmPayment.Text = "Confirm payment";
            this.btnConfirmPayment.UseVisualStyleBackColor = true;
            this.btnConfirmPayment.Click += new System.EventHandler(this.btnConfirmPayment_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(990, 669);
            this.Controls.Add(this.btnConfirmPayment);
            this.Controls.Add(this.lblPaymentTime);
            this.Controls.Add(this.lblNumberOfPeople);
            this.Controls.Add(this.lblCustomerType);
            this.Controls.Add(this.lblTotalWaterBill);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.lalName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lalName;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblTotalWaterBill;
        private System.Windows.Forms.Label lblCustomerType;
        private System.Windows.Forms.Label lblNumberOfPeople;
        private System.Windows.Forms.Label lblPaymentTime;
        private System.Windows.Forms.Button btnConfirmPayment;
    }
}