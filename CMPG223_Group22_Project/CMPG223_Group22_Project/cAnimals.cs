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

        public void setDateOfBirth(int day, int month, int year)
        {
            string dateOfBirthString = day.ToString() + month.ToString() + year.ToString();
            DateTime dob = DateTime.Parse(day + "/" + month + "/" + year);

            dateOfBirth = dob;

        }

        public string addAnimal()
        {
            string sql = $"INSERT INTO ANIMALS VALUES({getName()}, {getDateOfBirth()}, {getGender()}, {getWeight()}, {getVacc()})";


            return sql ;
        }/// <summary>
         /// add
         /// </summary>

        public string changeAnimalDetail(int animalId)
        {
            string sql = $"UPDATE ANIMALS SET Animal_Name = {getName()}, Date_Of_Birth = {getDateOfBirth()}, Gender = {getGender()}, Weight = {getWeight()}, Vaccination = {getVacc()} WHERE Animal_ID = {animalId}";
            
            return sql;
        }/// <summary>
        /// update 
        /// </summary>

        public string deleteAnimal(int animalId)
        {
            string sql = $"DELETE FROM ANIMAL WHERE Animal_ID{animalId}";

            return sql;
        }/// <summary>
        /// delete
        /// </summary>
    }
}
