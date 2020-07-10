using System;
using System.Collections.Generic;
using System.Text;

namespace Course
{

    public abstract class Persona
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int Year { get; set; }
        
        public Persona()
        {
            this.FirstName = "";
            this.LastName = "";
            this.Age = 0;
            this.Year = 0;
        }
        public Persona(string FirstName, string LastName, int  Age, int Year)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Age = Age;
            this.Year = Year;
        }
        public override string ToString()
        {
            return " FirstName: " + FirstName + " LastName: " + LastName + " Age: " + Age + " Year: "+ Year;
        }

    }
}
