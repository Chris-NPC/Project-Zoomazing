
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAHeading = new System.Windows.Forms.Label();
            this.lblActionChoose = new System.Windows.Forms.Label();
            this.cbxChooseAction = new System.Windows.Forms.ComboBox();
            this.lstbxAnimalLog = new System.Windows.Forms.ListBox();
            this.pnlYesNo = new System.Windows.Forms.Panel();
            this.rdbFalse = new System.Windows.Forms.RadioButton();
            this.rdbTrue = new System.Windows.Forms.RadioButton();
            this.cbxGender = new System.Windows.Forms.ComboBox();
            this.nudAAge = new System.Windows.Forms.NumericUpDown();
            this.cbxID = new System.Windows.Forms.ComboBox();
            this.dgvShowAnimals = new System.Windows.Forms.DataGridView();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtAName = new System.Windows.Forms.TextBox();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblVaccStatus = new System.Windows.Forms.Label();
            this.lblAAge = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.btnAnimalAction = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.lblAName = new System.Windows.Forms.Label();
            this.tpVisitors = new System.Windows.Forms.TabPage();
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
            this.btnAddVisitor = new System.Windows.Forms.Button();
            this.lblVLName = new System.Windows.Forms.Label();
            this.tpReports = new System.Windows.Forms.TabPage();
            this.lstbxReport = new System.Windows.Forms.ListBox();
            this.btnTotalCost = new System.Windows.Forms.Button();
            this.btnNumTickets = new System.Windows.Forms.Button();
            this.tcAdmin.SuspendLayout();
            this.tpAnimals.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlYesNo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowAnimals)).BeginInit();
            this.tpVisitors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudVAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowVisitors)).BeginInit();
            this.tpReports.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcAdmin
            // 
            this.tcAdmin.Controls.Add(this.tpAnimals);
            this.tcAdmin.Controls.Add(this.tpVisitors);
            this.tcAdmin.Controls.Add(this.tpReports);
            this.tcAdmin.Location = new System.Drawing.Point(0, 0);
            this.tcAdmin.Name = "tcAdmin";
            this.tcAdmin.SelectedIndex = 0;
            this.tcAdmin.Size = new System.Drawing.Size(1306, 801);
            this.tcAdmin.TabIndex = 0;
            // 
            // tpAnimals
            // 
            this.tpAnimals.Controls.Add(this.panel1);
            this.tpAnimals.Controls.Add(this.lblActionChoose);
            this.tpAnimals.Controls.Add(this.cbxChooseAction);
            this.tpAnimals.Controls.Add(this.lstbxAnimalLog);
            this.tpAnimals.Controls.Add(this.pnlYesNo);
            this.tpAnimals.Controls.Add(this.cbxGender);
            this.tpAnimals.Controls.Add(this.nudAAge);
            this.tpAnimals.Controls.Add(this.cbxID);
            this.tpAnimals.Controls.Add(this.dgvShowAnimals);
            this.tpAnimals.Controls.Add(this.txtWeight);
            this.tpAnimals.Controls.Add(this.txtAName);
            this.tpAnimals.Controls.Add(this.lblWeight);
            this.tpAnimals.Controls.Add(this.lblVaccStatus);
            this.tpAnimals.Controls.Add(this.lblAAge);
            this.tpAnimals.Controls.Add(this.lblGender);
            this.tpAnimals.Controls.Add(this.btnAnimalAction);
            this.tpAnimals.Controls.Add(this.lblID);
            this.tpAnimals.Controls.Add(this.lblAName);
            this.tpAnimals.Location = new System.Drawing.Point(4, 25);
            this.tpAnimals.Name = "tpAnimals";
            this.tpAnimals.Padding = new System.Windows.Forms.Padding(3);
            this.tpAnimals.Size = new System.Drawing.Size(1298, 772);
            this.tpAnimals.TabIndex = 0;
            this.tpAnimals.Text = "Animals";
            this.tpAnimals.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblAHeading);
            this.panel1.Location = new System.Drawing.Point(42, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(655, 75);
            this.panel1.TabIndex = 21;
            // 
            // lblAHeading
            // 
            this.lblAHeading.AutoSize = true;
            this.lblAHeading.Location = new System.Drawing.Point(246, 25);
            this.lblAHeading.Name = "lblAHeading";
            this.lblAHeading.Size = new System.Drawing.Size(114, 17);
            this.lblAHeading.TabIndex = 0;
            this.lblAHeading.Text = "Maintain Animals";
            // 
            // lblActionChoose
            // 
            this.lblActionChoose.AutoSize = true;
            this.lblActionChoose.Location = new System.Drawing.Point(39, 119);
            this.lblActionChoose.Name = "lblActionChoose";
            this.lblActionChoose.Size = new System.Drawing.Size(103, 17);
            this.lblActionChoose.TabIndex = 20;
            this.lblActionChoose.Text = "Choose Action:";
            // 
            // cbxChooseAction
            // 
            this.cbxChooseAction.FormattingEnabled = true;
            this.cbxChooseAction.Items.AddRange(new object[] {
            "Add Animal",
            "Change Animal Details",
            "Remove Animal"});
            this.cbxChooseAction.Location = new System.Drawing.Point(576, 112);
            this.cbxChooseAction.Name = "cbxChooseAction";
            this.cbxChooseAction.Size = new System.Drawing.Size(121, 24);
            this.cbxChooseAction.TabIndex = 19;
            this.cbxChooseAction.Text = "ACTION";
            this.cbxChooseAction.SelectedIndexChanged += new System.EventHandler(this.cbxChooseAction_SelectedIndexChanged);
            // 
            // lstbxAnimalLog
            // 
            this.lstbxAnimalLog.FormattingEnabled = true;
            this.lstbxAnimalLog.ItemHeight = 16;
            this.lstbxAnimalLog.Location = new System.Drawing.Point(796, 16);
            this.lstbxAnimalLog.Name = "lstbxAnimalLog";
            this.lstbxAnimalLog.Size = new System.Drawing.Size(392, 292);
            this.lstbxAnimalLog.TabIndex = 18;
            // 
            // pnlYesNo
            // 
            this.pnlYesNo.Controls.Add(this.rdbFalse);
            this.pnlYesNo.Controls.Add(this.rdbTrue);
            this.pnlYesNo.Location = new System.Drawing.Point(229, 641);
            this.pnlYesNo.Name = "pnlYesNo";
            this.pnlYesNo.Size = new System.Drawing.Size(99, 66);
            this.pnlYesNo.TabIndex = 7;
            // 
            // rdbFalse
            // 
            this.rdbFalse.AutoSize = true;
            this.rdbFalse.Location = new System.Drawing.Point(14, 36);
            this.rdbFalse.Name = "rdbFalse";
            this.rdbFalse.Size = new System.Drawing.Size(63, 21);
            this.rdbFalse.TabIndex = 1;
            this.rdbFalse.TabStop = true;
            this.rdbFalse.Text = "False";
            this.rdbFalse.UseVisualStyleBackColor = true;
            // 
            // rdbTrue
            // 
            this.rdbTrue.AutoSize = true;
            this.rdbTrue.Location = new System.Drawing.Point(14, 9);
            this.rdbTrue.Name = "rdbTrue";
            this.rdbTrue.Size = new System.Drawing.Size(59, 21);
            this.rdbTrue.TabIndex = 0;
            this.rdbTrue.TabStop = true;
            this.rdbTrue.Text = "True";
            this.rdbTrue.UseVisualStyleBackColor = true;
            // 
            // cbxGender
            // 
            this.cbxGender.FormattingEnabled = true;
            this.cbxGender.Location = new System.Drawing.Point(229, 574);
            this.cbxGender.Name = "cbxGender";
            this.cbxGender.Size = new System.Drawing.Size(100, 24);
            this.cbxGender.TabIndex = 5;
            // 
            // nudAAge
            // 
            this.nudAAge.Location = new System.Drawing.Point(229, 541);
            this.nudAAge.Name = "nudAAge";
            this.nudAAge.Size = new System.Drawing.Size(99, 22);
            this.nudAAge.TabIndex = 4;
            // 
            // cbxID
            // 
            this.cbxID.FormattingEnabled = true;
            this.cbxID.Location = new System.Drawing.Point(228, 468);
            this.cbxID.Name = "cbxID";
            this.cbxID.Size = new System.Drawing.Size(100, 24);
            this.cbxID.TabIndex = 2;
            // 
            // dgvShowAnimals
            // 
            this.dgvShowAnimals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowAnimals.Location = new System.Drawing.Point(42, 154);
            this.dgvShowAnimals.Name = "dgvShowAnimals";
            this.dgvShowAnimals.RowHeadersWidth = 51;
            this.dgvShowAnimals.RowTemplate.Height = 24;
            this.dgvShowAnimals.Size = new System.Drawing.Size(691, 308);
            this.dgvShowAnimals.TabIndex = 1;
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(228, 613);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(100, 22);
            this.txtWeight.TabIndex = 6;
            // 
            // txtAName
            // 
            this.txtAName.Location = new System.Drawing.Point(228, 502);
            this.txtAName.Name = "txtAName";
            this.txtAName.Size = new System.Drawing.Size(100, 22);
            this.txtAName.TabIndex = 3;
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(39, 616);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(100, 17);
            this.lblWeight.TabIndex = 13;
            this.lblWeight.Text = "Weight (in kg):";
            // 
            // lblVaccStatus
            // 
            this.lblVaccStatus.AutoSize = true;
            this.lblVaccStatus.Location = new System.Drawing.Point(39, 666);
            this.lblVaccStatus.Name = "lblVaccStatus";
            this.lblVaccStatus.Size = new System.Drawing.Size(129, 17);
            this.lblVaccStatus.TabIndex = 14;
            this.lblVaccStatus.Text = "Vaccination Status:";
            // 
            // lblAAge
            // 
            this.lblAAge.AutoSize = true;
            this.lblAAge.Location = new System.Drawing.Point(39, 543);
            this.lblAAge.Name = "lblAAge";
            this.lblAAge.Size = new System.Drawing.Size(37, 17);
            this.lblAAge.TabIndex = 11;
            this.lblAAge.Text = "Age:";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(39, 577);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(60, 17);
            this.lblGender.TabIndex = 12;
            this.lblGender.Text = "Gender:";
            // 
            // btnAnimalAction
            // 
            this.btnAnimalAction.Location = new System.Drawing.Point(538, 490);
            this.btnAnimalAction.Name = "btnAnimalAction";
            this.btnAnimalAction.Size = new System.Drawing.Size(195, 158);
            this.btnAnimalAction.TabIndex = 8;
            this.btnAnimalAction.Text = "Action";
            this.btnAnimalAction.UseVisualStyleBackColor = true;
            this.btnAnimalAction.Click += new System.EventHandler(this.btnAnimalAction_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(39, 471);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(25, 17);
            this.lblID.TabIndex = 9;
            this.lblID.Text = "ID:";
            // 
            // lblAName
            // 
            this.lblAName.AutoSize = true;
            this.lblAName.Location = new System.Drawing.Point(39, 505);
            this.lblAName.Name = "lblAName";
            this.lblAName.Size = new System.Drawing.Size(49, 17);
            this.lblAName.TabIndex = 10;
            this.lblAName.Text = "Name:";
            // 
            // tpVisitors
            // 
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
            this.tpVisitors.Controls.Add(this.btnAddVisitor);
            this.tpVisitors.Controls.Add(this.lblVLName);
            this.tpVisitors.Location = new System.Drawing.Point(4, 25);
            this.tpVisitors.Name = "tpVisitors";
            this.tpVisitors.Padding = new System.Windows.Forms.Padding(3);
            this.tpVisitors.Size = new System.Drawing.Size(1298, 772);
            this.tpVisitors.TabIndex = 1;
            this.tpVisitors.Text = "Visitors";
            this.tpVisitors.UseVisualStyleBackColor = true;
            // 
            // nudVAge
            // 
            this.nudVAge.Location = new System.Drawing.Point(230, 446);
            this.nudVAge.Name = "nudVAge";
            this.nudVAge.Size = new System.Drawing.Size(100, 22);
            this.nudVAge.TabIndex = 20;
            // 
            // lblVID
            // 
            this.lblVID.AutoSize = true;
            this.lblVID.Location = new System.Drawing.Point(40, 342);
            this.lblVID.Name = "lblVID";
            this.lblVID.Size = new System.Drawing.Size(25, 17);
            this.lblVID.TabIndex = 23;
            this.lblVID.Text = "ID:";
            // 
            // lblVFName
            // 
            this.lblVFName.AutoSize = true;
            this.lblVFName.Location = new System.Drawing.Point(43, 414);
            this.lblVFName.Name = "lblVFName";
            this.lblVFName.Size = new System.Drawing.Size(80, 17);
            this.lblVFName.TabIndex = 25;
            this.lblVFName.Text = "First Name:";
            // 
            // lstbxVisitorLog
            // 
            this.lstbxVisitorLog.FormattingEnabled = true;
            this.lstbxVisitorLog.ItemHeight = 16;
            this.lstbxVisitorLog.Location = new System.Drawing.Point(574, 6);
            this.lstbxVisitorLog.Name = "lstbxVisitorLog";
            this.lstbxVisitorLog.Size = new System.Drawing.Size(241, 292);
            this.lstbxVisitorLog.TabIndex = 28;
            // 
            // cbxVID
            // 
            this.cbxVID.FormattingEnabled = true;
            this.cbxVID.Location = new System.Drawing.Point(229, 339);
            this.cbxVID.Name = "cbxVID";
            this.cbxVID.Size = new System.Drawing.Size(100, 24);
            this.cbxVID.TabIndex = 17;
            // 
            // dgvShowVisitors
            // 
            this.dgvShowVisitors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowVisitors.Location = new System.Drawing.Point(8, 6);
            this.dgvShowVisitors.Name = "dgvShowVisitors";
            this.dgvShowVisitors.RowHeadersWidth = 51;
            this.dgvShowVisitors.RowTemplate.Height = 24;
            this.dgvShowVisitors.Size = new System.Drawing.Size(466, 298);
            this.dgvShowVisitors.TabIndex = 16;
            // 
            // txtContactNumber
            // 
            this.txtContactNumber.Location = new System.Drawing.Point(229, 484);
            this.txtContactNumber.Name = "txtContactNumber";
            this.txtContactNumber.Size = new System.Drawing.Size(100, 22);
            this.txtContactNumber.TabIndex = 21;
            // 
            // txtVName
            // 
            this.txtVName.Location = new System.Drawing.Point(229, 411);
            this.txtVName.Name = "txtVName";
            this.txtVName.Size = new System.Drawing.Size(100, 22);
            this.txtVName.TabIndex = 19;
            // 
            // txtVLName
            // 
            this.txtVLName.Location = new System.Drawing.Point(229, 373);
            this.txtVLName.Name = "txtVLName";
            this.txtVLName.Size = new System.Drawing.Size(100, 22);
            this.txtVLName.TabIndex = 18;
            // 
            // lblContactNumber
            // 
            this.lblContactNumber.AutoSize = true;
            this.lblContactNumber.Location = new System.Drawing.Point(40, 487);
            this.lblContactNumber.Name = "lblContactNumber";
            this.lblContactNumber.Size = new System.Drawing.Size(114, 17);
            this.lblContactNumber.TabIndex = 27;
            this.lblContactNumber.Text = "Contact Number:";
            // 
            // lblVAge
            // 
            this.lblVAge.AutoSize = true;
            this.lblVAge.Location = new System.Drawing.Point(40, 448);
            this.lblVAge.Name = "lblVAge";
            this.lblVAge.Size = new System.Drawing.Size(37, 17);
            this.lblVAge.TabIndex = 26;
            this.lblVAge.Text = "Age:";
            // 
            // btnAddVisitor
            // 
            this.btnAddVisitor.Location = new System.Drawing.Point(187, 584);
            this.btnAddVisitor.Name = "btnAddVisitor";
            this.btnAddVisitor.Size = new System.Drawing.Size(95, 47);
            this.btnAddVisitor.TabIndex = 22;
            this.btnAddVisitor.Text = "Add Visitor";
            this.btnAddVisitor.UseVisualStyleBackColor = true;
            this.btnAddVisitor.Click += new System.EventHandler(this.btnAddVisitor_Click);
            // 
            // lblVLName
            // 
            this.lblVLName.AutoSize = true;
            this.lblVLName.Location = new System.Drawing.Point(40, 376);
            this.lblVLName.Name = "lblVLName";
            this.lblVLName.Size = new System.Drawing.Size(80, 17);
            this.lblVLName.TabIndex = 24;
            this.lblVLName.Text = "Last Name:";
            // 
            // tpReports
            // 
            this.tpReports.Controls.Add(this.lstbxReport);
            this.tpReports.Controls.Add(this.btnTotalCost);
            this.tpReports.Controls.Add(this.btnNumTickets);
            this.tpReports.Location = new System.Drawing.Point(4, 25);
            this.tpReports.Name = "tpReports";
            this.tpReports.Size = new System.Drawing.Size(1298, 772);
            this.tpReports.TabIndex = 2;
            this.tpReports.Text = "Reports";
            this.tpReports.UseVisualStyleBackColor = true;
            // 
            // lstbxReport
            // 
            this.lstbxReport.FormattingEnabled = true;
            this.lstbxReport.ItemHeight = 16;
            this.lstbxReport.Location = new System.Drawing.Point(17, 134);
            this.lstbxReport.Name = "lstbxReport";
            this.lstbxReport.Size = new System.Drawing.Size(489, 404);
            this.lstbxReport.TabIndex = 2;
            // 
            // btnTotalCost
            // 
            this.btnTotalCost.Location = new System.Drawing.Point(17, 65);
            this.btnTotalCost.Name = "btnTotalCost";
            this.btnTotalCost.Size = new System.Drawing.Size(238, 41);
            this.btnTotalCost.TabIndex = 1;
            this.btnTotalCost.Text = "Report for total ticket cost";
            this.btnTotalCost.UseVisualStyleBackColor = true;
            // 
            // btnNumTickets
            // 
            this.btnNumTickets.Location = new System.Drawing.Point(17, 23);
            this.btnNumTickets.Name = "btnNumTickets";
            this.btnNumTickets.Size = new System.Drawing.Size(238, 36);
            this.btnNumTickets.TabIndex = 0;
            this.btnNumTickets.Text = "Report for number of tickets";
            this.btnNumTickets.UseVisualStyleBackColor = true;
            // 
            // AdminForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1307, 800);
            this.Controls.Add(this.tcAdmin);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tcAdmin.ResumeLayout(false);
            this.tpAnimals.ResumeLayout(false);
            this.tpAnimals.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlYesNo.ResumeLayout(false);
            this.pnlYesNo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowAnimals)).EndInit();
            this.tpVisitors.ResumeLayout(false);
            this.tpVisitors.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudVAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowVisitors)).EndInit();
            this.tpReports.ResumeLayout(false);
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
        private System.Windows.Forms.Label lblAAge;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.ComboBox cbxID;
        private System.Windows.Forms.DataGridView dgvShowAnimals;
        private System.Windows.Forms.ComboBox cbxGender;
        private System.Windows.Forms.NumericUpDown nudAAge;
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
        private System.Windows.Forms.Button btnAddVisitor;
        private System.Windows.Forms.Label lblVLName;
        private System.Windows.Forms.ListBox lstbxReport;
        private System.Windows.Forms.Button btnTotalCost;
        private System.Windows.Forms.Button btnNumTickets;
        private System.Windows.Forms.Label lblActionChoose;
        private System.Windows.Forms.ComboBox cbxChooseAction;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblAHeading;
    }
}