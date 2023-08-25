using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMPG223_Group22_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            AdminForm frmAdmin = new AdminForm();

            frmAdmin.Show();
        }

        //===============================================
        //Use camelCase for variables            |
        //CAPITAL LETTERS FOR CONSTANTS          |
        //snake_case_for_tables_to_be_used       |
        //===============================================
    }
}
