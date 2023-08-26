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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void cbxChooseAction_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbxChooseAction.SelectedIndex)
            {
                case 0:             //Adds animal
                    {
                        lblID.Visible = false;
                        cbxID.Visible = false;

                        lblAName.Visible = true;
                        lblAAge.Visible = true;
                        lblGender.Visible = true;
                        lblWeight.Visible = true;
                        lblVaccStatus.Visible = true;

                        txtAName.Visible = true;
                        nudAAge.Visible = true;
                        cbxGender.Visible = true;
                        txtWeight.Visible = true;
                        lblVaccStatus.Visible = true;
                        pnlYesNo.Visible = true;

                        btnAnimalAction.Text = "Add Animal";
                        break;
                    }
                case 1:     //Updates Animal
                    {
                        lblID.Visible = true;
                        cbxID.Visible = true;

                        lblAName.Visible = true;
                        lblAAge.Visible = true;
                        lblGender.Visible = true;
                        lblWeight.Visible = true;
                        lblVaccStatus.Visible = true;

                        txtAName.Visible = true;
                        nudAAge.Visible = true;
                        cbxGender.Visible = true;
                        txtWeight.Visible = true;
                        lblVaccStatus.Visible = true;
                        pnlYesNo.Visible = true;

                        btnAnimalAction.Text = "Update Animal Details";
                        break;
                    }
                case 2:
                    {
                        lblID.Visible = true;
                        cbxID.Visible = true;

                        lblAName.Visible = false;
                        lblAAge.Visible = false;
                        lblGender.Visible = false;
                        lblWeight.Visible = false;
                        lblVaccStatus.Visible = false;

                        txtAName.Visible = false;
                        nudAAge.Visible = false;
                        cbxGender.Visible = false;
                        txtWeight.Visible = false;
                        lblVaccStatus.Visible = false;
                        pnlYesNo.Visible = false;

                        btnAnimalAction.Text = "Remove Animal";
                        break;
                    }
                default:
                    {
                        break;
                    }

            }
        }

        private void btnAnimalAction_Click(object sender, EventArgs e)
        {
            string sql;
            switch (cbxChooseAction.SelectedIndex)
            {
                case 0:                     //Adds animal
                    {
                        sql = "SELECT * FROM tbl... ";
                        break;
                    }
                case 1:                     //Updates Animal
                    {
                        sql = "UPDATE FROM tbl...";
                        break;
                    }
                case 2:                     //Remove animal
                    {
                        if (cbxID.SelectedIndex != null && cbxID.SelectedIndex.ToString() != null)  //?
                        {
                            sql = $"DELETE FROM tbl... WHERE {cbxID.SelectedItem.ToString()}";
                        }
                        break;
                    }
                default:
                    {
                        break;
                    }

            }
        }

    }
}
