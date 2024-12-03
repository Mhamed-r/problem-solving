using System.Drawing;
using System.Reflection;

namespace Lab4
{
    struct hiredate
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

        public String Display()
        {
            return $"{Day}/{Month}/{Year}";

        }

    }

   
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter numbers of employees");
            int Numberofemployee = int.Parse(Console.ReadLine());
            Employee[] Employee1 = new Employee[Numberofemployee];
            for (int i = 0; i < Employee1.Length; i++)
            {

                Console.WriteLine($"\nEnter EmployeeID {i + 1}:");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine($"\nEnter EmployeeGender {i + 1}:");
                char Gender = char.Parse(Console.ReadLine());
                Console.WriteLine($"\nEnter EmployeeSalary {i + 1}:");
                int Salary = int.Parse(Console.ReadLine());
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
                    Gender = Gender,
                    Salary = Salary,
                  // hiredate = new hiredate { Year = Years, Month = Months, Day = Days }
                    hiredate= new hiredate(Years, Months, Days)

                };


            }

            Console.WriteLine($"Before Sorting");
            foreach (Employee Employee in Employee1)
            {
               
                Console.WriteLine(Employee.Information());
            }

            Employee temp = new Employee();

            for (int i = 0; i < Employee1.Length - 1; i++)
            {
                for (int j = 0; j < Employee1.Length - 1; j++)
                {
                    if (Employee1[j].hiredate.Year > Employee1[j + 1].hiredate.Year)
                    {
                        temp = Employee1[j];
                        Employee1[j] = Employee1[j + 1];
                        Employee1[j + 1] = temp;
                    }
                    else if (Employee1[j].hiredate.Year == Employee1[j + 1].hiredate.Year
                    && Employee1[j].hiredate.Month > Employee1[j + 1].hiredate.Month)
                    {

                        temp = Employee1[j];
                        Employee1[j] = Employee1[j + 1];
                        Employee1[j + 1] = temp;

                    }
                    else if (Employee1[j].hiredate.Month == Employee1[j + 1].hiredate.Month
                        && Employee1[j].hiredate.Day > Employee1[j+1].hiredate.Day)
                    {
                        temp = Employee1[j];
                        Employee1[j] = Employee1[j + 1];
                        Employee1[j + 1] = temp;

                    }
                       


                    {
                        



                    }





                }
            }
            Console.WriteLine("After Sorting");
            foreach (Employee Employee in Employee1)

            {
               
                Console.WriteLine(Employee.Information());
            }
        }
    }
}

