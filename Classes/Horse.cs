using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SebMathewsLynchCA1.Classes
{
    public class Horse
    {
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        //globally unique identifier used to prevent repeating ids/collisions
        public Guid HorseID { get; set; }

        public Horse(string name, DateTime dob)
        {
            Name = name;
            DateOfBirth = dob;
            HorseID = Guid.NewGuid(); 
        }
    }
}
