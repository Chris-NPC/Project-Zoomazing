using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMPG223_Group22_Project
{
    class cEmployees
    {
        public string username;
        public string password;
        public string employeeType;

        public string getUsername()
        {
            return username;
        }

        public string getPassword()
        {
            return password;
        }

        public void setUsername(string userName)
        {
            this.username = userName;
        }

        public void setPassword(string password)
        {
            this.password = password;
        }

        public void isAdmin(string empType)
        {
            if (empType == "Admin")
            {
                employeeType = "Administrator";
            }
            else
            {
                employeeType = "Employee";
            }
        }   //tells if admin or not

        ///
        public bool loggedIn(bool entered)
        {
            if (entered == true)
            {
                return true;
            }
            return false;
        }
        public bool loggedOut(bool entered)
        {
            if (entered == false)
            {
                return true;
            }
            return false;
        }
        ///

        public string addEmployee(int employeeId, string surname, string name, string contactNum, string username, string password, string empType)
        {
            
            cPerson ePerson = new cPerson();
            ePerson.setSurname(surname);
            ePerson.setName(name);
            ePerson.setContactNum(contactNum);
            setUsername(username);
            setPassword(password);
            isAdmin(empType);

            string sql = $"INSERT INTO Users VALUES({employeeId+1}, '{surname}', '{name}', '{contactNum}', '{username}', '{password}' ,'{empType}')";
            //string sql = "";
            return sql;
        }

        public string changeEmployeeDetails(string employeeId, string surname, string name, string contactNum, string username, string password, string empType)
        {
            cPerson ePerson = new cPerson();
            ePerson.setSurname(surname);
            ePerson.setName(name);
            ePerson.setContactNum(contactNum);
            setUsername(username);
            setPassword(password);
            isAdmin(empType);

            string sql = $"UPDATE Users SET Last_Name = '{surname}', Name = '{name}', ContactNumber = '{contactNum}', Username = '{username}', Password = '{password}', EmployeeType = '{empType}' WHERE Id = '{employeeId}'";

            return sql;
        }

        public string deleteEmployee(string employeeId)
        {
            string sql = $"DELETE FROM Users WHERE Id = '{employeeId}'";

            return sql;
        }

    }
}
