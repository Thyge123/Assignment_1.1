using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mandatory_assignment_1
{
    public class FootballPlayer
    {
        public FootballPlayer()
        {
        }

        public FootballPlayer(int id, string name, int age, int shirtNumber)
        {
            Id = id;
            Name = name;
            Age = age;
            ShirtNumber = shirtNumber;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int ShirtNumber { get; set; }

        public override string ToString()
        {
            return $"{{{nameof(Id)}={Id.ToString()}, {nameof(Name)}={Name}, {nameof(Age)}={Age.ToString()}, {nameof(ShirtNumber)}={ShirtNumber.ToString()}}}";
        }

        public void ValidateName()
        {
            //if (Name == null) throw new ArgumentNullException("name is null");

            if (Name.Length < 2) throw new ArgumentException("name must be at least 2 character: " + Name);
        }

        public void ValidateAge()
        {
           
            if (Age < 1) throw new ArgumentOutOfRangeException("Age must be atleast 1: " + Age);
        }

        public void ValidateShirtNumber()
        {
              if (ShirtNumber < 1 || ShirtNumber > 99) throw new ArgumentOutOfRangeException("ShirtNumber must be minimum 1 and maximum 99: " + ShirtNumber);
        }

        public void Validate()
        {
            ValidateName();
            ValidateAge();
            ValidateShirtNumber();
        }

    }
}
