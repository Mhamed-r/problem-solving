namespace Advlab4
{
    internal class Program
    {
        delegate void mydel(Employee emp);
        delegate void mydel2(Employee emp);


        class Employee
        {

            int age;
            public event mydel Acceptance_age;
            public event mydel2 Retirement_age;

            public int ID { get; set; }
            public string Name { get; set; }
             DateOnly Emp_data { get; set; }

          
               

            
            public DateOnly Age
            {
                
                set
                {
                    age = DateTime.Now.Year-Emp_data.Year;


                    if (age >= 60)
                {

                        age = value.Year;
                        //Retirement_age?.Invoke(this);
                        //throw new Exception("Retirement age");
                        Remove_emp();

                    }
                    else
                {

                        age = value.Year; ;
                }
            }
            get
            {
                return Emp_data;

            }


        }
            public Employee(int ID, string Name , DateOnly Emp_name)
            {

                this.ID = ID;
                //this.Age = Age;
                this.Name = Name;
                this.Emp_data = Emp_name;


            }
            public void AddEmployee()
            {
                //Console.WriteLine( $"Name:{emp.Name} is added to Club and Social " );
                Acceptance_age?.Invoke(this);



            }
            public override string ToString()
            {
                return $"{ID}-{Name}-{Age}";
            }
            public void Remove_emp()
            {


                

                Retirement_age?.Invoke(this);
                // throw new Exception("Retirement age");


            }





        }
        class Club
        {

            public int ID { get; set; }
            public string Name { get; set; }
            public Club(int ID = 0, string Name = "")
            {
                this.ID = ID;
                this.Name = Name;

            }


            public void Add_Employee_club(Employee emp)
            {

                Console.WriteLine($"Name:{emp.Name} is added to {this.Name}Club @ {DateTime.Now.ToShortTimeString()}");


            }
            public override string ToString()
            {
                return base.ToString();
            }
              


        }
        class social_insurance
        {
            public social_insurance(int ID = 0, string Name = "")
            {
                this.ID = ID;
                this.Name = Name;

            }
            public int ID { get; set; }
            public string Name { get; set; }
            public void Add_Employee_Social(Employee emp)
            {
                //DateTime D = new DateTime();
               int age = DateTime.Now.Year - emp.Age.Year;

                if (age >= 60)
                {
                    Console.WriteLine($"Name:{emp.Name} is Removed of {this.Name}insurance @ {DateTime.Now.ToShortTimeString()}");



                }
                else
                {
                    Console.WriteLine($"Name:{emp.Name} is added to {this.Name}insurance @ {DateTime.Now.ToShortTimeString()}");
                }

            }
            public void Remove_Employee_Social(Employee emp)
            {

                Console.WriteLine($"Name:{emp.Name} is Removed of {this.Name}insurance @ {DateTime.Now.ToShortTimeString()}");



            }

        }

        static void Main(string[] args)
        {

            Employee emp = new Employee(1,"Mohamed",new DateOnly(2000,05,11));
            //emp.Age = 100;

            Console.WriteLine(emp.ToString());
            Club club1 = new Club(1, "Alahly");
            social_insurance Social1 = new social_insurance(1, "NOSI");
            emp.Acceptance_age += club1.Add_Employee_club;
            emp.Acceptance_age += Social1.Add_Employee_Social;
            emp.Retirement_age += Social1.Remove_Employee_Social;
            emp.AddEmployee();
            //emp.Remove_emp();












        }
    }
}

