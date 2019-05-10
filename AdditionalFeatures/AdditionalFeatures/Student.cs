using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalFeatures
{
    class Student
    {
        public Student(string name, int id, int credits, bool goodStanding)
        {
            Name = name;
            Id = id;
            TotalCreditHours = credits;
            InGoodStanding = goodStanding;

        }
        //for a new student that has no credits and in good standing by default
        public Student(string name, int id) : this(name, id, 0, true)
        {

        }
        public string Name { get; set; }
        public int Id { get; set; }
        public int TotalCreditHours { get; set; }
        public bool InGoodStanding { get; set; }
    }
}
