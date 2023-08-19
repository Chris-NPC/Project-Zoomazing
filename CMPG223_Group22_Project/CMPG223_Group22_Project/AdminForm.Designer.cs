
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
            this.tpVisitors = new System.Windows.Forms.TabPage();
            this.tpReports = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tcAdmin.SuspendLayout();
            this.tpAnimals.SuspendLayout();
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
            this.tpAnimals.Controls.Add(this.button1);
            this.tpAnimals.Controls.Add(this.label1);
            this.tpAnimals.Controls.Add(this.label2);
            this.tpAnimals.Location = new System.Drawing.Point(4, 25);
            this.tpAnimals.Name = "tpAnimals";
            this.tpAnimals.Padding = new System.Windows.Forms.Padding(3);
            this.tpAnimals.Size = new System.Drawing.Size(1298, 688);
            this.tpAnimals.TabIndex = 0;
            this.tpAnimals.Text = "Animals";
            this.tpAnimals.UseVisualStyleBackColor = true;
            // 
            // tpVisitors
            // 
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
            this.tpReports.Location = new System.Drawing.Point(4, 25);
            this.tpReports.Name = "tpReports";
            this.tpReports.Size = new System.Drawing.Size(1298, 688);
            this.tpReports.TabIndex = 2;
            this.tpReports.Text = "Reports";
            this.tpReports.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "label2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(303, 594);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcAdmin;
        private System.Windows.Forms.TabPage tpAnimals;
        private System.Windows.Forms.TabPage tpVisitors;
        private System.Windows.Forms.TabPage tpReports;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}