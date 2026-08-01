namespace CaseStudy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.paneltop = new System.Windows.Forms.Panel();
            this.panelleft = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnnext = new System.Windows.Forms.Button();
            this.btnprevious = new System.Windows.Forms.Button();
            this.btnfirst = new System.Windows.Forms.Button();
            this.btnlast = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbfemale = new System.Windows.Forms.RadioButton();
            this.rdbmale = new System.Windows.Forms.RadioButton();
            this.cmbdoctor = new System.Windows.Forms.ComboBox();
            this.cmbdisease = new System.Windows.Forms.ComboBox();
            this.cmbblood = new System.Windows.Forms.ComboBox();
            this.dtpadmission = new System.Windows.Forms.DateTimePicker();
            this.dtpbirth = new System.Windows.Forms.DateTimePicker();
            this.tbage = new System.Windows.Forms.TextBox();
            this.tbname = new System.Windows.Forms.TextBox();
            this.tbadd = new System.Windows.Forms.TextBox();
            this.tbrelationship = new System.Windows.Forms.TextBox();
            this.tbemadd = new System.Windows.Forms.TextBox();
            this.tbemcontact = new System.Windows.Forms.TextBox();
            this.tbcontact = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label17 = new System.Windows.Forms.Label();
            this.tbid = new System.Windows.Forms.TextBox();
            this.btnview = new System.Windows.Forms.Button();
            this.paneltop.SuspendLayout();
            this.panelleft.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(398, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patient Registration Form";
            // 
            // paneltop
            // 
            this.paneltop.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.paneltop.Controls.Add(this.label1);
            this.paneltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltop.Location = new System.Drawing.Point(0, 0);
            this.paneltop.Name = "paneltop";
            this.paneltop.Size = new System.Drawing.Size(960, 52);
            this.paneltop.TabIndex = 1;
            // 
            // panelleft
            // 
            this.panelleft.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelleft.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelleft.Controls.Add(this.tbid);
            this.panelleft.Controls.Add(this.label17);
            this.panelleft.Controls.Add(this.flowLayoutPanel1);
            this.panelleft.Controls.Add(this.pictureBox1);
            this.panelleft.Controls.Add(this.groupBox1);
            this.panelleft.Controls.Add(this.cmbdoctor);
            this.panelleft.Controls.Add(this.cmbdisease);
            this.panelleft.Controls.Add(this.cmbblood);
            this.panelleft.Controls.Add(this.dtpadmission);
            this.panelleft.Controls.Add(this.dtpbirth);
            this.panelleft.Controls.Add(this.tbage);
            this.panelleft.Controls.Add(this.tbname);
            this.panelleft.Controls.Add(this.tbadd);
            this.panelleft.Controls.Add(this.tbrelationship);
            this.panelleft.Controls.Add(this.tbemadd);
            this.panelleft.Controls.Add(this.tbemcontact);
            this.panelleft.Controls.Add(this.tbcontact);
            this.panelleft.Controls.Add(this.label16);
            this.panelleft.Controls.Add(this.label15);
            this.panelleft.Controls.Add(this.label14);
            this.panelleft.Controls.Add(this.label13);
            this.panelleft.Controls.Add(this.label12);
            this.panelleft.Controls.Add(this.label11);
            this.panelleft.Controls.Add(this.label10);
            this.panelleft.Controls.Add(this.label9);
            this.panelleft.Controls.Add(this.label8);
            this.panelleft.Controls.Add(this.label7);
            this.panelleft.Controls.Add(this.label6);
            this.panelleft.Controls.Add(this.label5);
            this.panelleft.Controls.Add(this.label4);
            this.panelleft.Controls.Add(this.label3);
            this.panelleft.Controls.Add(this.label2);
            this.panelleft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelleft.Location = new System.Drawing.Point(0, 52);
            this.panelleft.Name = "panelleft";
            this.panelleft.Size = new System.Drawing.Size(500, 583);
            this.panelleft.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.btnsave);
            this.flowLayoutPanel1.Controls.Add(this.btnupdate);
            this.flowLayoutPanel1.Controls.Add(this.btndelete);
            this.flowLayoutPanel1.Controls.Add(this.btnclear);
            this.flowLayoutPanel1.Controls.Add(this.btnview);
            this.flowLayoutPanel1.Controls.Add(this.btnexit);
            this.flowLayoutPanel1.Controls.Add(this.btnnext);
            this.flowLayoutPanel1.Controls.Add(this.btnprevious);
            this.flowLayoutPanel1.Controls.Add(this.btnfirst);
            this.flowLayoutPanel1.Controls.Add(this.btnlast);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(4, 503);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(488, 66);
            this.flowLayoutPanel1.TabIndex = 31;
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsave.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnsave.Location = new System.Drawing.Point(3, 3);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 23);
            this.btnsave.TabIndex = 0;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnupdate.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnupdate.Location = new System.Drawing.Point(84, 3);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 23);
            this.btnupdate.TabIndex = 1;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndelete.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F, System.Drawing.FontStyle.Bold);
            this.btndelete.Location = new System.Drawing.Point(165, 3);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 23);
            this.btndelete.TabIndex = 2;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnclear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclear.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnclear.Location = new System.Drawing.Point(246, 3);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(75, 23);
            this.btnclear.TabIndex = 3;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexit.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnexit.Location = new System.Drawing.Point(408, 3);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(75, 23);
            this.btnexit.TabIndex = 6;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnnext
            // 
            this.btnnext.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnnext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnext.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnnext.Location = new System.Drawing.Point(3, 32);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(123, 23);
            this.btnnext.TabIndex = 4;
            this.btnnext.Text = "Move Next";
            this.btnnext.UseVisualStyleBackColor = false;
            this.btnnext.Click += new System.EventHandler(this.btnnext_Click);
            // 
            // btnprevious
            // 
            this.btnprevious.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnprevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnprevious.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnprevious.Location = new System.Drawing.Point(132, 32);
            this.btnprevious.Name = "btnprevious";
            this.btnprevious.Size = new System.Drawing.Size(121, 23);
            this.btnprevious.TabIndex = 5;
            this.btnprevious.Text = "Move Previous";
            this.btnprevious.UseVisualStyleBackColor = false;
            this.btnprevious.Click += new System.EventHandler(this.btnprevious_Click);
            // 
            // btnfirst
            // 
            this.btnfirst.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnfirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfirst.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnfirst.Location = new System.Drawing.Point(259, 32);
            this.btnfirst.Name = "btnfirst";
            this.btnfirst.Size = new System.Drawing.Size(113, 23);
            this.btnfirst.TabIndex = 7;
            this.btnfirst.Text = "Move First";
            this.btnfirst.UseVisualStyleBackColor = false;
            this.btnfirst.Click += new System.EventHandler(this.btnfirst_Click);
            // 
            // btnlast
            // 
            this.btnlast.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnlast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlast.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnlast.Location = new System.Drawing.Point(378, 32);
            this.btnlast.Name = "btnlast";
            this.btnlast.Size = new System.Drawing.Size(105, 23);
            this.btnlast.TabIndex = 8;
            this.btnlast.Text = "Move Last";
            this.btnlast.UseVisualStyleBackColor = false;
            this.btnlast.Click += new System.EventHandler(this.btnlast_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = global::CaseStudy.Properties.Resources.images1;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(382, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(97, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbfemale);
            this.groupBox1.Controls.Add(this.rdbmale);
            this.groupBox1.Location = new System.Drawing.Point(128, 154);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 27);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            // 
            // rdbfemale
            // 
            this.rdbfemale.AutoSize = true;
            this.rdbfemale.Location = new System.Drawing.Point(97, 8);
            this.rdbfemale.Name = "rdbfemale";
            this.rdbfemale.Size = new System.Drawing.Size(59, 17);
            this.rdbfemale.TabIndex = 1;
            this.rdbfemale.TabStop = true;
            this.rdbfemale.Text = "Female";
            this.rdbfemale.UseVisualStyleBackColor = true;
            // 
            // rdbmale
            // 
            this.rdbmale.AutoSize = true;
            this.rdbmale.Location = new System.Drawing.Point(6, 8);
            this.rdbmale.Name = "rdbmale";
            this.rdbmale.Size = new System.Drawing.Size(48, 17);
            this.rdbmale.TabIndex = 0;
            this.rdbmale.TabStop = true;
            this.rdbmale.Text = "Male";
            this.rdbmale.UseVisualStyleBackColor = true;
            // 
            // cmbdoctor
            // 
            this.cmbdoctor.FormattingEnabled = true;
            this.cmbdoctor.Items.AddRange(new object[] {
            "Dr. Mehta",
            "Dr. Patel",
            "Dr. Shah",
            "Dr. Kumar",
            "Dr. Singh",
            "Dr. Verma",
            "Dr. Gupta",
            "Dr. Reddy"});
            this.cmbdoctor.Location = new System.Drawing.Point(128, 430);
            this.cmbdoctor.Name = "cmbdoctor";
            this.cmbdoctor.Size = new System.Drawing.Size(121, 21);
            this.cmbdoctor.TabIndex = 29;
            // 
            // cmbdisease
            // 
            this.cmbdisease.FormattingEnabled = true;
            this.cmbdisease.Items.AddRange(new object[] {
            "Fever",
            "Cold",
            "Flu",
            "Cough",
            "Headache",
            "Stomach Pain",
            "Vomiting",
            "Diarrhea",
            "Migraine",
            "Allergy",
            "Skin Infection",
            "Eye Infection",
            "Back Pain",
            "Anemia"});
            this.cmbdisease.Location = new System.Drawing.Point(128, 398);
            this.cmbdisease.Name = "cmbdisease";
            this.cmbdisease.Size = new System.Drawing.Size(121, 21);
            this.cmbdisease.TabIndex = 28;
            // 
            // cmbblood
            // 
            this.cmbblood.FormattingEnabled = true;
            this.cmbblood.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "O+",
            "O-",
            "AB+",
            "AB-"});
            this.cmbblood.Location = new System.Drawing.Point(128, 367);
            this.cmbblood.Name = "cmbblood";
            this.cmbblood.Size = new System.Drawing.Size(121, 21);
            this.cmbblood.TabIndex = 27;
            // 
            // dtpadmission
            // 
            this.dtpadmission.Location = new System.Drawing.Point(128, 462);
            this.dtpadmission.Name = "dtpadmission";
            this.dtpadmission.Size = new System.Drawing.Size(200, 20);
            this.dtpadmission.TabIndex = 26;
            // 
            // dtpbirth
            // 
            this.dtpbirth.Location = new System.Drawing.Point(128, 102);
            this.dtpbirth.Name = "dtpbirth";
            this.dtpbirth.Size = new System.Drawing.Size(200, 20);
            this.dtpbirth.TabIndex = 25;
            this.dtpbirth.ValueChanged += new System.EventHandler(this.dtpbirth_ValueChanged);
            // 
            // tbage
            // 
            this.tbage.Enabled = false;
            this.tbage.Location = new System.Drawing.Point(128, 128);
            this.tbage.Name = "tbage";
            this.tbage.Size = new System.Drawing.Size(60, 20);
            this.tbage.TabIndex = 24;
            // 
            // tbname
            // 
            this.tbname.Location = new System.Drawing.Point(128, 74);
            this.tbname.Name = "tbname";
            this.tbname.Size = new System.Drawing.Size(144, 20);
            this.tbname.TabIndex = 23;
            // 
            // tbadd
            // 
            this.tbadd.Location = new System.Drawing.Point(128, 216);
            this.tbadd.Multiline = true;
            this.tbadd.Name = "tbadd";
            this.tbadd.Size = new System.Drawing.Size(325, 20);
            this.tbadd.TabIndex = 22;
            // 
            // tbrelationship
            // 
            this.tbrelationship.Location = new System.Drawing.Point(128, 302);
            this.tbrelationship.Name = "tbrelationship";
            this.tbrelationship.Size = new System.Drawing.Size(100, 20);
            this.tbrelationship.TabIndex = 21;
            // 
            // tbemadd
            // 
            this.tbemadd.Location = new System.Drawing.Point(128, 270);
            this.tbemadd.Multiline = true;
            this.tbemadd.Name = "tbemadd";
            this.tbemadd.Size = new System.Drawing.Size(325, 20);
            this.tbemadd.TabIndex = 20;
            // 
            // tbemcontact
            // 
            this.tbemcontact.Location = new System.Drawing.Point(128, 242);
            this.tbemcontact.Name = "tbemcontact";
            this.tbemcontact.Size = new System.Drawing.Size(144, 20);
            this.tbemcontact.TabIndex = 19;
            // 
            // tbcontact
            // 
            this.tbcontact.Location = new System.Drawing.Point(128, 190);
            this.tbcontact.Name = "tbcontact";
            this.tbcontact.Size = new System.Drawing.Size(144, 20);
            this.tbcontact.TabIndex = 4;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(72, 162);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(48, 13);
            this.label16.TabIndex = 18;
            this.label16.Text = "Gender :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(23, 462);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(98, 13);
            this.label15.TabIndex = 17;
            this.label15.Text = "Date of Admission :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label14.Location = new System.Drawing.Point(77, 433);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(45, 13);
            this.label14.TabIndex = 16;
            this.label14.Text = "Doctor :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(71, 401);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 13);
            this.label13.TabIndex = 15;
            this.label13.Text = "Disease :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(55, 370);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "Blood Type :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(0, 337);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 17);
            this.label11.TabIndex = 13;
            this.label11.Text = "Medical Data";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(-6, 302);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(128, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Relationship with patient :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 273);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Emergency Address :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 249);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Emergency Contact :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(70, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Address :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Contact Number :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Birth Date :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Age :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Name : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Personal Info";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(500, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(460, 583);
            this.dataGridView1.TabIndex = 3;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(64, 47);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(58, 13);
            this.label17.TabIndex = 32;
            this.label17.Text = "Patient Id :";
            // 
            // tbid
            // 
            this.tbid.Enabled = false;
            this.tbid.Location = new System.Drawing.Point(128, 44);
            this.tbid.Name = "tbid";
            this.tbid.Size = new System.Drawing.Size(144, 20);
            this.tbid.TabIndex = 33;
            // 
            // btnview
            // 
            this.btnview.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnview.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnview.Location = new System.Drawing.Point(327, 3);
            this.btnview.Name = "btnview";
            this.btnview.Size = new System.Drawing.Size(75, 23);
            this.btnview.TabIndex = 9;
            this.btnview.Text = "View";
            this.btnview.UseVisualStyleBackColor = false;
            this.btnview.Click += new System.EventHandler(this.btnview_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(960, 635);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panelleft);
            this.Controls.Add(this.paneltop);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.paneltop.ResumeLayout(false);
            this.paneltop.PerformLayout();
            this.panelleft.ResumeLayout(false);
            this.panelleft.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel paneltop;
        private System.Windows.Forms.Panel panelleft;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbdoctor;
        private System.Windows.Forms.ComboBox cmbdisease;
        private System.Windows.Forms.ComboBox cmbblood;
        private System.Windows.Forms.DateTimePicker dtpadmission;
        private System.Windows.Forms.DateTimePicker dtpbirth;
        private System.Windows.Forms.TextBox tbage;
        private System.Windows.Forms.TextBox tbname;
        private System.Windows.Forms.TextBox tbadd;
        private System.Windows.Forms.TextBox tbrelationship;
        private System.Windows.Forms.TextBox tbemadd;
        private System.Windows.Forms.TextBox tbemcontact;
        private System.Windows.Forms.TextBox tbcontact;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbfemale;
        private System.Windows.Forms.RadioButton rdbmale;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnnext;
        private System.Windows.Forms.Button btnprevious;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnfirst;
        private System.Windows.Forms.Button btnlast;
        private System.Windows.Forms.TextBox tbid;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnview;
    }
}

