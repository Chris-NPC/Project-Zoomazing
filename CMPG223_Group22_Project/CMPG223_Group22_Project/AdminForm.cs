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
        string animalId;
        int receive_id; //read visitor and or animal id?
        cVisitors cAddV = new cVisitors();
        cVisitors cUpdateV = new cVisitors();
        cAnimals cAddA = new cAnimals();
        cAnimals cUpdateA = new cAnimals();

        /// ----------------------------------------------------------------------------
        private void show_animal_components()
        {
            lblAName.Visible = true;
            lblADOB.Visible = true;
            lblAGap1.Visible = true;
            lblAGap2.Visible = true;
            lblGender.Visible = true;
            lblWeight.Visible = true;
            lblVaccStatus.Visible = true;

            txtAName.Visible = true;
            nudADay.Visible = true;
            nudAMonth.Visible = true;
            nudAYear.Visible = true;
            pnlAGender.Visible = true;
            rdbMale.Visible = true;
            rdbFemale.Visible = true;
            txtWeight.Visible = true;
            pnlYesNo.Visible = true;

            txtAName.Text = "";
            nudADay.Value = 1;
            nudAMonth.Value = 1;
            nudAYear.Value = 1900;
            rdbMale.Checked = false;
            rdbFemale.Checked = false;
            txtWeight.Text = "";
            rdbTrue.Checked = false;
            rdbFalse.Checked = false;
        }
        private void hide_animal_components()
        {
            lblAName.Visible = false;
            lblADOB.Visible = false;
            lblAGap1.Visible = false;
            lblAGap2.Visible = false;
            lblGender.Visible = false;
            lblWeight.Visible = false;
            lblVaccStatus.Visible = false;

            txtAName.Visible = false;
            nudADay.Visible = false;
            nudAMonth.Visible = false;
            nudAYear.Visible = false;
            pnlAGender.Visible = false;
            rdbMale.Visible = false;
            rdbFemale.Visible = false;
            txtWeight.Visible = false;
            pnlYesNo.Visible = false;
        }
        private void show_visitor_components()
        {
            lblVFName.Visible = true;
            lblVLName.Visible = true;
            lblVDob.Visible = true;
            lblContactNumber.Visible = true;
            lblVGap1.Visible = true;
            lblVGap2.Visible = true;

            txtVName.Visible = true;
            txtVLName.Visible = true;
            nudVDay.Visible = true;
            nudVMonth.Visible = true;
            nudVYear.Visible = true;
            txtContactNumber.Visible = true;

            txtVName.Text = "";
            txtVLName.Text = "";
            nudVDay.Value = 1;
            nudVMonth.Value = 1;
            nudVYear.Value = 1900;
            txtContactNumber.Text = "";
        }
        private void hide_visitor_components()
        {
            lblVFName.Visible = false;
            lblVLName.Visible = false;
            lblVDob.Visible = false;
            lblContactNumber.Visible = false;
            lblVGap1.Visible = false;
            lblVGap2.Visible = false;

            txtVName.Visible = false;
            txtVLName.Visible = false;
            nudVDay.Visible = false;
            nudVMonth.Visible = false;
            nudVYear.Visible = false;
            txtContactNumber.Visible = false;
        }
        /// -------------------------------------------------------------------------------

        private void sql_showComponents(string sql)
        {
            conn = new SqlConnection(connString);
            command = new SqlCommand(sql, conn);
            adapter = new SqlDataAdapter();
            ds = new DataSet();
        }

        private int read_animal_id()
        {
            string sql_id = "SELECT Animal_Id FROM ANIMALS";
            sql_showComponents(sql_id);
            conn.Open();
            adapter.SelectCommand = command;
            adapter.Fill(ds, "ANIMALS");
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                receive_id = reader.GetInt32(0);
            }

            conn.Close();
            return receive_id;
        }
        private int read_visitor_id()
        {
            string sql_id = "SELECT Visitors_Id FROM VISITORS";
            sql_showComponents(sql_id);
            conn.Open();
            adapter.SelectCommand = command;
            adapter.Fill(ds, "VISITORS");
            reader = command.ExecuteReader();

            while(reader.Read())
            {
                receive_id = reader.GetInt32(0);
            }

            conn.Close();
            return receive_id;
        }

        private void pop_Acbx()
        {
            string sql_pop = "SELECT Animal_Id FROM ANIMALS";
            sql_showComponents(sql_pop);

            conn.Open();

            adapter.SelectCommand = command;
            adapter.Fill(ds, "ANIMALS");

            cbxVId.DataSource = ds.Tables["ANIMALS"];
            cbxVId.DisplayMember = "Animal_Id";
            cbxVId.ValueMember = "Animal_Id";
        }
        private void pop_Vcbx()
        {
            string sql_pop = "SELECT Visitors_Id FROM VISITORS";
            sql_showComponents(sql_pop);

            conn.Open();

            adapter.SelectCommand = command;
            adapter.Fill(ds, "VISITORS");

            cbxVId.DataSource = ds.Tables["VISITORS"];
            cbxVId.DisplayMember = "Visitors_Id";
            cbxVId.ValueMember = "Visitors_Id";
        }


        private void sql_showAnimals()
        {
            string sql = "SELECT * FROM ANIMALS";
            sql_showComponents(sql);
            conn.Open();
            adapter.SelectCommand = command;
            adapter.Fill(ds,"ANIMALS");

            dgvShowAnimals.DataSource = ds;
            dgvShowAnimals.DataMember = "ANIMALS";
        }
        private void sql_AddAnimal(string name, string gender, float weight, string vacc, int day, int month, int year)
        {
            sql_showComponents(cAddA.addAnimal(read_animal_id(), name, gender, weight, vacc, day, month, year));
            
            conn.Open();
            adapter.InsertCommand = command;
            command.ExecuteNonQuery();
        }
        private void sql_UpdateAnimal(string animalId, string name, string gender, float weight, string vacc, int day, int month, int year)
        {
            cAnimals animalClass = new cAnimals();
            sql_showComponents(animalClass.changeAnimalDetail(animalId, name, gender, weight, vacc, day, month, year));
            conn.Open();
            adapter.UpdateCommand = command;
            command.ExecuteNonQuery();
        }
        private void sql_DeleteAnimal(string animalId)
        {
            cAnimals animalClass = new cAnimals();
            sql_showComponents(animalClass.deleteAnimal(animalId));
            conn.Open();
            adapter.DeleteCommand = command;
            adapter.DeleteCommand.ExecuteNonQuery();
        }


        private void sql_showVisitors()
        {
            string sql = "SELECT * FROM VISITORS";
            sql_showComponents(sql);
            conn.Open();
            adapter.SelectCommand = command;
            adapter.Fill(ds, "VISITORS");

            dgvShowVisitors.DataSource = ds;
            dgvShowVisitors.DataMember = "VISITORS";
        }
        private void sql_AddVisitor(string surname, string name, string contactNum, int day, int month, int year)
        {
            sql_showComponents(cAddV.newVisitor(read_visitor_id(), surname, name, contactNum, day, month, year));      //receives sql to add visitor
           
            //MessageBox.Show(cMainV.newVisitor(read_visitor_id(), surname, name, contactNum));
            conn.Open();
            adapter.InsertCommand = command;
            command.ExecuteNonQuery();

        }
        private void sql_UpdateVisitor(string visitorId, string surname, string name, string contactNum, int day, int month, int year)
        {
            sql_showComponents(cUpdateV.changeVisitorDetail(visitorId, surname, name, contactNum, day, month, year));
            conn.Open();
            adapter.UpdateCommand = command;
            adapter.UpdateCommand.ExecuteNonQuery();
        }
        private void sql_DeleteVisitor(string visitorId)
        {
            cVisitors visitorClass = new cVisitors();
            sql_showComponents(visitorClass.deleteVisitor(visitorId));
            conn.Open();
            adapter.DeleteCommand = command;
            adapter.DeleteCommand.ExecuteNonQuery();
        }


        private void cbxAChooseAction_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbxAChooseAction.SelectedIndex)
            {
                case 0:             //Adds animal
                    {
                        lblAID.Visible = false;
                        cbxAId.Visible = false;
                        show_animal_components();

                        btnAnimalAction.Text = "Add Animal";
                        break;
                    }
                case 1:             //Updates Animal
                    {
                        lblAID.Visible = true;
                        cbxAId.Visible = true;
                        show_animal_components();

                        btnAnimalAction.Text = "Update Animal Details";
                        break;
                    }
                case 2:             //Deletes Animal
                    {
                        lblAID.Visible = true;
                        cbxAId.Visible = true;
                        hide_animal_components();

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
            //Put declarations and assignings here
            switch (cbxAChooseAction.SelectedIndex)
            {
                case 0:                     //Adds animal
                    {
                        string gender = "Neutral", vacci = "False";
                        if (rdbMale.Checked)
                        {
                            gender = rdbMale.Text;
                        }
                        else if (rdbFemale.Checked)
                        {
                            gender = rdbFemale.Text;
                        }

                        if (rdbTrue.Checked)
                        {
                            vacci = rdbTrue.Text;
                        }
                        else if (rdbFalse.Checked)
                        {
                            vacci = rdbFalse.Text;
                        }


                        sql_AddAnimal(txtAName.Text, gender, float.Parse(txtWeight.Text), vacci, (int)nudADay.Value, (int)nudAMonth.Value, (int)nudAYear.Value);
                        conn.Close();

                        //conn.Open();
                        sql_showAnimals();
                        pop_Acbx();
                        conn.Close();
                        break;
                    }
                case 1:                     //Updates Animal
                    {
                        string animalId = cbxAId.Text;
                        string gender = "Neutral", vacci = "False";
                        if (rdbMale.Checked)
                        {
                            gender = rdbMale.Text;
                        }
                        else if (rdbFemale.Checked)
                        {
                            gender = rdbFemale.Text;
                        }

                        if (rdbTrue.Checked)
                        {
                            vacci = rdbTrue.Text;
                        }
                        else if (rdbFalse.Checked)
                        {
                            vacci = rdbFalse.Text;
                        }


                        sql_UpdateAnimal(animalId, txtAName.Text, gender, float.Parse(txtWeight.Text), vacci, (int)nudADay.Value, (int)nudAMonth.Value, (int)nudAYear.Value);
                        conn.Close();

                        //conn.Open();
                        sql_showAnimals();
                        pop_Acbx();
                        conn.Close();
                        break;
                    }
                case 2:                     //Remove animal
                    {
                        string animalId = cbxAId.Text;
                        sql_DeleteAnimal(animalId);
                        conn.Close();

                        //conn.Open();
                        sql_showAnimals();
                        pop_Acbx();
                        conn.Close();
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

            switch (cbxVChooseAction.SelectedIndex)
            {
                case 0:                     //Adds Visitor      //WORKS//
                    {
                        sql_AddVisitor(txtVName.Text, txtVLName.Text, txtContactNumber.Text, (int)nudVDay.Value, (int)nudVMonth.Value, (int)nudVYear.Value);
                        conn.Close();

                        //conn.Open();
                        sql_showVisitors();
                        pop_Vcbx();
                        conn.Close();
                        break;
                    }
                case 1:                     //Updates Visitor   //WORKS//       
                    {
                        string visitorId = cbxVId.Text;

                        sql_UpdateVisitor(visitorId, txtVLName.Text, txtVName.Text, txtContactNumber.Text, (int)nudVDay.Value, (int)nudVMonth.Value, (int)nudVYear.Value);
                        conn.Close();

                        //conn.Open();
                        sql_showVisitors();
                        pop_Vcbx();
                        conn.Close();

                        break;
                    }
                case 2:                     //Removes Visitor   //WORKS//
                    {
                        string visitorId = cbxVId.Text;
                        sql_DeleteVisitor(visitorId);
                        conn.Close();

                        //conn.Open();
                        sql_showVisitors();
                        pop_Vcbx();
                        conn.Close();
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
            lblAID.Visible = false;
            cbxAId.Visible = false;
            sql_showAnimals();
            hide_animal_components();

            lblVID.Visible = false;
            cbxVId.Visible = false;
            sql_showVisitors();
            hide_visitor_components();
        }

        private void tpAnimals_Click(object sender, EventArgs e)
        {
            cbxAChooseAction.SelectedIndex = -1;
        }

        private void cbxVChooseAction_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbxVChooseAction.SelectedIndex)
            {
                case 0:                     //Adds Visitor
                    {
                        lblVID.Visible = false;
                        cbxVId.Visible = false;
                        show_visitor_components();

                        btnVisitorAction.Text = "Add Visitor";
                        break;
                    }
                case 1:                     //Updates Visitor
                    {
                        pop_Vcbx();
                        lblVID.Visible = true;
                        cbxVId.Visible = true;
                        show_visitor_components();

                        btnVisitorAction.Text = "Update Visitor Details";
                        break;
                    }
                case 2:                     //Remove Visitor
                    {
                        pop_Vcbx();
                        lblVID.Visible = true;
                        cbxVId.Visible = true;
                        hide_visitor_components();

                        btnVisitorAction.Text = "Delete Visitor";
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
