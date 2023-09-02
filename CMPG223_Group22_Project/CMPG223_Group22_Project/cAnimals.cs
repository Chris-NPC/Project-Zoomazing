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
        public char gender;
        public float weight;
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

        public string addAnimal(int animalId, string name, string gender, float weight, string vacc, int day, int month, int year)
        {
            setName(name);
            setGender(gender);
            setWeight(weight);
            setVacc(vacc);
            setDateOfBirth(day, month, year);

            string sql = $"INSERT INTO ANIMALS VALUES({animalId + 1}, '{getName()}', '{getDateOfBirth()}', '{getGender()}', {getWeight()}, '{getVacc()}')";


            return sql ;
        }
        /// Add Animal

        public string changeAnimalDetail(string animalId, string name, string gender, float weight, string vacc, int day, int month, int year)
        {
            setName(name);
            setGender(gender);
            setWeight(weight);
            setVacc(vacc);
            setDateOfBirth(day, month, year);

            string sql = $"UPDATE ANIMALS SET Animal_Name = '{getName()}', Date_Of_Birth = '{getDateOfBirth()}', Gender = '{getGender()}', Weight = {getWeight()}, Vaccination = '{getVacc()}' WHERE Animal_ID = '{animalId}'";
            
            return sql;
        }
        /// update animal

        public string deleteAnimal(string animalId)
        {
            string sql = $"DELETE FROM ANIMALS WHERE Animal_ID = '{animalId}'";

            return sql;
        }
        /// delete animal
    }
}
