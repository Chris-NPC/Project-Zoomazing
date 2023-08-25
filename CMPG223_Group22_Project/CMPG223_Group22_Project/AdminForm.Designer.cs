
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
            this.lstbxAnimalLog = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdbFalse = new System.Windows.Forms.RadioButton();
            this.rdbTrue = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.cbxID = new System.Windows.Forms.ComboBox();
            this.dgvShowAnimals = new System.Windows.Forms.DataGridView();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblVaccStatus = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.btnAddAnimal = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.tpVisitors = new System.Windows.Forms.TabPage();
            this.tpReports = new System.Windows.Forms.TabPage();
            this.lstbxVisitorLog = new System.Windows.Forms.ListBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.dgvShowVisitors = new System.Windows.Forms.DataGridView();
            this.txtContactNumber = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.lblContactNumber = new System.Windows.Forms.Label();
            this.lblVAge = new System.Windows.Forms.Label();
            this.btnAddVisitor = new System.Windows.Forms.Button();
            this.lblVLName = new System.Windows.Forms.Label();
            this.lblVFName = new System.Windows.Forms.Label();
            this.lblVID = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.btnNumTickets = new System.Windows.Forms.Button();
            this.btnTotalCost = new System.Windows.Forms.Button();
            this.lstbxReport = new System.Windows.Forms.ListBox();
            this.tcAdmin.SuspendLayout();
            this.tpAnimals.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowAnimals)).BeginInit();
            this.tpVisitors.SuspendLayout();
            this.tpReports.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowVisitors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
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
            this.tcAdmin.Size = new System.Drawing.Size(1306, 717);
            this.tcAdmin.TabIndex = 0;
            // 
            // tpAnimals
            // 
            this.tpAnimals.Controls.Add(this.lstbxAnimalLog);
            this.tpAnimals.Controls.Add(this.panel1);
            this.tpAnimals.Controls.Add(this.comboBox1);
            this.tpAnimals.Controls.Add(this.numericUpDown1);
            this.tpAnimals.Controls.Add(this.cbxID);
            this.tpAnimals.Controls.Add(this.dgvShowAnimals);
            this.tpAnimals.Controls.Add(this.textBox6);
            this.tpAnimals.Controls.Add(this.textBox3);
            this.tpAnimals.Controls.Add(this.txtName);
            this.tpAnimals.Controls.Add(this.lblWeight);
            this.tpAnimals.Controls.Add(this.lblVaccStatus);
            this.tpAnimals.Controls.Add(this.lblAge);
            this.tpAnimals.Controls.Add(this.lblGender);
            this.tpAnimals.Controls.Add(this.btnAddAnimal);
            this.tpAnimals.Controls.Add(this.lblID);
            this.tpAnimals.Controls.Add(this.lblName);
            this.tpAnimals.Location = new System.Drawing.Point(4, 25);
            this.tpAnimals.Name = "tpAnimals";
            this.tpAnimals.Padding = new System.Windows.Forms.Padding(3);
            this.tpAnimals.Size = new System.Drawing.Size(1298, 688);
            this.tpAnimals.TabIndex = 0;
            this.tpAnimals.Text = "Animals";
            this.tpAnimals.UseVisualStyleBackColor = true;
            // 
            // lstbxAnimalLog
            // 
            this.lstbxAnimalLog.FormattingEnabled = true;
            this.lstbxAnimalLog.ItemHeight = 16;
            this.lstbxAnimalLog.Location = new System.Drawing.Point(574, 6);
            this.lstbxAnimalLog.Name = "lstbxAnimalLog";
            this.lstbxAnimalLog.Size = new System.Drawing.Size(241, 292);
            this.lstbxAnimalLog.TabIndex = 18;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdbFalse);
            this.panel1.Controls.Add(this.rdbTrue);
            this.panel1.Location = new System.Drawing.Point(230, 512);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(99, 66);
            this.panel1.TabIndex = 7;
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
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(229, 445);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 24);
            this.comboBox1.TabIndex = 5;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(230, 412);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(99, 22);
            this.numericUpDown1.TabIndex = 4;
            // 
            // cbxID
            // 
            this.cbxID.FormattingEnabled = true;
            this.cbxID.Location = new System.Drawing.Point(229, 339);
            this.cbxID.Name = "cbxID";
            this.cbxID.Size = new System.Drawing.Size(100, 24);
            this.cbxID.TabIndex = 2;
            // 
            // dgvShowAnimals
            // 
            this.dgvShowAnimals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowAnimals.Location = new System.Drawing.Point(8, 6);
            this.dgvShowAnimals.Name = "dgvShowAnimals";
            this.dgvShowAnimals.RowHeadersWidth = 51;
            this.dgvShowAnimals.RowTemplate.Height = 24;
            this.dgvShowAnimals.Size = new System.Drawing.Size(466, 298);
            this.dgvShowAnimals.TabIndex = 1;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(229, 484);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 22);
            this.textBox6.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(229, 445);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 10;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(229, 373);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 3;
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(40, 487);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(100, 17);
            this.lblWeight.TabIndex = 13;
            this.lblWeight.Text = "Weight (in kg):";
            // 
            // lblVaccStatus
            // 
            this.lblVaccStatus.AutoSize = true;
            this.lblVaccStatus.Location = new System.Drawing.Point(40, 521);
            this.lblVaccStatus.Name = "lblVaccStatus";
            this.lblVaccStatus.Size = new System.Drawing.Size(129, 17);
            this.lblVaccStatus.TabIndex = 14;
            this.lblVaccStatus.Text = "Vaccination Status:";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(40, 414);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(37, 17);
            this.lblAge.TabIndex = 11;
            this.lblAge.Text = "Age:";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(40, 448);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(60, 17);
            this.lblGender.TabIndex = 12;
            this.lblGender.Text = "Gender:";
            // 
            // btnAddAnimal
            // 
            this.btnAddAnimal.Location = new System.Drawing.Point(187, 584);
            this.btnAddAnimal.Name = "btnAddAnimal";
            this.btnAddAnimal.Size = new System.Drawing.Size(95, 47);
            this.btnAddAnimal.TabIndex = 8;
            this.btnAddAnimal.Text = "Add Animal";
            this.btnAddAnimal.UseVisualStyleBackColor = true;
            this.btnAddAnimal.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(40, 342);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(25, 17);
            this.lblID.TabIndex = 9;
            this.lblID.Text = "ID:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(40, 376);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 17);
            this.lblName.TabIndex = 10;
            this.lblName.Text = "Name:";
            // 
            // tpVisitors
            // 
            this.tpVisitors.Controls.Add(this.numericUpDown2);
            this.tpVisitors.Controls.Add(this.lblVID);
            this.tpVisitors.Controls.Add(this.lblVFName);
            this.tpVisitors.Controls.Add(this.lstbxVisitorLog);
            this.tpVisitors.Controls.Add(this.comboBox3);
            this.tpVisitors.Controls.Add(this.dgvShowVisitors);
            this.tpVisitors.Controls.Add(this.txtContactNumber);
            this.tpVisitors.Controls.Add(this.textBox2);
            this.tpVisitors.Controls.Add(this.textBox4);
            this.tpVisitors.Controls.Add(this.lblContactNumber);
            this.tpVisitors.Controls.Add(this.lblVAge);
            this.tpVisitors.Controls.Add(this.btnAddVisitor);
            this.tpVisitors.Controls.Add(this.lblVLName);
            this.tpVisitors.Location = new System.Drawing.Point(4, 25);
            this.tpVisitors.Name = "tpVisitors";
            this.tpVisitors.Padding = new System.Windows.Forms.Padding(3);
            this.tpVisitors.Size = new System.Drawing.Size(1298, 688);
            this.tpVisitors.TabIndex = 1;
            this.tpVisitors.Text = "Visitors";
            this.tpVisitors.UseVisualStyleBackColor = true;
            // 
            // tpReports
            // 
            this.tpReports.Controls.Add(this.lstbxReport);
            this.tpReports.Controls.Add(this.btnTotalCost);
            this.tpReports.Controls.Add(this.btnNumTickets);
            this.tpReports.Location = new System.Drawing.Point(4, 25);
            this.tpReports.Name = "tpReports";
            this.tpReports.Size = new System.Drawing.Size(1298, 688);
            this.tpReports.TabIndex = 2;
            this.tpReports.Text = "Reports";
            this.tpReports.UseVisualStyleBackColor = true;
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
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(229, 339);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(100, 24);
            this.comboBox3.TabIndex = 17;
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
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(229, 411);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 19;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(229, 373);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 18;
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
            // lblVFName
            // 
            this.lblVFName.AutoSize = true;
            this.lblVFName.Location = new System.Drawing.Point(43, 414);
            this.lblVFName.Name = "lblVFName";
            this.lblVFName.Size = new System.Drawing.Size(80, 17);
            this.lblVFName.TabIndex = 25;
            this.lblVFName.Text = "First Name:";
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
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(230, 446);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(100, 22);
            this.numericUpDown2.TabIndex = 20;
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
            // btnTotalCost
            // 
            this.btnTotalCost.Location = new System.Drawing.Point(17, 65);
            this.btnTotalCost.Name = "btnTotalCost";
            this.btnTotalCost.Size = new System.Drawing.Size(238, 41);
            this.btnTotalCost.TabIndex = 1;
            this.btnTotalCost.Text = "Report for total ticket cost";
            this.btnTotalCost.UseVisualStyleBackColor = true;
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
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1450, 729);
            this.Controls.Add(this.tcAdmin);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.tcAdmin.ResumeLayout(false);
            this.tpAnimals.ResumeLayout(false);
            this.tpAnimals.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowAnimals)).EndInit();
            this.tpVisitors.ResumeLayout(false);
            this.tpVisitors.PerformLayout();
            this.tpReports.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowVisitors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcAdmin;
        private System.Windows.Forms.TabPage tpAnimals;
        private System.Windows.Forms.TabPage tpVisitors;
        private System.Windows.Forms.TabPage tpReports;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnAddAnimal;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblVaccStatus;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.ComboBox cbxID;
        private System.Windows.Forms.DataGridView dgvShowAnimals;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdbFalse;
        private System.Windows.Forms.RadioButton rdbTrue;
        private System.Windows.Forms.ListBox lstbxAnimalLog;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label lblVID;
        private System.Windows.Forms.Label lblVFName;
        private System.Windows.Forms.ListBox lstbxVisitorLog;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.DataGridView dgvShowVisitors;
        private System.Windows.Forms.TextBox txtContactNumber;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label lblContactNumber;
        private System.Windows.Forms.Label lblVAge;
        private System.Windows.Forms.Button btnAddVisitor;
        private System.Windows.Forms.Label lblVLName;
        private System.Windows.Forms.ListBox lstbxReport;
        private System.Windows.Forms.Button btnTotalCost;
        private System.Windows.Forms.Button btnNumTickets;
    }
}