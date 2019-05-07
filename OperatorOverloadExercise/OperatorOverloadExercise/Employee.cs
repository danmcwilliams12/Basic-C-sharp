using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloadExercise
{
    class Employee
    {
        public int Id { get; set; }

        public static bool operator== (Employee employee1, Employee employee2)
        {
            bool isSameId = (employee1.Id == employee2.Id);
            return isSameId;
        }
        public static bool operator!= (Employee employee1, Employee employee2)
        {
            bool isSameId = (employee1.Id == employee2.Id);
            return isSameId;
        }
    }
}
