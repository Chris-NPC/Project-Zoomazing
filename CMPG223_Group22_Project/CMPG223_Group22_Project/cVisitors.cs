using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMPG223_Group22_Project
{
    class cVisitors
    {
        public string dateOfBirth;

        public string getDateOfBirth()
        {
            return dateOfBirth;
        }

        public void setDateOfBirth(int day, int month, int year)
        {
            string vDob = year.ToString() +"/"+ month.ToString() +"/" + day.ToString();

            dateOfBirth = vDob;
        }

        public bool haveExited()
        {
            return false;
        }

        public bool haveEntered()
        {
            return false;
        }

        public string newVisitor()
        {
            cPerson vPerson = new cPerson();
            string sql = $"INSERT INTO VISITORS VALUES('{vPerson.getSurname()}', '{vPerson.getName()}', '{getDateOfBirth()}', '{vPerson.getContactNum()}')";

            return sql;
        }

        public string changeVisitorDetail(int visitorId)
        {
            cPerson vPerson = new cPerson();
            string sql = $"UPDATE VISITORS SET Visitors_LName = {vPerson.getSurname()}, Visitors_Name = {vPerson.getName()}, Date_Of_Birth = {getDateOfBirth()}, ContactNumber = {vPerson.getContactNum()} WHERE VisitorsID = {visitorId}";

            return sql;
        }


        public string deleteVisitor(int visitorId)
        {
            string sql = $"DELETE FROM VISITORS WHERE Visitors_ID = {visitorId}";

            return sql;
        }
    }
}
