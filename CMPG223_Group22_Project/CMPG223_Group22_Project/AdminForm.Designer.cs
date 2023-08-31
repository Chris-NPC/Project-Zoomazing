
namespace CMPG223_Group22_Project
{
    partial class AdminForm
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
            this.tcAdmin = new System.Windows.Forms.TabControl();
            this.tpAnimals = new System.Windows.Forms.TabPage();
            this.pnlAGender = new System.Windows.Forms.Panel();
            this.rdbFemale = new System.Windows.Forms.RadioButton();
            this.rdbMale = new System.Windows.Forms.RadioButton();
            this.pnlAHeading = new System.Windows.Forms.Panel();
            this.lblAHeading = new System.Windows.Forms.Label();
            this.lblActionChoose = new System.Windows.Forms.Label();
            this.cbxChooseAction = new System.Windows.Forms.ComboBox();
            this.lstbxAnimalLog = new System.Windows.Forms.ListBox();
            this.pnlYesNo = new System.Windows.Forms.Panel();
            this.rdbFalse = new System.Windows.Forms.RadioButton();
            this.rdbTrue = new System.Windows.Forms.RadioButton();
            this.nudADay = new System.Windows.Forms.NumericUpDown();
            this.cbxID = new System.Windows.Forms.ComboBox();
            this.dgvShowAnimals = new System.Windows.Forms.DataGridView();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtAName = new System.Windows.Forms.TextBox();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblVaccStatus = new System.Windows.Forms.Label();
            this.lblADOB = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.btnAnimalAction = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.lblAName = new System.Windows.Forms.Label();
            this.tpVisitors = new System.Windows.Forms.TabPage();
            this.pnlVHeading = new System.Windows.Forms.Panel();
            this.lblVHeading = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.nudVAge = new System.Windows.Forms.NumericUpDown();
            this.lblVID = new System.Windows.Forms.Label();
            this.lblVFName = new System.Windows.Forms.Label();
            this.lstbxVisitorLog = new System.Windows.Forms.ListBox();
            this.cbxVID = new System.Windows.Forms.ComboBox();
            this.dgvShowVisitors = new System.Windows.Forms.DataGridView();
            this.txtContactNumber = new System.Windows.Forms.TextBox();
            this.txtVName = new System.Windows.Forms.TextBox();
            this.txtVLName = new System.Windows.Forms.TextBox();
            this.lblContactNumber = new System.Windows.Forms.Label();
            this.lblVAge = new System.Windows.Forms.Label();
            this.btnVisitorAction = new System.Windows.Forms.Button();
            this.lblVLName = new System.Windows.Forms.Label();
            this.tpReports = new System.Windows.Forms.TabPage();
            this.lstbxReport = new System.Windows.Forms.ListBox();
            this.btnTotalCost = new System.Windows.Forms.Button();
            this.btnNumTickets = new System.Windows.Forms.Button();
            this.nudAMonth = new System.Windows.Forms.NumericUpDown();
            this.nudAYear = new System.Windows.Forms.NumericUpDown();
            this.lblAGap1 = new System.Windows.Forms.Label();
            this.lblAGap2 = new System.Windows.Forms.Label();
            this.tcAdmin.SuspendLayout();
            this.tpAnimals.SuspendLayout();
            this.pnlAGender.SuspendLayout();
            this.pnlAHeading.SuspendLayout();
            this.pnlYesNo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudADay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowAnimals)).BeginInit();
            this.tpVisitors.SuspendLayout();
            this.pnlVHeading.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudVAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowVisitors)).BeginInit();
            this.tpReports.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAYear)).BeginInit();
            this.SuspendLayout();
            // 
            // tcAdmin
            // 
            this.tcAdmin.Controls.Add(this.tpAnimals);
            this.tcAdmin.Controls.Add(this.tpVisitors);
            this.tcAdmin.Controls.Add(this.tpReports);
            this.tcAdmin.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcAdmin.Location = new System.Drawing.Point(0, 0);
            this.tcAdmin.Name = "tcAdmin";
            this.tcAdmin.SelectedIndex = 0;
            this.tcAdmin.Size = new System.Drawing.Size(1495, 826);
            this.tcAdmin.TabIndex = 0;
            // 
            // tpAnimals
            // 
            this.tpAnimals.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.tpAnimals.Controls.Add(this.lblAGap2);
            this.tpAnimals.Controls.Add(this.lblAGap1);
            this.tpAnimals.Controls.Add(this.nudAYear);
            this.tpAnimals.Controls.Add(this.nudAMonth);
            this.tpAnimals.Controls.Add(this.pnlAGender);
            this.tpAnimals.Controls.Add(this.pnlAHeading);
            this.tpAnimals.Controls.Add(this.lblActionChoose);
            this.tpAnimals.Controls.Add(this.cbxChooseAction);
            this.tpAnimals.Controls.Add(this.lstbxAnimalLog);
            this.tpAnimals.Controls.Add(this.pnlYesNo);
            this.tpAnimals.Controls.Add(this.nudADay);
            this.tpAnimals.Controls.Add(this.cbxID);
            this.tpAnimals.Controls.Add(this.dgvShowAnimals);
            this.tpAnimals.Controls.Add(this.txtWeight);
            this.tpAnimals.Controls.Add(this.txtAName);
            this.tpAnimals.Controls.Add(this.lblWeight);
            this.tpAnimals.Controls.Add(this.lblVaccStatus);
            this.tpAnimals.Controls.Add(this.lblADOB);
            this.tpAnimals.Controls.Add(this.lblGender);
            this.tpAnimals.Controls.Add(this.btnAnimalAction);
            this.tpAnimals.Controls.Add(this.lblID);
            this.tpAnimals.Controls.Add(this.lblAName);
            this.tpAnimals.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpAnimals.Location = new System.Drawing.Point(4, 29);
            this.tpAnimals.Name = "tpAnimals";
            this.tpAnimals.Padding = new System.Windows.Forms.Padding(3);
            this.tpAnimals.Size = new System.Drawing.Size(1487, 793);
            this.tpAnimals.TabIndex = 0;
            this.tpAnimals.Text = "Animals";
            this.tpAnimals.Click += new System.EventHandler(this.tpAnimals_Click);
            // 
            // pnlAGender
            // 
            this.pnlAGender.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlAGender.Controls.Add(this.rdbFemale);
            this.pnlAGender.Controls.Add(this.rdbMale);
            this.pnlAGender.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlAGender.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlAGender.Location = new System.Drawing.Point(244, 640);
            this.pnlAGender.Name = "pnlAGender";
            this.pnlAGender.Size = new System.Drawing.Size(152, 66);
            this.pnlAGender.TabIndex = 22;
            // 
            // rdbFemale
            // 
            this.rdbFemale.AutoSize = true;
            this.rdbFemale.Location = new System.Drawing.Point(3, 30);
            this.rdbFemale.Name = "rdbFemale";
            this.rdbFemale.Size = new System.Drawing.Size(92, 24);
            this.rdbFemale.TabIndex = 1;
            this.rdbFemale.TabStop = true;
            this.rdbFemale.Text = "Female";
            this.rdbFemale.UseVisualStyleBackColor = true;
            // 
            // rdbMale
            // 
            this.rdbMale.AutoSize = true;
            this.rdbMale.Location = new System.Drawing.Point(3, 3);
            this.rdbMale.Name = "rdbMale";
            this.rdbMale.Size = new System.Drawing.Size(69, 24);
            this.rdbMale.TabIndex = 0;
            this.rdbMale.TabStop = true;
            this.rdbMale.Text = "Male";
            this.rdbMale.UseVisualStyleBackColor = true;
            // 
            // pnlAHeading
            // 
            this.pnlAHeading.Controls.Add(this.lblAHeading);
            this.pnlAHeading.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlAHeading.Location = new System.Drawing.Point(42, 16);
            this.pnlAHeading.Name = "pnlAHeading";
            this.pnlAHeading.Size = new System.Drawing.Size(847, 75);
            this.pnlAHeading.TabIndex = 21;
            // 
            // lblAHeading
            // 
            this.lblAHeading.AutoSize = true;
            this.lblAHeading.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAHeading.Location = new System.Drawing.Point(301, 20);
            this.lblAHeading.Name = "lblAHeading";
            this.lblAHeading.Size = new System.Drawing.Size(262, 34);
            this.lblAHeading.TabIndex = 0;
            this.lblAHeading.Text = "Maintain Animals";
            // 
            // lblActionChoose
            // 
            this.lblActionChoose.AutoSize = true;
            this.lblActionChoose.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActionChoose.Location = new System.Drawing.Point(39, 107);
            this.lblActionChoose.Name = "lblActionChoose";
            this.lblActionChoose.Size = new System.Drawing.Size(139, 20);
            this.lblActionChoose.TabIndex = 20;
            this.lblActionChoose.Text = "Choose Action:";
            // 
            // cbxChooseAction
            // 
            this.cbxChooseAction.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxChooseAction.FormattingEnabled = true;
            this.cbxChooseAction.Items.AddRange(new object[] {
            "Add Animal",
            "Change Animal Details",
            "Remove Animal"});
            this.cbxChooseAction.Location = new System.Drawing.Point(711, 104);
            this.cbxChooseAction.Name = "cbxChooseAction";
            this.cbxChooseAction.Size = new System.Drawing.Size(178, 28);
            this.cbxChooseAction.TabIndex = 19;
            this.cbxChooseAction.Text = "ACTION";
            this.cbxChooseAction.SelectedIndexChanged += new System.EventHandler(this.cbxChooseAction_SelectedIndexChanged);
            // 
            // lstbxAnimalLog
            // 
            this.lstbxAnimalLog.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstbxAnimalLog.FormattingEnabled = true;
            this.lstbxAnimalLog.ItemHeight = 20;
            this.lstbxAnimalLog.Location = new System.Drawing.Point(970, 16);
            this.lstbxAnimalLog.Name = "lstbxAnimalLog";
            this.lstbxAnimalLog.Size = new System.Drawing.Size(435, 724);
            this.lstbxAnimalLog.TabIndex = 18;
            // 
            // pnlYesNo
            // 
            this.pnlYesNo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlYesNo.Controls.Add(this.rdbFalse);
            this.pnlYesNo.Controls.Add(this.rdbTrue);
            this.pnlYesNo.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlYesNo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlYesNo.Location = new System.Drawing.Point(737, 545);
            this.pnlYesNo.Name = "pnlYesNo";
            this.pnlYesNo.Size = new System.Drawing.Size(152, 66);
            this.pnlYesNo.TabIndex = 7;
            // 
            // rdbFalse
            // 
            this.rdbFalse.AutoSize = true;
            this.rdbFalse.Location = new System.Drawing.Point(3, 30);
            this.rdbFalse.Name = "rdbFalse";
            this.rdbFalse.Size = new System.Drawing.Size(73, 24);
            this.rdbFalse.TabIndex = 1;
            this.rdbFalse.TabStop = true;
            this.rdbFalse.Text = "False";
            this.rdbFalse.UseVisualStyleBackColor = true;
            // 
            // rdbTrue
            // 
            this.rdbTrue.AutoSize = true;
            this.rdbTrue.Location = new System.Drawing.Point(3, 3);
            this.rdbTrue.Name = "rdbTrue";
            this.rdbTrue.Size = new System.Drawing.Size(66, 24);
            this.rdbTrue.TabIndex = 0;
            this.rdbTrue.TabStop = true;
            this.rdbTrue.Text = "True";
            this.rdbTrue.UseVisualStyleBackColor = true;
            // 
            // nudADay
            // 
            this.nudADay.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudADay.Location = new System.Drawing.Point(243, 579);
            this.nudADay.Name = "nudADay";
            this.nudADay.Size = new System.Drawing.Size(42, 28);
            this.nudADay.TabIndex = 4;
            // 
            // cbxID
            // 
            this.cbxID.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxID.FormattingEnabled = true;
            this.cbxID.Location = new System.Drawing.Point(243, 472);
            this.cbxID.Name = "cbxID";
            this.cbxID.Size = new System.Drawing.Size(153, 28);
            this.cbxID.TabIndex = 2;
            // 
            // dgvShowAnimals
            // 
            this.dgvShowAnimals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowAnimals.Location = new System.Drawing.Point(42, 154);
            this.dgvShowAnimals.Name = "dgvShowAnimals";
            this.dgvShowAnimals.RowHeadersWidth = 51;
            this.dgvShowAnimals.RowTemplate.Height = 24;
            this.dgvShowAnimals.Size = new System.Drawing.Size(847, 308);
            this.dgvShowAnimals.TabIndex = 1;
            // 
            // txtWeight
            // 
            this.txtWeight.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWeight.Location = new System.Drawing.Point(736, 475);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(153, 28);
            this.txtWeight.TabIndex = 6;
            // 
            // txtAName
            // 
            this.txtAName.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAName.Location = new System.Drawing.Point(243, 523);
            this.txtAName.Name = "txtAName";
            this.txtAName.Size = new System.Drawing.Size(153, 28);
            this.txtAName.TabIndex = 3;
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeight.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblWeight.Location = new System.Drawing.Point(495, 475);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(166, 25);
            this.lblWeight.TabIndex = 13;
            this.lblWeight.Text = "Weight (in kg):";
            // 
            // lblVaccStatus
            // 
            this.lblVaccStatus.AutoSize = true;
            this.lblVaccStatus.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVaccStatus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblVaccStatus.Location = new System.Drawing.Point(495, 545);
            this.lblVaccStatus.Name = "lblVaccStatus";
            this.lblVaccStatus.Size = new System.Drawing.Size(208, 25);
            this.lblVaccStatus.TabIndex = 14;
            this.lblVaccStatus.Text = "Vaccination Status:";
            // 
            // lblADOB
            // 
            this.lblADOB.AutoSize = true;
            this.lblADOB.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblADOB.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblADOB.Location = new System.Drawing.Point(39, 577);
            this.lblADOB.Name = "lblADOB";
            this.lblADOB.Size = new System.Drawing.Size(149, 25);
            this.lblADOB.TabIndex = 11;
            this.lblADOB.Text = "Date of birth:";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblGender.Location = new System.Drawing.Point(38, 640);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(95, 25);
            this.lblGender.TabIndex = 12;
            this.lblGender.Text = "Gender:";
            // 
            // btnAnimalAction
            // 
            this.btnAnimalAction.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnimalAction.Location = new System.Drawing.Point(695, 667);
            this.btnAnimalAction.Name = "btnAnimalAction";
            this.btnAnimalAction.Size = new System.Drawing.Size(194, 73);
            this.btnAnimalAction.TabIndex = 8;
            this.btnAnimalAction.Text = "Action";
            this.btnAnimalAction.UseVisualStyleBackColor = true;
            this.btnAnimalAction.Click += new System.EventHandler(this.btnAnimalAction_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblID.Location = new System.Drawing.Point(39, 471);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(44, 25);
            this.lblID.TabIndex = 9;
            this.lblID.Text = "ID:";
            // 
            // lblAName
            // 
            this.lblAName.AutoSize = true;
            this.lblAName.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblAName.Location = new System.Drawing.Point(37, 522);
            this.lblAName.Name = "lblAName";
            this.lblAName.Size = new System.Drawing.Size(79, 25);
            this.lblAName.TabIndex = 10;
            this.lblAName.Text = "Name:";
            // 
            // tpVisitors
            // 
            this.tpVisitors.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.tpVisitors.Controls.Add(this.pnlVHeading);
            this.tpVisitors.Controls.Add(this.label2);
            this.tpVisitors.Controls.Add(this.comboBox1);
            this.tpVisitors.Controls.Add(this.nudVAge);
            this.tpVisitors.Controls.Add(this.lblVID);
            this.tpVisitors.Controls.Add(this.lblVFName);
            this.tpVisitors.Controls.Add(this.lstbxVisitorLog);
            this.tpVisitors.Controls.Add(this.cbxVID);
            this.tpVisitors.Controls.Add(this.dgvShowVisitors);
            this.tpVisitors.Controls.Add(this.txtContactNumber);
            this.tpVisitors.Controls.Add(this.txtVName);
            this.tpVisitors.Controls.Add(this.txtVLName);
            this.tpVisitors.Controls.Add(this.lblContactNumber);
            this.tpVisitors.Controls.Add(this.lblVAge);
            this.tpVisitors.Controls.Add(this.btnVisitorAction);
            this.tpVisitors.Controls.Add(this.lblVLName);
            this.tpVisitors.Location = new System.Drawing.Point(4, 29);
            this.tpVisitors.Name = "tpVisitors";
            this.tpVisitors.Padding = new System.Windows.Forms.Padding(3);
            this.tpVisitors.Size = new System.Drawing.Size(1487, 793);
            this.tpVisitors.TabIndex = 1;
            this.tpVisitors.Text = "Visitors";
            // 
            // pnlVHeading
            // 
            this.pnlVHeading.Controls.Add(this.lblVHeading);
            this.pnlVHeading.Location = new System.Drawing.Point(42, 16);
            this.pnlVHeading.Name = "pnlVHeading";
            this.pnlVHeading.Size = new System.Drawing.Size(655, 75);
            this.pnlVHeading.TabIndex = 31;
            // 
            // lblVHeading
            // 
            this.lblVHeading.AutoSize = true;
            this.lblVHeading.Location = new System.Drawing.Point(246, 25);
            this.lblVHeading.Name = "lblVHeading";
            this.lblVHeading.Size = new System.Drawing.Size(152, 20);
            this.lblVHeading.TabIndex = 0;
            this.lblVHeading.Text = "Maintain Visitors";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 20);
            this.label2.TabIndex = 30;
            this.label2.Text = "Choose Action:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Add Animal",
            "Change Animal Details",
            "Remove Animal"});
            this.comboBox1.Location = new System.Drawing.Point(576, 112);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 29;
            this.comboBox1.Text = "ACTION";
            // 
            // nudVAge
            // 
            this.nudVAge.Location = new System.Drawing.Point(228, 578);
            this.nudVAge.Name = "nudVAge";
            this.nudVAge.Size = new System.Drawing.Size(100, 28);
            this.nudVAge.TabIndex = 20;
            // 
            // lblVID
            // 
            this.lblVID.AutoSize = true;
            this.lblVID.Location = new System.Drawing.Point(39, 471);
            this.lblVID.Name = "lblVID";
            this.lblVID.Size = new System.Drawing.Size(38, 20);
            this.lblVID.TabIndex = 23;
            this.lblVID.Text = "ID:";
            // 
            // lblVFName
            // 
            this.lblVFName.AutoSize = true;
            this.lblVFName.Location = new System.Drawing.Point(39, 543);
            this.lblVFName.Name = "lblVFName";
            this.lblVFName.Size = new System.Drawing.Size(111, 20);
            this.lblVFName.TabIndex = 25;
            this.lblVFName.Text = "First Name:";
            // 
            // lstbxVisitorLog
            // 
            this.lstbxVisitorLog.FormattingEnabled = true;
            this.lstbxVisitorLog.ItemHeight = 20;
            this.lstbxVisitorLog.Location = new System.Drawing.Point(796, 16);
            this.lstbxVisitorLog.Name = "lstbxVisitorLog";
            this.lstbxVisitorLog.Size = new System.Drawing.Size(392, 704);
            this.lstbxVisitorLog.TabIndex = 28;
            // 
            // cbxVID
            // 
            this.cbxVID.FormattingEnabled = true;
            this.cbxVID.Location = new System.Drawing.Point(228, 468);
            this.cbxVID.Name = "cbxVID";
            this.cbxVID.Size = new System.Drawing.Size(100, 28);
            this.cbxVID.TabIndex = 17;
            // 
            // dgvShowVisitors
            // 
            this.dgvShowVisitors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowVisitors.Location = new System.Drawing.Point(42, 154);
            this.dgvShowVisitors.Name = "dgvShowVisitors";
            this.dgvShowVisitors.RowHeadersWidth = 51;
            this.dgvShowVisitors.RowTemplate.Height = 24;
            this.dgvShowVisitors.Size = new System.Drawing.Size(691, 308);
            this.dgvShowVisitors.TabIndex = 16;
            // 
            // txtContactNumber
            // 
            this.txtContactNumber.Location = new System.Drawing.Point(228, 614);
            this.txtContactNumber.Name = "txtContactNumber";
            this.txtContactNumber.Size = new System.Drawing.Size(100, 28);
            this.txtContactNumber.TabIndex = 21;
            // 
            // txtVName
            // 
            this.txtVName.Location = new System.Drawing.Point(228, 541);
            this.txtVName.Name = "txtVName";
            this.txtVName.Size = new System.Drawing.Size(100, 28);
            this.txtVName.TabIndex = 19;
            // 
            // txtVLName
            // 
            this.txtVLName.Location = new System.Drawing.Point(228, 502);
            this.txtVLName.Name = "txtVLName";
            this.txtVLName.Size = new System.Drawing.Size(100, 28);
            this.txtVLName.TabIndex = 18;
            // 
            // lblContactNumber
            // 
            this.lblContactNumber.AutoSize = true;
            this.lblContactNumber.Location = new System.Drawing.Point(39, 617);
            this.lblContactNumber.Name = "lblContactNumber";
            this.lblContactNumber.Size = new System.Drawing.Size(158, 20);
            this.lblContactNumber.TabIndex = 27;
            this.lblContactNumber.Text = "Contact Number:";
            // 
            // lblVAge
            // 
            this.lblVAge.AutoSize = true;
            this.lblVAge.Location = new System.Drawing.Point(39, 578);
            this.lblVAge.Name = "lblVAge";
            this.lblVAge.Size = new System.Drawing.Size(181, 20);
            this.lblVAge.TabIndex = 26;
            this.lblVAge.Text = "Age: (Date of birth)";
            // 
            // btnVisitorAction
            // 
            this.btnVisitorAction.Location = new System.Drawing.Point(538, 490);
            this.btnVisitorAction.Name = "btnVisitorAction";
            this.btnVisitorAction.Size = new System.Drawing.Size(195, 158);
            this.btnVisitorAction.TabIndex = 22;
            this.btnVisitorAction.Text = "ACTION";
            this.btnVisitorAction.UseVisualStyleBackColor = true;
            this.btnVisitorAction.Click += new System.EventHandler(this.btnVisitorAction_Click);
            // 
            // lblVLName
            // 
            this.lblVLName.AutoSize = true;
            this.lblVLName.Location = new System.Drawing.Point(39, 505);
            this.lblVLName.Name = "lblVLName";
            this.lblVLName.Size = new System.Drawing.Size(108, 20);
            this.lblVLName.TabIndex = 24;
            this.lblVLName.Text = "Last Name:";
            // 
            // tpReports
            // 
            this.tpReports.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.tpReports.Controls.Add(this.lstbxReport);
            this.tpReports.Controls.Add(this.btnTotalCost);
            this.tpReports.Controls.Add(this.btnNumTickets);
            this.tpReports.Location = new System.Drawing.Point(4, 29);
            this.tpReports.Name = "tpReports";
            this.tpReports.Size = new System.Drawing.Size(1487, 793);
            this.tpReports.TabIndex = 2;
            this.tpReports.Text = "Reports";
            // 
            // lstbxReport
            // 
            this.lstbxReport.FormattingEnabled = true;
            this.lstbxReport.ItemHeight = 20;
            this.lstbxReport.Location = new System.Drawing.Point(17, 134);
            this.lstbxReport.Name = "lstbxReport";
            this.lstbxReport.Size = new System.Drawing.Size(489, 404);
            this.lstbxReport.TabIndex = 2;
            // 
            // btnTotalCost
            // 
            this.btnTotalCost.Location = new System.Drawing.Point(17, 65);
            this.btnTotalCost.Name = "btnTotalCost";
            this.btnTotalCost.Size = new System.Drawing.Size(372, 41);
            this.btnTotalCost.TabIndex = 1;
            this.btnTotalCost.Text = "Report for total ticket cost";
            this.btnTotalCost.UseVisualStyleBackColor = true;
            // 
            // btnNumTickets
            // 
            this.btnNumTickets.Location = new System.Drawing.Point(17, 23);
            this.btnNumTickets.Name = "btnNumTickets";
            this.btnNumTickets.Size = new System.Drawing.Size(372, 36);
            this.btnNumTickets.TabIndex = 0;
            this.btnNumTickets.Text = "Report for number of tickets";
            this.btnNumTickets.UseVisualStyleBackColor = true;
            // 
            // nudAMonth
            // 
            this.nudAMonth.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudAMonth.Location = new System.Drawing.Point(314, 579);
            this.nudAMonth.Name = "nudAMonth";
            this.nudAMonth.Size = new System.Drawing.Size(42, 28);
            this.nudAMonth.TabIndex = 23;
            // 
            // nudAYear
            // 
            this.nudAYear.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudAYear.Location = new System.Drawing.Point(385, 579);
            this.nudAYear.Name = "nudAYear";
            this.nudAYear.Size = new System.Drawing.Size(66, 28);
            this.nudAYear.TabIndex = 24;
            // 
            // lblAGap1
            // 
            this.lblAGap1.AutoSize = true;
            this.lblAGap1.Location = new System.Drawing.Point(291, 581);
            this.lblAGap1.Name = "lblAGap1";
            this.lblAGap1.Size = new System.Drawing.Size(17, 20);
            this.lblAGap1.TabIndex = 25;
            this.lblAGap1.Text = "/";
            // 
            // lblAGap2
            // 
            this.lblAGap2.AutoSize = true;
            this.lblAGap2.Location = new System.Drawing.Point(362, 581);
            this.lblAGap2.Name = "lblAGap2";
            this.lblAGap2.Size = new System.Drawing.Size(17, 20);
            this.lblAGap2.TabIndex = 26;
            this.lblAGap2.Text = "/";
            // 
            // AdminForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1522, 826);
            this.Controls.Add(this.tcAdmin);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.tcAdmin.ResumeLayout(false);
            this.tpAnimals.ResumeLayout(false);
            this.tpAnimals.PerformLayout();
            this.pnlAGender.ResumeLayout(false);
            this.pnlAGender.PerformLayout();
            this.pnlAHeading.ResumeLayout(false);
            this.pnlAHeading.PerformLayout();
            this.pnlYesNo.ResumeLayout(false);
            this.pnlYesNo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudADay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowAnimals)).EndInit();
            this.tpVisitors.ResumeLayout(false);
            this.tpVisitors.PerformLayout();
            this.pnlVHeading.ResumeLayout(false);
            this.pnlVHeading.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudVAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowVisitors)).EndInit();
            this.tpReports.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudAMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAYear)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcAdmin;
        private System.Windows.Forms.TabPage tpAnimals;
        private System.Windows.Forms.TabPage tpVisitors;
        private System.Windows.Forms.TabPage tpReports;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblAName;
        private System.Windows.Forms.Button btnAnimalAction;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.TextBox txtAName;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblVaccStatus;
        private System.Windows.Forms.Label lblADOB;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.ComboBox cbxID;
        private System.Windows.Forms.DataGridView dgvShowAnimals;
        private System.Windows.Forms.NumericUpDown nudADay;
        private System.Windows.Forms.Panel pnlYesNo;
        private System.Windows.Forms.RadioButton rdbFalse;
        private System.Windows.Forms.RadioButton rdbTrue;
        private System.Windows.Forms.ListBox lstbxAnimalLog;
        private System.Windows.Forms.NumericUpDown nudVAge;
        private System.Windows.Forms.Label lblVID;
        private System.Windows.Forms.Label lblVFName;
        private System.Windows.Forms.ListBox lstbxVisitorLog;
        private System.Windows.Forms.ComboBox cbxVID;
        private System.Windows.Forms.DataGridView dgvShowVisitors;
        private System.Windows.Forms.TextBox txtContactNumber;
        private System.Windows.Forms.TextBox txtVName;
        private System.Windows.Forms.TextBox txtVLName;
        private System.Windows.Forms.Label lblContactNumber;
        private System.Windows.Forms.Label lblVAge;
        private System.Windows.Forms.Button btnVisitorAction;
        private System.Windows.Forms.Label lblVLName;
        private System.Windows.Forms.ListBox lstbxReport;
        private System.Windows.Forms.Button btnTotalCost;
        private System.Windows.Forms.Button btnNumTickets;
        private System.Windows.Forms.Label lblActionChoose;
        private System.Windows.Forms.ComboBox cbxChooseAction;
        private System.Windows.Forms.Panel pnlAHeading;
        private System.Windows.Forms.Label lblAHeading;
        private System.Windows.Forms.Panel pnlVHeading;
        private System.Windows.Forms.Label lblVHeading;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel pnlAGender;
        private System.Windows.Forms.RadioButton rdbFemale;
        private System.Windows.Forms.RadioButton rdbMale;
        private System.Windows.Forms.NumericUpDown nudAYear;
        private System.Windows.Forms.NumericUpDown nudAMonth;
        private System.Windows.Forms.Label lblAGap2;
        private System.Windows.Forms.Label lblAGap1;
    }
}