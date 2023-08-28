using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CMPG223_Group22_Project
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\chris\OneDrive\Documents\CMPG 223 - Project\Zoomazing Demo\Project-Zoomazing\CMPG223_Group22_Project\CMPG223_Group22_Project\Database1.mdf;Integrated Security=True";
        SqlConnection conn;
        SqlCommand command;
        DataSet ds;
        SqlDataAdapter adapter;
        SqlDataReader reader;

        private void sql_showComponents(string sql)
        {
            conn = new SqlConnection(connString);
            command = new SqlCommand(sql, conn);
            adapter = new SqlDataAdapter();
            ds = new DataSet();
        }

        private void sql_showAnimals()
        {
            string sql = "SELECT * FROM ANIMALS";
            sql_showComponents(sql);
            adapter.SelectCommand = command;
            adapter.Fill(ds,"ANIMALS");

            dgvShowAnimals.DataSource = ds;
            dgvShowAnimals.DataMember = "ANIMALS";
        }

        private void sql_showVisitors()
        {
            string sql = "SELECT * FROM VISITORS";
            sql_showComponents(sql);
            adapter.SelectCommand = command;
            adapter.Fill(ds, "VISITORS");

            dgvShowVisitors.DataSource = ds;
            dgvShowVisitors.DataMember = "VISITORS";
        }

        private void sql_add()
        {

        }
        private void sql_update()
        {

        }
        private void sql_delete()
        {

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
                        sql = "SELECT * FROM ANIMALS";
                        //sql_show(sql);
                        break;
                    }
                case 1:                     //Updates Animal
                    {
                        sql = "UPDATE FROM ANIMALS";
                        break;
                    }
                case 2:                     //Remove animal
                    {
                        if (cbxID.SelectedIndex != null && cbxID.SelectedIndex.ToString() != null)  //?
                        {
                            sql = $"DELETE FROM ANIMALS WHERE {cbxID.SelectedItem.ToString()}";
                        }
                        break;
                    }
                default:
                    {
                        break;
                    }

            }
        }

        private void btnAddVisitor_Click(object sender, EventArgs e)
        {
            string sql;
            switch (cbxChooseAction.SelectedIndex)
            {
                case 0:                     //Adds animal
                    {
                        sql = "SELECT * FROM VISITORS ";
                        break;
                    }
                case 1:                     //Updates Animal
                    {
                        sql = "UPDATE FROM VISITORS";
                        break;
                    }
                case 2:                     //Remove animal
                    {
                        if (cbxID.SelectedIndex != null && cbxID.SelectedIndex.ToString() != null)  //?
                        {
                            sql = $"DELETE FROM VISITORS";
                        }
                        break;
                    }
                default:
                    {
                        break;
                    }

            }
        }

        private void tpAnimals_Click(object sender, EventArgs e)
        {
            sql_showAnimals();
        }

        private void tcAdmin_Click(object sender, EventArgs e)
        {
            sql_showVisitors();
        }
    }
}
