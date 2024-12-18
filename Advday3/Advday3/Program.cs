using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Advday3
{
    struct hiredate:IComparable<hiredate>
    {
        public hiredate(int year, int month, int day)
        {
            Year = year;
            Month = month;
            Day = day;
        }
        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }

        public int CompareTo(hiredate obj)
        {
            //if (obj.Year.CompareTo(Year) == 0) ;
            //else if (obj.Month.CompareTo(Month) == 0) ;
            //else { return -1; }

            if (Year > obj.Year || Year == obj.Year && Month > obj.Month || Year == obj.Year && Month == obj.Month && Day > obj.Day)
            {
                return 1;
            }
            else if (Year < obj.Year || Year == obj.Year && Month < obj.Month || Year == obj.Year && Month == obj.Month && Day < obj.Day) { return -1; }
            else { return 0; }

            //if (Year > obj.Year) return 1;
            //else if (Year < obj.Year) return -1;
            //else if(Month > obj.Month) return 1;
            //else if(Month < obj.Month) return -1;
            //else if (Day > obj.Day) return 1;
            //else if (Day < obj.Day) return -1;
            //else return 0;
        }

        public override string ToString()
        {
            return $"{Day}/{Month}/{Year}";

        }


    }
    enum gender
    {
        Male, Female

    }
    [Flags]
    enum privileges : byte
    {
        guest = 1, Developer = 2, secretary = 4, DBA = 8

    }
    class Employee : IComparable<Employee>
    {

        public Employee()
        {
        }
        public Employee(int ID, gender Gender, int Salary, hiredate hiredate, privileges securitylevel)
        {
            this.securitylevel = securitylevel;
            this.ID = ID;
            this.Gender = Gender;
            this.Salary = Salary;
            this.hiredate = hiredate;
        }

        public int ID { get; set; }
        public gender Gender { get; set; }
        public int Salary { get; set; }
        public privileges securitylevel { get; set; }
        public hiredate hiredate { get; set; }

        public int CompareTo(Employee? other)
        {
          return(hiredate.CompareTo(other.hiredate));
        }

        public override string ToString()
        {

            return $"Employee ID:{ID}\nEmployee Salary:{Salary:C}\nGender:{Gender}\nhiredate:{hiredate.ToString()}\nsecuritylevel:{securitylevel}\n";

        }


    }


        internal class Program
    {
        static void Main(string[] args)
        {

            Employee emp = new Employee(15,gender.Male,5000,new hiredate(2005,11,12),privileges.DBA );
            Employee emp1 = new Employee(15, gender.Male, 5000, new hiredate(1999, 11, 12),  privileges.guest);
            Employee emp2 = new Employee(15, gender.Male, 5000, new hiredate(2005, 11, 5),privileges.secretary);
            Employee[] EmpArr = new Employee[] {emp, emp1, emp2 };
            Array.Sort(EmpArr);
            for (int i = 0; i < EmpArr.Length; i++)
            {
                Console.WriteLine(EmpArr[i].ToString());
            }

            // Allow NO RUNTIME errors if the user inputs any data
            #region user_input
            try
            {
                Console.WriteLine("Enter numbers of employees");
                int Numberofemployee = int.Parse(Console.ReadLine());
                Employee[] Employee1 = new Employee[Numberofemployee];
                for (int i = 0; i < Employee1.Length; i++)
                {

                    Console.WriteLine($"\nEnter EmployeeID {i + 1}:");
                    int id = int.Parse(Console.ReadLine());
                    Console.WriteLine($"\nEnter EmployeeGender {i + 1}:");
                 
                    string X=Console.ReadLine();
                    gender g = (gender)Enum.Parse(typeof(gender), X);
                  

                    Console.WriteLine($"\nEnter EmployeeSalary {i + 1}:");
                    int Salary = int.Parse(Console.ReadLine());
                    
                    Console.WriteLine($"\nEnter securitylevel {i + 1}:");
                    string Z = Console.ReadLine();
                    privileges u = (privileges)Enum.Parse(typeof(privileges),Z);

                    Console.WriteLine($"\nEnter hiredate {i + 1}:");
                    Console.Write("Year: ");
                    int Years = int.Parse(Console.ReadLine());
                    Console.Write("Month: ");
                    int Months = int.Parse(Console.ReadLine());
                    Console.Write("Day: ");
                    int Days = int.Parse(Console.ReadLine());
                    Employee1[i] = new Employee
                    {
                        ID = id,
                        Gender = g,
                        Salary = Salary,
                        securitylevel = u,


                        // hiredate = new hiredate { Year = Years, Month = Months, Day = Days }
                        hiredate = new hiredate(Years, Months, Days)



                    };
                    Console.WriteLine($"Before Sorting");
                    foreach (Employee Employee in Employee1)
                    {

                        Console.WriteLine(Employee.ToString());
                    }
                    Array.Sort(Employee1);
                    Console.WriteLine($"After Sorting");
                    foreach (Employee Employee in Employee1)
                    {

                        Console.WriteLine(Employee.ToString());
                    }

                }



            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }



            #endregion





            //Console.WriteLine(emp.ToString());


        }

    }
}

