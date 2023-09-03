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

        public void getUsername(string userName)
        {
            this.username = userName;
        }

        public void getPassword(string password)
        {
            this.password = password;
        }

        public string setUsername()
        {
            return username;
        }

        public string setPassword()
        {
            return password;
        }

        public bool isAdmin()
        {
            if ()
            {
                return true;
            }

            return false;
        }

        public bool loggedIn()
        {
            if ()
            {
                return true;
            }
            return false;
        }

        public bool loggedOut()
        {
            if ()
            {
                return true;
            }
            return false;
        }

        public void addEmployee()
        {

        }

        public void deleteEmployee()
        {

        }

        public void changeEmployeeDetails()
        {

        }
    }
}
