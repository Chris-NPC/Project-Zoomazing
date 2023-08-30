using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMPG223_Group22_Project
{
    class cPerson
    {
        //public string name { get; }
        //public string surname { }
        //public string contactNumber { }

        public string name;
        public string surname;
        public string contactNum;

        public string getName()
        {
            return name;
        }

        public string getSurname()
        {
            return surname;
        }

        public string getContactNum()
        {
            return contactNum;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public void setSurname(string surname)
        {
            this.surname = surname;
        }

        public void setContactNum(string contactNum)
        {
            this.contactNum = contactNum;
        }

        public void changePersonDetals()
        {

        }

        public void addPerson()
        {

        }

        public void deletePerson()
        {

        }

    }
}
