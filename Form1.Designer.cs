namespace Hotel_Reservation
{
    partial class frmHotel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHotel));
            this.lblHotelName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.Pax = new System.Windows.Forms.NumericUpDown();
            this.Age = new System.Windows.Forms.NumericUpDown();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblPax = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.radioPresidential = new System.Windows.Forms.RadioButton();
            this.radioExecutive = new System.Windows.Forms.RadioButton();
            this.radioQueen = new System.Windows.Forms.RadioButton();
            this.radioDeluxe = new System.Windows.Forms.RadioButton();
            this.radioSenior = new System.Windows.Forms.RadioButton();
            this.radioPWD = new System.Windows.Forms.RadioButton();
            this.radioEmployee = new System.Windows.Forms.RadioButton();
            this.radioRegular = new System.Windows.Forms.RadioButton();
            this.groupPersonal = new System.Windows.Forms.GroupBox();
            this.groupAccomodation = new System.Windows.Forms.GroupBox();
            this.groupDiscount = new System.Windows.Forms.GroupBox();
            this.groupBilling = new System.Windows.Forms.GroupBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtEnterPayment = new System.Windows.Forms.TextBox();
            this.lblEnterPayment = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblAmountDue = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.lblTotalDiscount = new System.Windows.Forms.Label();
            this.txtPayment = new System.Windows.Forms.TextBox();
            this.lblTotalPayment = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Age)).BeginInit();
            this.groupPersonal.SuspendLayout();
            this.groupAccomodation.SuspendLayout();
            this.groupDiscount.SuspendLayout();
            this.groupBilling.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHotelName
            // 
            this.lblHotelName.AutoSize = true;
            this.lblHotelName.BackColor = System.Drawing.Color.Transparent;
            this.lblHotelName.Font = new System.Drawing.Font("Segoe UI", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHotelName.ForeColor = System.Drawing.Color.White;
            this.lblHotelName.Location = new System.Drawing.Point(280, 11);
            this.lblHotelName.Name = "lblHotelName";
            this.lblHotelName.Size = new System.Drawing.Size(399, 71);
            this.lblHotelName.TabIndex = 0;
            this.lblHotelName.Text = "Glamour Hotel";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.picLogo);
            this.panel1.Controls.Add(this.lblHotelName);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(886, 93);
            this.panel1.TabIndex = 2;
            // 
            // picLogo
            // 
            this.picLogo.Image = global::Hotel_Reservation.Properties.Resources.Black_Gold_Simple_Modern_Villa___Homestay_Logo__1_;
            this.picLogo.Location = new System.Drawing.Point(191, 14);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(83, 65);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 1;
            this.picLogo.TabStop = false;
            // 
            // Pax
            // 
            this.Pax.Location = new System.Drawing.Point(20, 325);
            this.Pax.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.Pax.Name = "Pax";
            this.Pax.Size = new System.Drawing.Size(261, 34);
            this.Pax.TabIndex = 11;
            this.Pax.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // Age
            // 
            this.Age.Location = new System.Drawing.Point(20, 239);
            this.Age.Minimum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(261, 34);
            this.Age.TabIndex = 10;
            this.Age.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(20, 156);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(261, 34);
            this.txtContact.TabIndex = 9;
            this.txtContact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContact_KeyPress);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(20, 77);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(261, 34);
            this.txtName.TabIndex = 8;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lblPax
            // 
            this.lblPax.AutoSize = true;
            this.lblPax.BackColor = System.Drawing.Color.Transparent;
            this.lblPax.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPax.ForeColor = System.Drawing.Color.White;
            this.lblPax.Location = new System.Drawing.Point(16, 301);
            this.lblPax.Name = "lblPax";
            this.lblPax.Size = new System.Drawing.Size(37, 21);
            this.lblPax.TabIndex = 7;
            this.lblPax.Text = "Pax";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.BackColor = System.Drawing.Color.Transparent;
            this.lblAge.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.ForeColor = System.Drawing.Color.White;
            this.lblAge.Location = new System.Drawing.Point(16, 215);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(38, 21);
            this.lblAge.TabIndex = 6;
            this.lblAge.Text = "Age";
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.BackColor = System.Drawing.Color.Transparent;
            this.lblContact.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContact.ForeColor = System.Drawing.Color.White;
            this.lblContact.Location = new System.Drawing.Point(16, 132);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(95, 21);
            this.lblContact.TabIndex = 5;
            this.lblContact.Text = "Contact No.";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(16, 53);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(53, 21);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Name";
            // 
            // radioPresidential
            // 
            this.radioPresidential.AutoSize = true;
            this.radioPresidential.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioPresidential.ForeColor = System.Drawing.Color.White;
            this.radioPresidential.Location = new System.Drawing.Point(25, 174);
            this.radioPresidential.Name = "radioPresidential";
            this.radioPresidential.Size = new System.Drawing.Size(203, 25);
            this.radioPresidential.TabIndex = 8;
            this.radioPresidential.TabStop = true;
            this.radioPresidential.Text = "Presidential Suite ($750)";
            this.radioPresidential.UseVisualStyleBackColor = true;
            this.radioPresidential.CheckedChanged += new System.EventHandler(this.radioPresidential_CheckedChanged);
            // 
            // radioExecutive
            // 
            this.radioExecutive.AutoSize = true;
            this.radioExecutive.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioExecutive.ForeColor = System.Drawing.Color.White;
            this.radioExecutive.Location = new System.Drawing.Point(25, 130);
            this.radioExecutive.Name = "radioExecutive";
            this.radioExecutive.Size = new System.Drawing.Size(184, 25);
            this.radioExecutive.TabIndex = 7;
            this.radioExecutive.TabStop = true;
            this.radioExecutive.Text = "Executive Suite ($650)";
            this.radioExecutive.UseVisualStyleBackColor = true;
            this.radioExecutive.CheckedChanged += new System.EventHandler(this.radioExecutive_CheckedChanged);
            // 
            // radioQueen
            // 
            this.radioQueen.AutoSize = true;
            this.radioQueen.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioQueen.ForeColor = System.Drawing.Color.White;
            this.radioQueen.Location = new System.Drawing.Point(25, 81);
            this.radioQueen.Name = "radioQueen";
            this.radioQueen.Size = new System.Drawing.Size(162, 25);
            this.radioQueen.TabIndex = 6;
            this.radioQueen.TabStop = true;
            this.radioQueen.Text = "Queen Suite ($550)";
            this.radioQueen.UseVisualStyleBackColor = true;
            this.radioQueen.CheckedChanged += new System.EventHandler(this.radioQueen_CheckedChanged);
            // 
            // radioDeluxe
            // 
            this.radioDeluxe.AutoSize = true;
            this.radioDeluxe.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioDeluxe.ForeColor = System.Drawing.Color.White;
            this.radioDeluxe.Location = new System.Drawing.Point(25, 38);
            this.radioDeluxe.Name = "radioDeluxe";
            this.radioDeluxe.Size = new System.Drawing.Size(168, 25);
            this.radioDeluxe.TabIndex = 5;
            this.radioDeluxe.TabStop = true;
            this.radioDeluxe.Text = "Deluxe Suite ($400)";
            this.radioDeluxe.UseVisualStyleBackColor = true;
            this.radioDeluxe.CheckedChanged += new System.EventHandler(this.radioDeluxe_CheckedChanged);
            // 
            // radioSenior
            // 
            this.radioSenior.AutoSize = true;
            this.radioSenior.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioSenior.ForeColor = System.Drawing.Color.White;
            this.radioSenior.Location = new System.Drawing.Point(23, 163);
            this.radioSenior.Name = "radioSenior";
            this.radioSenior.Size = new System.Drawing.Size(173, 25);
            this.radioSenior.TabIndex = 8;
            this.radioSenior.TabStop = true;
            this.radioSenior.Text = "Senior Citizen (20%)";
            this.radioSenior.UseVisualStyleBackColor = true;
            this.radioSenior.CheckedChanged += new System.EventHandler(this.radioSenior_CheckedChanged);
            // 
            // radioPWD
            // 
            this.radioPWD.AutoSize = true;
            this.radioPWD.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioPWD.ForeColor = System.Drawing.Color.White;
            this.radioPWD.Location = new System.Drawing.Point(23, 121);
            this.radioPWD.Name = "radioPWD";
            this.radioPWD.Size = new System.Drawing.Size(108, 25);
            this.radioPWD.TabIndex = 7;
            this.radioPWD.TabStop = true;
            this.radioPWD.Text = "PWD (15%)";
            this.radioPWD.UseVisualStyleBackColor = true;
            this.radioPWD.CheckedChanged += new System.EventHandler(this.radioPWD_CheckedChanged);
            // 
            // radioEmployee
            // 
            this.radioEmployee.AutoSize = true;
            this.radioEmployee.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioEmployee.ForeColor = System.Drawing.Color.White;
            this.radioEmployee.Location = new System.Drawing.Point(23, 81);
            this.radioEmployee.Name = "radioEmployee";
            this.radioEmployee.Size = new System.Drawing.Size(161, 25);
            this.radioEmployee.TabIndex = 6;
            this.radioEmployee.TabStop = true;
            this.radioEmployee.Text = "Employee (5%)       ";
            this.radioEmployee.UseVisualStyleBackColor = true;
            this.radioEmployee.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            // 
            // radioRegular
            // 
            this.radioRegular.AutoSize = true;
            this.radioRegular.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioRegular.ForeColor = System.Drawing.Color.White;
            this.radioRegular.Location = new System.Drawing.Point(23, 38);
            this.radioRegular.Name = "radioRegular";
            this.radioRegular.Size = new System.Drawing.Size(84, 25);
            this.radioRegular.TabIndex = 5;
            this.radioRegular.TabStop = true;
            this.radioRegular.Text = "Regular";
            this.radioRegular.UseVisualStyleBackColor = true;
            this.radioRegular.CheckedChanged += new System.EventHandler(this.radioRegular_CheckedChanged);
            // 
            // groupPersonal
            // 
            this.groupPersonal.BackColor = System.Drawing.Color.DarkSlateGray;
            this.groupPersonal.Controls.Add(this.Pax);
            this.groupPersonal.Controls.Add(this.lblName);
            this.groupPersonal.Controls.Add(this.Age);
            this.groupPersonal.Controls.Add(this.lblContact);
            this.groupPersonal.Controls.Add(this.txtContact);
            this.groupPersonal.Controls.Add(this.lblAge);
            this.groupPersonal.Controls.Add(this.txtName);
            this.groupPersonal.Controls.Add(this.lblPax);
            this.groupPersonal.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPersonal.ForeColor = System.Drawing.Color.White;
            this.groupPersonal.Location = new System.Drawing.Point(12, 106);
            this.groupPersonal.Name = "groupPersonal";
            this.groupPersonal.Size = new System.Drawing.Size(301, 443);
            this.groupPersonal.TabIndex = 14;
            this.groupPersonal.TabStop = false;
            this.groupPersonal.Text = "Personal Information";
            // 
            // groupAccomodation
            // 
            this.groupAccomodation.BackColor = System.Drawing.Color.DarkSlateGray;
            this.groupAccomodation.Controls.Add(this.radioPresidential);
            this.groupAccomodation.Controls.Add(this.radioDeluxe);
            this.groupAccomodation.Controls.Add(this.radioExecutive);
            this.groupAccomodation.Controls.Add(this.radioQueen);
            this.groupAccomodation.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupAccomodation.ForeColor = System.Drawing.Color.White;
            this.groupAccomodation.Location = new System.Drawing.Point(319, 106);
            this.groupAccomodation.Name = "groupAccomodation";
            this.groupAccomodation.Size = new System.Drawing.Size(250, 224);
            this.groupAccomodation.TabIndex = 15;
            this.groupAccomodation.TabStop = false;
            this.groupAccomodation.Text = "Accomodation";
            // 
            // groupDiscount
            // 
            this.groupDiscount.BackColor = System.Drawing.Color.DarkSlateGray;
            this.groupDiscount.Controls.Add(this.radioRegular);
            this.groupDiscount.Controls.Add(this.radioSenior);
            this.groupDiscount.Controls.Add(this.radioEmployee);
            this.groupDiscount.Controls.Add(this.radioPWD);
            this.groupDiscount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupDiscount.ForeColor = System.Drawing.Color.White;
            this.groupDiscount.Location = new System.Drawing.Point(321, 336);
            this.groupDiscount.Name = "groupDiscount";
            this.groupDiscount.Size = new System.Drawing.Size(248, 213);
            this.groupDiscount.TabIndex = 16;
            this.groupDiscount.TabStop = false;
            this.groupDiscount.Text = "Discount";
            // 
            // groupBilling
            // 
            this.groupBilling.BackColor = System.Drawing.Color.DarkSlateGray;
            this.groupBilling.Controls.Add(this.btnCalculate);
            this.groupBilling.Controls.Add(this.txtEnterPayment);
            this.groupBilling.Controls.Add(this.lblEnterPayment);
            this.groupBilling.Controls.Add(this.txtAmount);
            this.groupBilling.Controls.Add(this.lblAmountDue);
            this.groupBilling.Controls.Add(this.txtDiscount);
            this.groupBilling.Controls.Add(this.lblTotalDiscount);
            this.groupBilling.Controls.Add(this.txtPayment);
            this.groupBilling.Controls.Add(this.lblTotalPayment);
            this.groupBilling.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBilling.ForeColor = System.Drawing.Color.White;
            this.groupBilling.Location = new System.Drawing.Point(583, 107);
            this.groupBilling.Name = "groupBilling";
            this.groupBilling.Size = new System.Drawing.Size(285, 441);
            this.groupBilling.TabIndex = 17;
            this.groupBilling.TabStop = false;
            this.groupBilling.Text = "Billing Information";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Enabled = false;
            this.btnCalculate.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.ForeColor = System.Drawing.Color.Black;
            this.btnCalculate.Location = new System.Drawing.Point(138, 389);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(128, 28);
            this.btnCalculate.TabIndex = 19;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtEnterPayment
            // 
            this.txtEnterPayment.Location = new System.Drawing.Point(24, 346);
            this.txtEnterPayment.Name = "txtEnterPayment";
            this.txtEnterPayment.Size = new System.Drawing.Size(242, 29);
            this.txtEnterPayment.TabIndex = 18;
            this.txtEnterPayment.TextChanged += new System.EventHandler(this.txtPaymentt_TextChanged);
            this.txtEnterPayment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEnterPayment_KeyPress);
            // 
            // lblEnterPayment
            // 
            this.lblEnterPayment.AutoSize = true;
            this.lblEnterPayment.BackColor = System.Drawing.Color.Transparent;
            this.lblEnterPayment.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterPayment.ForeColor = System.Drawing.Color.White;
            this.lblEnterPayment.Location = new System.Drawing.Point(20, 314);
            this.lblEnterPayment.Name = "lblEnterPayment";
            this.lblEnterPayment.Size = new System.Drawing.Size(115, 21);
            this.lblEnterPayment.TabIndex = 17;
            this.lblEnterPayment.Text = "Enter Payment";
            // 
            // txtAmount
            // 
            this.txtAmount.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.txtAmount.Location = new System.Drawing.Point(24, 243);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(242, 29);
            this.txtAmount.TabIndex = 16;
            // 
            // lblAmountDue
            // 
            this.lblAmountDue.AutoSize = true;
            this.lblAmountDue.BackColor = System.Drawing.Color.Transparent;
            this.lblAmountDue.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountDue.ForeColor = System.Drawing.Color.White;
            this.lblAmountDue.Location = new System.Drawing.Point(20, 214);
            this.lblAmountDue.Name = "lblAmountDue";
            this.lblAmountDue.Size = new System.Drawing.Size(101, 21);
            this.lblAmountDue.TabIndex = 15;
            this.lblAmountDue.Text = "Amount Due";
            // 
            // txtDiscount
            // 
            this.txtDiscount.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.txtDiscount.Location = new System.Drawing.Point(24, 161);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(242, 29);
            this.txtDiscount.TabIndex = 14;
            // 
            // lblTotalDiscount
            // 
            this.lblTotalDiscount.AutoSize = true;
            this.lblTotalDiscount.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalDiscount.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDiscount.ForeColor = System.Drawing.Color.White;
            this.lblTotalDiscount.Location = new System.Drawing.Point(20, 133);
            this.lblTotalDiscount.Name = "lblTotalDiscount";
            this.lblTotalDiscount.Size = new System.Drawing.Size(116, 21);
            this.lblTotalDiscount.TabIndex = 13;
            this.lblTotalDiscount.Text = "Total Discount";
            // 
            // txtPayment
            // 
            this.txtPayment.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.txtPayment.Location = new System.Drawing.Point(24, 80);
            this.txtPayment.Name = "txtPayment";
            this.txtPayment.Size = new System.Drawing.Size(242, 29);
            this.txtPayment.TabIndex = 12;
            // 
            // lblTotalPayment
            // 
            this.lblTotalPayment.AutoSize = true;
            this.lblTotalPayment.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalPayment.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPayment.ForeColor = System.Drawing.Color.White;
            this.lblTotalPayment.Location = new System.Drawing.Point(20, 52);
            this.lblTotalPayment.Name = "lblTotalPayment";
            this.lblTotalPayment.Size = new System.Drawing.Size(116, 21);
            this.lblTotalPayment.TabIndex = 12;
            this.lblTotalPayment.Text = "Total Payment";
            // 
            // frmHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Hotel_Reservation.Properties.Resources.Beige_and_Orange_Restaurant_and_Hotel_Instagram_Post;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.groupBilling);
            this.Controls.Add(this.groupDiscount);
            this.Controls.Add(this.groupAccomodation);
            this.Controls.Add(this.groupPersonal);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmHotel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotel Reservation";
            this.Load += new System.EventHandler(this.frmHotel_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Age)).EndInit();
            this.groupPersonal.ResumeLayout(false);
            this.groupPersonal.PerformLayout();
            this.groupAccomodation.ResumeLayout(false);
            this.groupAccomodation.PerformLayout();
            this.groupDiscount.ResumeLayout(false);
            this.groupDiscount.PerformLayout();
            this.groupBilling.ResumeLayout(false);
            this.groupBilling.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblHotelName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.NumericUpDown Pax;
        private System.Windows.Forms.NumericUpDown Age;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblPax;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.RadioButton radioDeluxe;
        private System.Windows.Forms.RadioButton radioPresidential;
        private System.Windows.Forms.RadioButton radioExecutive;
        private System.Windows.Forms.RadioButton radioQueen;
        private System.Windows.Forms.RadioButton radioSenior;
        private System.Windows.Forms.RadioButton radioPWD;
        private System.Windows.Forms.RadioButton radioEmployee;
        private System.Windows.Forms.RadioButton radioRegular;
        private System.Windows.Forms.GroupBox groupPersonal;
        private System.Windows.Forms.GroupBox groupAccomodation;
        private System.Windows.Forms.GroupBox groupDiscount;
        private System.Windows.Forms.GroupBox groupBilling;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtEnterPayment;
        private System.Windows.Forms.Label lblEnterPayment;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblAmountDue;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label lblTotalDiscount;
        private System.Windows.Forms.TextBox txtPayment;
        private System.Windows.Forms.Label lblTotalPayment;
    }
}

