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
        int animalId;

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

        private void sql_AddAnimal()
        {
            cAnimals animalClass = new cAnimals();
            sql_showComponents(animalClass.addAnimal());
            conn.Open();
            adapter.InsertCommand = command;
            command.ExecuteNonQuery();
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
                        lblADOB.Visible = true;
                        lblGender.Visible = true;
                        lblWeight.Visible = true;
                        lblVaccStatus.Visible = true;

                        txtAName.Visible = true;
                        nudADay.Visible = true;
                        pnlAGender.Visible = true;
                        rdbMale.Visible = true;
                        rdbFemale.Visible = true;
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
                        lblADOB.Visible = true;
                        lblGender.Visible = true;
                        lblWeight.Visible = true;
                        lblVaccStatus.Visible = true;

                        txtAName.Visible = true;
                        nudADay.Visible = true;
                        pnlAGender.Visible = true;
                        rdbMale.Visible = true;
                        rdbFemale.Visible = true;
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
                        lblADOB.Visible = false;
                        lblGender.Visible = false;
                        lblWeight.Visible = false;
                        lblVaccStatus.Visible = false;

                        txtAName.Visible = false;
                        nudADay.Visible = false;
                        pnlAGender.Visible = false;
                        rdbMale.Visible = false;
                        rdbFemale.Visible = false;
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
                        //sql = "SELECT * FROM ANIMALS";      //INSERT
                        cAnimals animalClass = new cAnimals();

                        ///////////////////////////////////////////////////////////////
                        animalClass.setName(txtAName.Text);
                        //Do date of birth//----------------------------------------------------------------
                        animalClass.setDateOfBirth((int)(nudADay.Value), (int)(nudAMonth.Value), (int)nudAYear.Value);
                        //----------------------------------------------------------------------------------
                        if (rdbMale.Checked)
                        {
                            animalClass.setGender(rdbMale.Text);
                        }
                        else if (rdbFemale.Checked)
                        {
                            animalClass.setGender(rdbFemale.Text);
                        }
                        //else dont proceed
                        animalClass.setWeight(float.Parse(txtWeight.Text));
                        if (rdbTrue.Checked)
                        {
                            animalClass.setVacc(rdbTrue.Text);
                        }
                        else if (rdbFalse.Checked)
                        {
                            animalClass.setVacc(rdbFalse.Text);
                        }
                        ///////////////////////////////////////////////////////////////
                        
                        sql_AddAnimal();
                        conn.Close();

                        conn.Open();
                        sql_showAnimals();
                        conn.Close();
                        break;
                    }
                case 1:                     //Updates Animal
                    {
                        sql = "UPDATE FROM ANIMALS";

                        cAnimals animalClass = new cAnimals();

                        ///////////////////////////////////////////////////////////////
                        animalId = int.Parse(cbxChooseAction.SelectedItem.ToString());
                        animalClass.setName(txtAName.Text);
                        string dateOfBirthString = nudADay.Value.ToString() + nudAMonth.Value.ToString() + nudAYear.Value.ToString();
                        DateTime dob = DateTime.Parse(dateOfBirthString);
                        animalClass.setDateOfBirth((int)nudADay.Value, (int)nudAMonth.Value, (int)nudAYear.Value);
                        //Do date of birth//----------------------------------------------------------------
                        if (rdbMale.Checked)
                        {
                            animalClass.setGender(rdbMale.Text);
                        }
                        else if (rdbFemale.Checked)
                        {
                            animalClass.setGender(rdbFemale.Text);
                        }
                        //else dont proceed
                        animalClass.setWeight(float.Parse(txtWeight.Text));
                        if (rdbTrue.Checked)
                        {
                            animalClass.setVacc(rdbTrue.Text);
                        }
                        else if (rdbFalse.Checked)
                        {
                            animalClass.setVacc(rdbFalse.Text);
                        }
                        ///////////////////////////////////////////////////////////////
                        //animalClass.changeAnimalDetail(animalId);
                        break;
                    }
                case 2:                     //Remove animal
                    {
                       
                        break;
                    }
                default:
                    {
                        break;
                    }

            }
        }

        private void btnVisitorAction_Click(object sender, EventArgs e)
        {
            string sql;

            cPerson personClass = new cPerson();
            personClass.setName(txtVName.Text);
            personClass.setSurname(txtVLName.Text);
            personClass.setContactNum(txtContactNumber.Text);

            lstbxVisitorLog.Items.Add(personClass.getName());
            lstbxVisitorLog.Items.Add(personClass.getSurname());
            lstbxVisitorLog.Items.Add(personClass.getContactNum());

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

        private void AdminForm_Load(object sender, EventArgs e)
        {
            sql_showAnimals();
            sql_showVisitors();
            lblID.Visible = false;
            cbxID.Visible = false;

            lblAName.Visible = false;
            lblADOB.Visible = false;
            lblGender.Visible = false;
            lblWeight.Visible = false;
            lblVaccStatus.Visible = false;

            txtAName.Visible = false;
            nudADay.Visible = false;
            pnlAGender.Visible = false;
            rdbMale.Visible = false;
            rdbFemale.Visible = false;
            txtWeight.Visible = false;
            lblVaccStatus.Visible = false;
            pnlYesNo.Visible = false;
        }

        private void tpAnimals_Click(object sender, EventArgs e)
        {
            cbxChooseAction.SelectedIndex = -1;
        }

    }
}
