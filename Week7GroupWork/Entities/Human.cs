using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week7GroupWork.Entities.BaseEntities;

namespace Week7GroupWork.Entities
{
    public class Human : Animal
    {
        string firstName, lastName, sex, nationality;
        double height, weight;
        DateTime birthDate;

        public Human(string firstName, string lastName, string sex, double height, double weight, DateTime birthDate, string nationality)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.sex = sex;
            this.height = height;
            this.weight = weight;
            this.birthDate = birthDate;
            this.nationality = nationality;
        }

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Sex { get => sex; set => sex = value; }
        public double Height { get => height; set => height = value; }
        public double Weight { get => weight; set => weight = value; }
        public DateTime BirthDate { get => birthDate; set => birthDate = value; }
        public string Nationality { get => nationality; set => nationality = value; }

    }
}
