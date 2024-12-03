using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Employee
    {
        
            public Employee()
            {
            }
            public Employee(int ID, char Gender, int Salary, hiredate hiredate)
            {
                this.ID = ID;
                this.Gender = Gender;
                this.Salary = Salary;
                this.hiredate = hiredate;
            }

            public int ID { get; set; }
            public char Gender { get; set; }
            public int Salary { get; set; }
            public hiredate hiredate { get; set; }

            public string Information()
            {

                return $"Employee ID:{ID}\nEmployee Salary:{Salary}\nGender:{Gender}\nhiredate:{hiredate.Display()}";

            }


        }
    }

