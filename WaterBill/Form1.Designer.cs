﻿namespace WaterBill
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCaculator = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbTypeOfCustomer = new System.Windows.Forms.Label();
            this.lbThisMonthWaterMeter = new System.Windows.Forms.Label();
            this.txtThisMonthWaterMeter = new System.Windows.Forms.TextBox();
            this.lbCustomerName = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtLastMonthWaterMeter = new System.Windows.Forms.TextBox();
            this.lbLastMonthWaterMeter = new System.Windows.Forms.Label();
            this.txtNumberOfPeople = new System.Windows.Forms.TextBox();
            this.cboTypeOfCustomer = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lbSearch = new System.Windows.Forms.Label();
            this.lvWaterBill = new System.Windows.Forms.ListView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.iconrestaurar = new System.Windows.Forms.PictureBox();
            this.iconmaximizar = new System.Windows.Forms.PictureBox();
            this.iconminimizar = new System.Windows.Forms.PictureBox();
            this.iconexit = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnPay = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cboSortOption = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconrestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconmaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconminimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconexit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(435, 710);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnCaculator);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lbTypeOfCustomer);
            this.groupBox1.Controls.Add(this.lbThisMonthWaterMeter);
            this.groupBox1.Controls.Add(this.txtThisMonthWaterMeter);
            this.groupBox1.Controls.Add(this.lbCustomerName);
            this.groupBox1.Controls.Add(this.txtCustomerName);
            this.groupBox1.Controls.Add(this.txtLastMonthWaterMeter);
            this.groupBox1.Controls.Add(this.lbLastMonthWaterMeter);
            this.groupBox1.Controls.Add(this.txtNumberOfPeople);
            this.groupBox1.Controls.Add(this.cboTypeOfCustomer);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(0, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(448, 860);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Information";
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(215, 570);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(143, 46);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCaculator
            // 
            this.btnCaculator.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaculator.ForeColor = System.Drawing.Color.Black;
            this.btnCaculator.Location = new System.Drawing.Point(10, 570);
            this.btnCaculator.Name = "btnCaculator";
            this.btnCaculator.Size = new System.Drawing.Size(137, 46);
            this.btnCaculator.TabIndex = 10;
            this.btnCaculator.Text = "Calculator";
            this.btnCaculator.UseVisualStyleBackColor = true;
            this.btnCaculator.Click += new System.EventHandler(this.btnCaculator_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(3, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(261, 39);
            this.label2.TabIndex = 2;
            this.label2.Text = "Number Of People";
            // 
            // lbTypeOfCustomer
            // 
            this.lbTypeOfCustomer.AutoSize = true;
            this.lbTypeOfCustomer.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTypeOfCustomer.ForeColor = System.Drawing.Color.Black;
            this.lbTypeOfCustomer.Location = new System.Drawing.Point(6, 160);
            this.lbTypeOfCustomer.Name = "lbTypeOfCustomer";
            this.lbTypeOfCustomer.Size = new System.Drawing.Size(254, 39);
            this.lbTypeOfCustomer.TabIndex = 1;
            this.lbTypeOfCustomer.Text = "Type Of Customer";
            // 
            // lbThisMonthWaterMeter
            // 
            this.lbThisMonthWaterMeter.AutoSize = true;
            this.lbThisMonthWaterMeter.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThisMonthWaterMeter.ForeColor = System.Drawing.Color.Black;
            this.lbThisMonthWaterMeter.Location = new System.Drawing.Point(-1, 457);
            this.lbThisMonthWaterMeter.Name = "lbThisMonthWaterMeter";
            this.lbThisMonthWaterMeter.Size = new System.Drawing.Size(375, 39);
            this.lbThisMonthWaterMeter.TabIndex = 4;
            this.lbThisMonthWaterMeter.Text = "This Month\'s Water Meter:";
            // 
            // txtThisMonthWaterMeter
            // 
            this.txtThisMonthWaterMeter.Location = new System.Drawing.Point(0, 499);
            this.txtThisMonthWaterMeter.Name = "txtThisMonthWaterMeter";
            this.txtThisMonthWaterMeter.Size = new System.Drawing.Size(371, 53);
            this.txtThisMonthWaterMeter.TabIndex = 6;
            // 
            // lbCustomerName
            // 
            this.lbCustomerName.AutoSize = true;
            this.lbCustomerName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCustomerName.ForeColor = System.Drawing.Color.Black;
            this.lbCustomerName.Location = new System.Drawing.Point(6, 62);
            this.lbCustomerName.Name = "lbCustomerName";
            this.lbCustomerName.Size = new System.Drawing.Size(231, 39);
            this.lbCustomerName.TabIndex = 0;
            this.lbCustomerName.Text = "Customer Name";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(0, 104);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(371, 53);
            this.txtCustomerName.TabIndex = 5;
            // 
            // txtLastMonthWaterMeter
            // 
            this.txtLastMonthWaterMeter.Location = new System.Drawing.Point(0, 401);
            this.txtLastMonthWaterMeter.Name = "txtLastMonthWaterMeter";
            this.txtLastMonthWaterMeter.Size = new System.Drawing.Size(374, 53);
            this.txtLastMonthWaterMeter.TabIndex = 8;
            // 
            // lbLastMonthWaterMeter
            // 
            this.lbLastMonthWaterMeter.AutoSize = true;
            this.lbLastMonthWaterMeter.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLastMonthWaterMeter.ForeColor = System.Drawing.Color.Black;
            this.lbLastMonthWaterMeter.Location = new System.Drawing.Point(3, 359);
            this.lbLastMonthWaterMeter.Name = "lbLastMonthWaterMeter";
            this.lbLastMonthWaterMeter.Size = new System.Drawing.Size(375, 39);
            this.lbLastMonthWaterMeter.TabIndex = 3;
            this.lbLastMonthWaterMeter.Text = "Last Month\'s Water Meter:";
            // 
            // txtNumberOfPeople
            // 
            this.txtNumberOfPeople.Enabled = false;
            this.txtNumberOfPeople.Location = new System.Drawing.Point(-3, 303);
            this.txtNumberOfPeople.Name = "txtNumberOfPeople";
            this.txtNumberOfPeople.Size = new System.Drawing.Size(374, 53);
            this.txtNumberOfPeople.TabIndex = 7;
            // 
            // cboTypeOfCustomer
            // 
            this.cboTypeOfCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTypeOfCustomer.FormattingEnabled = true;
            this.cboTypeOfCustomer.Location = new System.Drawing.Point(-6, 202);
            this.cboTypeOfCustomer.Name = "cboTypeOfCustomer";
            this.cboTypeOfCustomer.Size = new System.Drawing.Size(377, 53);
            this.cboTypeOfCustomer.TabIndex = 9;
            this.cboTypeOfCustomer.SelectedIndexChanged += new System.EventHandler(this.cboTypeOfCustomer_SelectedIndexChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(545, 221);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(532, 40);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lbSearch
            // 
            this.lbSearch.AutoSize = true;
            this.lbSearch.BackColor = System.Drawing.Color.White;
            this.lbSearch.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSearch.Location = new System.Drawing.Point(441, 222);
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Size = new System.Drawing.Size(114, 39);
            this.lbSearch.TabIndex = 2;
            this.lbSearch.Text = "Search:";
            // 
            // lvWaterBill
            // 
            this.lvWaterBill.HideSelection = false;
            this.lvWaterBill.Location = new System.Drawing.Point(433, 262);
            this.lvWaterBill.Name = "lvWaterBill";
            this.lvWaterBill.Size = new System.Drawing.Size(1077, 390);
            this.lvWaterBill.TabIndex = 3;
            this.lvWaterBill.UseCompatibleStateImageBehavior = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel2.Controls.Add(this.iconrestaurar);
            this.panel2.Controls.Add(this.iconmaximizar);
            this.panel2.Controls.Add(this.iconminimizar);
            this.panel2.Controls.Add(this.iconexit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(435, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1253, 58);
            this.panel2.TabIndex = 4;
            // 
            // iconrestaurar
            // 
            this.iconrestaurar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.iconrestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconrestaurar.Image = ((System.Drawing.Image)(resources.GetObject("iconrestaurar.Image")));
            this.iconrestaurar.Location = new System.Drawing.Point(1119, 12);
            this.iconrestaurar.Name = "iconrestaurar";
            this.iconrestaurar.Size = new System.Drawing.Size(40, 40);
            this.iconrestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconrestaurar.TabIndex = 3;
            this.iconrestaurar.TabStop = false;
            this.iconrestaurar.Visible = false;
            this.iconrestaurar.Click += new System.EventHandler(this.iconrestaurar_Click);
            // 
            // iconmaximizar
            // 
            this.iconmaximizar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.iconmaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconmaximizar.Image = global::WaterBill.Properties.Resources.white_large_square_emoji_clipart_md;
            this.iconmaximizar.Location = new System.Drawing.Point(1119, 12);
            this.iconmaximizar.Name = "iconmaximizar";
            this.iconmaximizar.Size = new System.Drawing.Size(40, 40);
            this.iconmaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconmaximizar.TabIndex = 2;
            this.iconmaximizar.TabStop = false;
            this.iconmaximizar.Click += new System.EventHandler(this.iconmaximizar_Click);
            // 
            // iconminimizar
            // 
            this.iconminimizar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.iconminimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconminimizar.Image = ((System.Drawing.Image)(resources.GetObject("iconminimizar.Image")));
            this.iconminimizar.Location = new System.Drawing.Point(1037, 12);
            this.iconminimizar.Name = "iconminimizar";
            this.iconminimizar.Size = new System.Drawing.Size(40, 40);
            this.iconminimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconminimizar.TabIndex = 1;
            this.iconminimizar.TabStop = false;
            this.iconminimizar.Click += new System.EventHandler(this.iconminimizar_Click);
            // 
            // iconexit
            // 
            this.iconexit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.iconexit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconexit.Image = ((System.Drawing.Image)(resources.GetObject("iconexit.Image")));
            this.iconexit.Location = new System.Drawing.Point(1206, 12);
            this.iconexit.Name = "iconexit";
            this.iconexit.Size = new System.Drawing.Size(40, 40);
            this.iconexit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconexit.TabIndex = 0;
            this.iconexit.TabStop = false;
            this.iconexit.Click += new System.EventHandler(this.iconexit_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnPay
            // 
            this.btnPay.Location = new System.Drawing.Point(1516, 614);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(134, 38);
            this.btnPay.TabIndex = 6;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(1516, 559);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(134, 39);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // cboSortOption
            // 
            this.cboSortOption.FormattingEnabled = true;
            this.cboSortOption.Items.AddRange(new object[] {
            "Total Bill Ascending",
            "Total Bill Descending",
            "Unpaid First",
            "Paid First"});
            this.cboSortOption.Location = new System.Drawing.Point(1294, 221);
            this.cboSortOption.Name = "cboSortOption";
            this.cboSortOption.Size = new System.Drawing.Size(121, 41);
            this.cboSortOption.TabIndex = 9;
            this.cboSortOption.SelectedIndexChanged += new System.EventHandler(this.cboSortOption_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Snow;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1227, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 39);
            this.label1.TabIndex = 10;
            this.label1.Text = "Sort:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1688, 710);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboSortOption);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lvWaterBill);
            this.Controls.Add(this.lbSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconrestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconmaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconminimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconexit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCaculator;
        private System.Windows.Forms.ComboBox cboTypeOfCustomer;
        private System.Windows.Forms.TextBox txtLastMonthWaterMeter;
        private System.Windows.Forms.TextBox txtNumberOfPeople;
        private System.Windows.Forms.TextBox txtThisMonthWaterMeter;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lbThisMonthWaterMeter;
        private System.Windows.Forms.Label lbLastMonthWaterMeter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbTypeOfCustomer;
        private System.Windows.Forms.Label lbCustomerName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lbSearch;
        private System.Windows.Forms.ListView lvWaterBill;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox iconmaximizar;
        private System.Windows.Forms.PictureBox iconminimizar;
        private System.Windows.Forms.PictureBox iconexit;
        private System.Windows.Forms.PictureBox iconrestaurar;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox cboSortOption;
        private System.Windows.Forms.Label label1;
    }
}

