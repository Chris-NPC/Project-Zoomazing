using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMPG223_Group22_Project
{
    class cAnimals
    {
        public string name;
        public string fullGender; //or char?
        public char gender;
        public float weight;
        public string vaccination;
        public bool isVacc;
        public DateTime dateOfBirth;

        public string getName()
        {
            return name;
        }

        public char getGender()
        {
            return gender;
        }

        public float getWeight()
        {
            return weight;
        }

        public bool getVacc()
        {
            return isVacc;
        }

        public DateTime getDateOfBirth()
        {
            return dateOfBirth;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public void setGender(string fullGender)
        {
            if (fullGender == "Male")
            {
                gender = 'M';
            }
            else if (fullGender == "Female")
            {
                gender = 'F';
            }
        }

        public void setWeight(float weight)
        {
            this.weight = weight;
        }

        public void setVacc(string vaccination)
        {
            if (vaccination == "True")
            {
                isVacc = true;
            }
            else if (vaccination == "False")
            {
                isVacc = false;
            }
        }

        public void setDateOfBirth(DateTime dateOfBirth)
        {
            this.dateOfBirth = dateOfBirth;

        }

        public void changeAnimalDetail()
        {
            
        }/// <summary>
        /// update 
        /// </summary>

        public void addAnimal()
        {

        }/// <summary>
        /// add
        /// </summary>

        public void deleteAnimal()
        {

        }///delete
    }
}
