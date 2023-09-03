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

        /// <summary>
        /// SQL components and relevant classes to access and work with databases, connection string also declared
        /// </summary>
        string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\chris\OneDrive\Documents\CMPG 223 - Project\Zoomazing Demo\Project-Zoomazing\CMPG223_Group22_Project\CMPG223_Group22_Project\Database1.mdf;Integrated Security=True";
        SqlConnection conn;
        SqlCommand command;
        DataSet ds;
        SqlDataAdapter adapter;
        SqlDataReader reader;

        /// <summary>
        /// variable and classes declared for use in this form's coding
        /// </summary>
        int receive_id;
        //cAnimals cAddA = new cAnimals();
        //cAnimals cUpdateA = new cAnimals();
        //cVisitors cAddV = new cVisitors();
        //cVisitors cUpdateV = new cVisitors();
        //cEmployees cAddE = new cEmployees();
        //cEmployees cUpdateE = new cEmployees();


        /// <summary>
        /// Resets the relevant components and shows relevant components when called.
        /// </summary>
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
        private void show_employee_components()
        {
            lblEFName.Visible = true;
            lblELName.Visible = true;
            lblEContactNumber.Visible = true;
            lblUsername.Visible = true;
            lblPassword.Visible = true;
            lblEmpType.Visible = true;

            txtEName.Visible = true;
            txtELName.Visible = true;
            txtEContactNumber.Visible = true;
            txtUsername.Visible = true;
            txtPassword.Visible = true;
            cbxEmpType.Visible = true;

            txtEName.Text = "";
            txtELName.Text = "";
            txtEContactNumber.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
            cbxEmpType.SelectedIndex = -1;
        }


        /// <summary>
        /// Hides relevant(unnecessary) components when called
        /// </summary>
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
        private void hide_employee_components()
        {
            lblEFName.Visible = false;
            lblELName.Visible = false;
            lblEContactNumber.Visible = false;
            lblUsername.Visible = false;
            lblPassword.Visible = false;
            lblEmpType.Visible = false;

            txtEName.Visible = false;
            txtELName.Visible = false;
            txtEContactNumber.Visible = false;
            txtUsername.Visible = false;
            txtPassword.Visible = false;
            cbxEmpType.Visible = false;
        }


        /// <summary>
        /// Creates new SQL components when called with an sql statement as parameter to use the command component with
        /// </summary>
        /// <param name="sql"></param>
        private void sql_showComponents(string sql)
        {
            conn = new SqlConnection(connString);
            command = new SqlCommand(sql, conn);
            adapter = new SqlDataAdapter();
            ds = new DataSet();
        }


        /// <summary>
        /// (for procedures "read_animal_id()" and "read_visitor_id()")
        /// (Used for the insert statement [to ensure [sequential addition?]])
        /// The SELECT SQL statement is declared using the received id [from the relevant database].
        /// The statement is then executed and read from the database.
        /// The id read, is then returned.
        /// </summary>
        /// <returns></returns>
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
        private int read_employee_id()
        {
            string sql_id = "SELECT Id FROM Users";
            sql_showComponents(sql_id);
            conn.Open();
            adapter.SelectCommand = command;
            adapter.Fill(ds, "Users");
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                receive_id = reader.GetInt32(0);
            }

            conn.Close();
            return receive_id;
        }


        /// <summary>
        /// (for procedures "pop_Acbx" and "pop_Vcbx")
        /// SELECT SQL statement is declared with id field of relevant database to update relevant comboBoxes.
        /// This statment is then put into the "sql_showComponents()" procedure to initiate the relevant SQL components and create the correct demand.
        /// A comboBox is then populated with the records' id's for updating/ deleting records
        /// </summary>
        private void pop_Acbx()
        {
            string sql_pop = "SELECT Animal_Id FROM ANIMALS";
            sql_showComponents(sql_pop);

            conn.Open();

            adapter.SelectCommand = command;
            adapter.Fill(ds, "ANIMALS");

            cbxAId.DataSource = ds.Tables["ANIMALS"];
            cbxAId.DisplayMember = "Animal_Id";
            cbxAId.ValueMember = "Animal_Id";
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
        private void pop_Ecbx()
        {
            string sql_pop = "SELECT Id FROM Users";
            sql_showComponents(sql_pop);

            conn.Open();

            adapter.SelectCommand = command;
            adapter.Fill(ds, "Users");

            cbxEId.DataSource = ds.Tables["Users"];
            cbxEId.DisplayMember = "Id";
            cbxEId.ValueMember = "Id";
        }


        /// <summary>
        /// (For procedures "sql_showAnimals()" and "sql_showVisitors" and "sql_showEmployees")
        /// SELECT SQL statement declared to select all the records from the relevant database to show the database to the user through the 'dataGridView' component.
        /// Also called after a new record has been inserted, record updated or record deleted.
        /// </summary>
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
        private void sql_showEmployees()
        {
            string sql = "SELECT * FROM Users";
            sql_showComponents(sql);
            conn.Open();
            adapter.SelectCommand = command;
            adapter.Fill(ds, "Users");

            dgvShowEmployees.DataSource = ds;
            dgvShowEmployees.DataMember = "Users";
        }


        /// <summary>
        /// Procedure to add an animal to the database(ANIMALS) and takes all the data/ values needed, as parameters.
        /// "sql_showComponents()" takes an sql statement as a parameter, thus the animal class with an "addAnimal" procedure is called because it returns an SQL statement with values received.
        /// The command is then executed and a new animal is added to the database.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="gender"></param>
        /// <param name="weight"></param>
        /// <param name="vacc"></param>
        /// <param name="day"></param>
        /// <param name="month"></param>
        /// <param name="year"></param>
        private void sql_AddAnimal(string name, string gender, decimal weight, string vacc, int day, int month, int year)
        {
            cAnimals cAddA = new cAnimals();
            sql_showComponents(cAddA.addAnimal(read_animal_id(), name, gender, weight, vacc, day, month, year));
            
            conn.Open();
            adapter.InsertCommand = command;
            adapter.InsertCommand.ExecuteNonQuery();
        }

        /// <summary>
        /// Procedure to update an animal to the database(ANIMALS) and takes all the data/ values needed, as parameters.
        /// "sql_showComponents()" takes an sql statement as a parameter, thus the animal class with an "changeAnimalDetail" procedure is called because it returns an SQL statement with values received.
        /// The command is then executed and an animal's details are updated and posted on the database.
        /// </summary>
        /// <param name="animalId"></param>
        /// <param name="name"></param>
        /// <param name="gender"></param>
        /// <param name="weight"></param>
        /// <param name="vacc"></param>
        /// <param name="day"></param>
        /// <param name="month"></param>
        /// <param name="year"></param>
        private void sql_UpdateAnimal(string animalId, string name, string gender, decimal weight, string vacc, int day, int month, int year)
        {
            cAnimals cUpdateA = new cAnimals();
            sql_showComponents(cUpdateA.changeAnimalDetail(animalId, name, gender, weight, vacc, day, month, year));

            conn.Open();
            adapter.UpdateCommand = command;
            adapter.UpdateCommand.ExecuteNonQuery();
        }

        /// <summary>
        /// Procedure to delete an animal from the database(ANIMALS) and takes all the data/ values needed, as parameters.
        /// "sql_showComponents()" takes an sql statement as a parameter, thus the animal class with an "deleteAnimal" procedure is called because it returns an SQL statement with values received.
        /// The command is then executed and an animal is deleted from the database.
        /// </summary>
        /// <param name="animalId"></param>
        private void sql_DeleteAnimal(string animalId)
        {
            cAnimals cDeleteA = new cAnimals();
            sql_showComponents(cDeleteA.deleteAnimal(animalId));
            conn.Open();
            adapter.DeleteCommand = command;
            adapter.DeleteCommand.ExecuteNonQuery();
        }



        /// <summary>
        /// Procedure to add a Visitor to the database(VISITORS) and takes all the data/ values needed, as parameters.
        /// "sql_showComponents()" takes an sql statement as a parameter, thus the visitor class with an "newVisitor" procedure is called because it returns an SQL statement with values received.
        /// The command is then executed and a new visitor is added to the database.
        /// </summary>
        /// <param name="surname"></param>
        /// <param name="name"></param>
        /// <param name="contactNum"></param>
        /// <param name="day"></param>
        /// <param name="month"></param>
        /// <param name="year"></param>
        private void sql_AddVisitor(string surname, string name, string contactNum, int day, int month, int year)
        {
            cVisitors cAddV = new cVisitors();
            sql_showComponents(cAddV.newVisitor(read_visitor_id(), surname, name, contactNum, day, month, year));      
           
            conn.Open();
            adapter.InsertCommand = command;
            adapter.InsertCommand.ExecuteNonQuery();
        }

        /// <summary>
        /// Procedure to update a visitor to the database(VISITORS) and takes all the data/ values needed, as parameters.
        /// "sql_showComponents()" takes an sql statement as a parameter, thus the visitor class with an "changeVisitorDetail" procedure is called because it returns an SQL statement with values received.
        /// The command is then executed and a visitor's details are updated and posted on the database.
        /// </summary>
        /// <param name="visitorId"></param>
        /// <param name="surname"></param>
        /// <param name="name"></param>
        /// <param name="contactNum"></param>
        /// <param name="day"></param>
        /// <param name="month"></param>
        /// <param name="year"></param>
        private void sql_UpdateVisitor(string visitorId, string surname, string name, string contactNum, int day, int month, int year)
        {
            cVisitors cUpdateV = new cVisitors();
            sql_showComponents(cUpdateV.changeVisitorDetail(visitorId, surname, name, contactNum, day, month, year));

            conn.Open();
            adapter.UpdateCommand = command;
            adapter.UpdateCommand.ExecuteNonQuery();
        }

        /// <summary>
        /// Procedure to delete a visitor from the database(VISITORS) and takes all the data/ values needed, as parameters.
        /// "sql_showComponents()" takes an sql statement as a parameter, thus the visitor class with an "deleteVisitor" procedure is called because it returns an SQL statement with values received.
        /// The command is then executed and a visitor is deleted from the database.
        /// </summary>
        /// <param name="visitorId"></param>
        private void sql_DeleteVisitor(string visitorId)
        {
            cVisitors cDeleteV = new cVisitors();
            sql_showComponents(cDeleteV.deleteVisitor(visitorId));

            conn.Open();
            adapter.DeleteCommand = command;
            adapter.DeleteCommand.ExecuteNonQuery();
        }


        private void sql_AddEmployee(string surname, string name, string contactNum, string username, string password, string empType)
        {
            cEmployees cAddE = new cEmployees();
            sql_showComponents(cAddE.addEmployee(read_employee_id(), surname, name, contactNum, username, password, empType));//empType

            conn.Open();
            adapter.InsertCommand = command;
            adapter.InsertCommand.ExecuteNonQuery();
        }
        private void sql_UpdateEmployee(string employeeId, string surname, string name, string contactNum, string username, string password, string empType)
        {
            cEmployees cUpdateE = new cEmployees();
            sql_showComponents(cUpdateE.changeEmployeeDetails(employeeId, surname, name, contactNum, username, password, empType));//empType

            conn.Open();
            adapter.UpdateCommand = command;
            adapter.UpdateCommand.ExecuteNonQuery();
        }
        private void sql_DeleteEmployee(string employeeId)
        {
            cEmployees cDeleteE = new cEmployees();
            sql_showComponents(cDeleteE.deleteEmployee(employeeId));//empType

            conn.Open();
            adapter.DeleteCommand = command;
            adapter.DeleteCommand.ExecuteNonQuery();
        }



        /// <summary>
        /// (Same for "cbxAChooseAction_SelectedIndexChanged" and "bxVChooseAction_SelectedIndexChanged" with exceptions being animal = visitor in terminolgy sense)
        /// The actions that will occur when the index changes of the comboBox (comboBox asking what action would be taken), includes:
        /// ** A switch statement containing what would happen when a certain index is chosen:
        ///     * if 0 is chosen(which is for adding the animal): 
        ///         ~ The label and comboBox for ID, is hidden.
        ///         ~ "show_animal_components()" called, shows relevant components.
        ///         ~ Button that would execute the SQL statements, is renamed for appropriate action. ("Add..." in this case).
        ///     * If 1 is chosen(which is for updating the animal): 
        ///         ~ The label and comboBox for ID, is shown.
        ///         ~ "show_animal_components()" called, shows relevant components.
        ///         ~ Button that would execute the SQL statements, is renamed for appropriate action. ("Update..." in this case).
        ///     * If 2 is chosen(which is for deleting the animal): 
        ///         ~ The label and comboBox for ID, is shown.
        ///         ~ "show_animal_components()" called, shows relevant components.
        ///         ~ Button that would execute the SQL statements, is renamed for appropriate action. ("Delete..." in this case).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxAChooseAction_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbxAChooseAction.SelectedIndex)
            {
                case 0:             //Adds animal
                    {
                        pop_Acbx();
                        lblAID.Visible = false;
                        cbxAId.Visible = false;
                        show_animal_components();

                        btnAnimalAction.Text = "Add Animal";
                        break;
                    }
                case 1:             //Updates Animal
                    {
                        pop_Acbx();
                        lblAID.Visible = true;
                        cbxAId.Visible = true;
                        show_animal_components();

                        btnAnimalAction.Text = "Update Animal Details";
                        break;
                    }
                case 2:             //Deletes Animal
                    {
                        pop_Acbx();
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
        private void cbxVChooseAction_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbxVChooseAction.SelectedIndex)
            {
                case 0:                     //Adds Visitor
                    {
                        pop_Vcbx();
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
                case 2:                     //Removes Visitor
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
        private void cbxEChooseAction_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbxEChooseAction.SelectedIndex)
            {
                case 0:                     //Adds Employee
                    {
                        pop_Ecbx();
                        lblEID.Visible = false;
                        cbxEId.Visible = false;
                        show_employee_components();

                        btnEmployeeAction.Text = "Add Employee";
                        break;
                    }
                case 1:                     //Updates Employee
                    {
                        pop_Ecbx();
                        lblEID.Visible = true;
                        cbxEId.Visible = true;
                        show_employee_components();

                        btnEmployeeAction.Text = "Update Employee Details";
                        break;
                    }
                case 2:                     //Removes Employee
                    {
                        pop_Ecbx();
                        lblEID.Visible = true;
                        cbxEId.Visible = true;
                        hide_employee_components();

                        btnEmployeeAction.Text = "Delete Employee";
                        break;
                    }
                default:
                    {
                        break;
                    }

            }
        }


        /// <summary>
        /// The actions that will occur when the index changes of the comboBox (comboBox asking what action would be taken) and "action" button being clicked, includes:
        /// ** A switch statement containing what would happen when a certain index is chosen:
        ///     * if 0 is chosen(which is for adding the animal): 
        ///         ~ gender and vaccination variable declared and initialized. Validation and declarations also occurs for them as they have binary('2') availabilties.
        ///         ~ "sql_AddAnimal" called to get the values needed for the SQL statement and thus would be executed when button is pressed(Add/Insert).
        ///         ~ Connection is then closed. The connection would open again to show database after updating ("refresh").
        ///     * If 1 is chosen(which is for updating the animal): 
        ///         ~ gender and vaccination variable declared and initialized. Validation and declarations also occurs for them as they have binary('2') availabilties.
        ///         ~ "sql_UpdateAnimal" called to get the values needed for the SQL statement and thus would be executed when button is pressed(Update).
        ///         ~ Connection is then closed. The connection would open again to populate the comboBox (containing id's) and show database after updating ("refresh").
        ///     * If 2 is chosen(which is for deleting the animal):
        ///         ~ Animal record Id chosen through comboBox (populated, as described earlier, with id's of the records) and declared into variable.
        ///         ~ Variable is then called in the "sql_DeleteAnimal" procedure to be used in SQL statement, it would then be executed as button is pressed (Delete)
        ///         ~ Connection is then closed. The connection would open again to populate the comboBox (containing id's) and show database after deleting ("refresh").
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAnimalAction_Click(object sender, EventArgs e)
        {
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

                        MessageBox.Show(txtWeight.Text);
                        MessageBox.Show((decimal.Parse(txtWeight.Text)).ToString());
                        sql_AddAnimal(txtAName.Text, gender, decimal.Parse(txtWeight.Text), vacci, (int)nudADay.Value, (int)nudAMonth.Value, (int)nudAYear.Value);
                        conn.Close();

                        sql_showAnimals();
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

                        sql_UpdateAnimal(animalId, txtAName.Text, gender, decimal.Parse(txtWeight.Text), vacci, (int)nudADay.Value, (int)nudAMonth.Value, (int)nudAYear.Value);
                        conn.Close();

                        sql_showAnimals();
                        conn.Close();

                        pop_Acbx();
                        conn.Close();
                        break;
                    }
                case 2:                     //Remove animal
                    {
                        string animalId = cbxAId.Text;

                        sql_DeleteAnimal(animalId);
                        conn.Close();

                        sql_showAnimals();
                        conn.Close();

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

        /// <summary>
        /// The actions that will occur when the index changes of the comboBox (comboBox asking what action would be taken) and "action" button being clicked, includes:
        /// ** A switch statement containing what would happen when a certain index is chosen:
        ///     * if 0 is chosen(which is for adding the visitor): 
        ///         ~ "sql_AddVisitor" called to get the values needed for the SQL statement and thus would be executed when button is pressed(Add/Insert).
        ///         ~ Connection is then closed. The connection would open again to show database after adding ("refresh").
        ///     * If 1 is chosen(which is for updating the visitor): 
        ///         ~ "sql_UpdateVisitor" called to get the values needed for the SQL statement and thus would be executed when button is pressed(Update).
        ///         ~ Connection is then closed. The connection would open again to populate the comboBox (containing id's) and show database after updating ("refresh").
        ///     * If 2 is chosen(which is for deleting the visitor):
        ///         ~ Visitor record Id chosen through comboBox (populated, as described earlier, with id's of the records) and declared into variable.
        ///         ~ "sql_DeleteVisitor" called to get the values needed for the SQL statement and thus would be executed when button is pressed(Delete).
        ///         ~ Connection is then closed. The connection would open again to populate the comboBox (containing id's) and show database after deleting ("refresh").
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVisitorAction_Click(object sender, EventArgs e)
        {
            switch (cbxVChooseAction.SelectedIndex)
            {
                case 0:                     //Adds Visitor      
                    {
                        sql_AddVisitor(txtVName.Text, txtVLName.Text, txtContactNumber.Text, (int)nudVDay.Value, (int)nudVMonth.Value, (int)nudVYear.Value);
                        conn.Close();

                        sql_showVisitors();
                        conn.Close();
                        break;
                    }
                case 1:                     //Updates Visitor         
                    {
                        string visitorId = cbxVId.Text;

                        sql_UpdateVisitor(visitorId, txtVLName.Text, txtVName.Text, txtContactNumber.Text, (int)nudVDay.Value, (int)nudVMonth.Value, (int)nudVYear.Value);
                        conn.Close();

                        sql_showVisitors();
                        conn.Close();

                        pop_Vcbx();
                        conn.Close();

                        break;
                    }
                case 2:                     //Removes Visitor  
                    {
                        string visitorId = cbxVId.Text;
                        sql_DeleteVisitor(visitorId);
                        conn.Close();

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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEmployeeAction_Click(object sender, EventArgs e)
        {
            switch (cbxEChooseAction.SelectedIndex)
            {
                case 0:                     //Adds Visitor      
                    {
                        string empType = cbxEmpType.Text;

                        sql_AddEmployee(txtEName.Text, txtELName.Text, txtEContactNumber.Text, txtUsername.Text, txtPassword.Text, empType); //empType?
                        conn.Close();

                        sql_showEmployees();
                        conn.Close();
                        break;
                    }
                case 1:                     //Updates Visitor         
                    {
                        string employeeId = cbxVId.Text;
                        string empType = cbxEmpType.Text;

                        sql_UpdateEmployee(employeeId, txtELName.Text, txtEName.Text, txtEContactNumber.Text, txtUsername.Text, txtPassword.Text, empType); //empType
                        conn.Close();

                        sql_showEmployees();
                        conn.Close();

                        pop_Ecbx();
                        conn.Close();

                        break;
                    }
                case 2:                     //Removes Visitor  
                    {
                        string employeeId = cbxEId.Text;

                        sql_DeleteEmployee(employeeId);
                        conn.Close();

                        sql_showEmployees();
                        conn.Close();

                        pop_Ecbx();
                        conn.Close();
                        break;
                    }
                default:
                    {
                        break;
                    }

            }
        }


        /// <summary>
        /// Initiates form by hiding almost all [but relevant] components.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

            lblEID.Visible = false;
            cbxEId.Visible = false;
            sql_showEmployees();
            hide_employee_components();
        }

    }
}
