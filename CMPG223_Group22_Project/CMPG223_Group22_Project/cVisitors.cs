using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMPG223_Group22_Project
{
    class cVisitors
    {
        public DateTime dateOfBirth;

        public DateTime getDateOfBirth()
        {
            return dateOfBirth;
        }

        public void setDateOfBirth(int day, int month, int year)
        {
            string correctDay, correctMonth;

            if ((day < 10) && (day >= 1))
            {
                correctDay = "0" + day.ToString();
            }
            else
            {
                correctDay = day.ToString();
            }

            if ((month < 10) && (month >= 1))
            {
                correctMonth = "0" + month.ToString();
            }
            else
            {
                correctMonth = month.ToString();
            }
            string dateVar = year.ToString() + "/" + correctMonth + "/" + correctDay;
           
            DateTime dob = DateTime.ParseExact(dateVar, "yyyy/MM/dd", null);

            dateOfBirth = dob;
        }

        public bool haveExited()
        {
            return false;
        }

        public bool haveEntered()
        {
            return false;
        }

        public string newVisitor(int visitorId, string surname, string name, string contactNum, int day, int month, int year)
        {
            cPerson vPerson = new cPerson();
            vPerson.setSurname(surname);
            vPerson.setName(name);
            vPerson.setContactNum(contactNum);
            setDateOfBirth(day, month, year);
            string sql = $"INSERT INTO VISITORS VALUES({visitorId+1},'{vPerson.getSurname()}', '{vPerson.getName()}', '{getDateOfBirth()}', '{vPerson.getContactNum()}')";

            return sql;
        }

        public string changeVisitorDetail(string visitorId, string surname, string name, string contactNum, int day, int month, int year)
        {
            cPerson vPerson = new cPerson();
            vPerson.setSurname(surname);
            vPerson.setName(name);
            vPerson.setContactNum(contactNum);
            setDateOfBirth(day, month, year);

            string sql = $"UPDATE VISITORS SET Visitors_LName = '{vPerson.getSurname()}', Visitors_Name = '{vPerson.getName()}', Date_Of_Birth = '{getDateOfBirth()}', ContactNumber = '{vPerson.getContactNum()}' WHERE Visitors_ID = '{visitorId}'";

            return sql;
        }


        public string deleteVisitor(string visitorId)
        {
            string sql = $"DELETE FROM VISITORS WHERE Visitors_ID = '{visitorId}'";

            return sql;
        }
    }
}
