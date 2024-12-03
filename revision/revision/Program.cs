using System.Diagnostics;
using System.Runtime;

namespace revision
{
    class temp {

        public void getstring() {

            Console.WriteLine("Welcome");
        }
        public static int largest(int[]arr) 
        {
            int max = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max) 
                {
                max = arr[i];
                
                }
            
            
            }
            return max;
        
        
        
        }
    }
    struct Rectangle
    {
        //Members
        int width;
        int height;

        //validation
        //public void set_width(int Width)
        //{
        //    if (Width > 0)
        //        this.width = Width;
        //    else throw new Exception("Invald Width");
        //}
        //public int set_width()
        //{
        //    return width;
        //}
        //prop
        public int Height
        {
            set
            {
                if (value > 0)
                    height = value;
                else throw new Exception("Invald Width");
            }
            get { return height; }

        }

        public int Width
        {
            set
            {
                if (value > 0)
                    width = value;
                else throw new Exception("Invald Width");
            }
            get { return width; }

        }
        //operation
        public double Area()
        {
            return height * width;
        }
        public double Perimeter()
        {
            return 2 * (height + width);
        }
        public string Getstring()
        {
            return $"Height={height}\nWidth={width}";
        }
    }

    struct TimeSpan
    {
        // members
        int hours;
        int minutes;
        int seconds;
        // valdation
        public int Hours
        {
            set
            {
                if (value >= 0 && value < 24)
                    hours = value;
                else throw new Exception("Invlad Hours");

            }
            get { return hours; }
        }
        public int Minutes
        {
            set
            {
                if (value >= 0 && value < 60)
                    minutes = value;
                else throw new Exception("Invlad Minutes");
            }
            get { return minutes; }
        }
        public int Seconds
        {
            set
            {
                if (value >= 0 && value < 60)
                    seconds = value;
                else throw new Exception("Invlad Seconds");
            }
            get { return seconds; }
        }

        //operation

        public int TotalSeconds()
        {
            return hours * 3600 + minutes * 60 + seconds;

        }
        public string Getstring()
        {
            return $"{hours}:{minutes}:{seconds}";

        }


    }

    struct hiredata
    {


        public int Day { get; set; }
        public int Month { get; set; }
        public int Years { get; set; }
        public hiredata(int Day, int Month, int Years)
        {
            this.Day = Day;
            this.Month = Month;
            this.Years = Years;
        }
        public string hiredata_dispaly()
        {

            return $"{Day:D2}:{Month:D2}:{Years:D4}";
        }
    }

    class Employees
    {
        public int ID { get; set; }
        public decimal Salary { get; set; }
        public hiredata Hiredate { get; set; }
        public char Gender { get; set; }


        public Employees()
        {

        }
        public Employees(int id, int salary, hiredata hiredata, char gender)
        {
            this.ID = id;
            this.Salary = salary;
            this.Hiredate = hiredata;
            this.Gender = gender;

        }
        //public Employees(int salary, hiredata hiredata, char gender) : this(0, salary, hiredata, gender)
        //{

        //}


        public string Information()
        {

            return $"ID:{ID}\nSalary:{Salary:C}\nHiredate:{Hiredate.hiredata_dispaly()}\nGender:'{Gender}'";

        }



    }

    internal class Program
    {
        static void Main(string[] args)
        {
            #region Test
            //checked
            //{
            //    long x = 4294967296;
            //    uint y = 0;
            //    y = (uint)x;
            //    Console.WriteLine(y);
            //    Console.WriteLine(uint.MaxValue);

            //}

            //int x = 0;
            //while (x<100) {
            //    Console.WriteLine("Enter Number");
            //x += int.Parse(Console.ReadLine());
            //    Console.Clear();

            //}
            //Console.WriteLine(x);
            //string PhoneNumber ="" ;
            //do {
            //    Console.WriteLine("Enter Phone Number");
            //    PhoneNumber = Console.ReadLine();

            //}while (PhoneNumber.Length!=11);
            #endregion

            #region Lab 2
            //Console.WriteLine("Enter char To Convert ");
            //char userchar = char.Parse(Console.ReadLine());
            //int X = userchar;
            //Console.WriteLine("Number is:" + X);
            //Console.WriteLine("Enter Number To Convert");
            //int Numbertoconv = int.Parse(Console.ReadLine());
            //char y = (char)Numbertoconv;
            //Console.WriteLine("Char is:{0}", y);
            //Console.WriteLine("Enter Number");
            //int num = int.Parse(Console.ReadLine());
            //if (num % 2 == 0)
            //{
            //    Console.WriteLine($"Number is Even:{num}");

            //}else
            //    Console.WriteLine($"The Number is Odd:{num}");
            // string checknum = $"{(num % 2 == 0) ? "Even","Odd"}";
            // Console.WriteLine($"sdsd");
            //Console.WriteLine("Enter First Numbers");
            //int first_Number=int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Second Numbers");
            //int second_Number =int.Parse(Console.ReadLine());
            //Console.WriteLine("operation");
            //Console.WriteLine($"Sum ={first_Number+second_Number}");
            //Console.WriteLine($"subtraction ={first_Number - second_Number}");
            //Console.WriteLine($"multiplication ={first_Number * second_Number}");
            //Console.WriteLine("Enter student degree");
            //int Sdegree = int.Parse(Console.ReadLine());
            //if (Sdegree <= 100 && Sdegree >= 80)
            //    Console.WriteLine("A");
            //else if (Sdegree <= 79 && Sdegree >= 65)
            //    Console.WriteLine("B");
            //else if (Sdegree <= 64 && Sdegree >= 55)
            //    Console.WriteLine("C");
            //else if (Sdegree <= 54 && Sdegree >= 50)
            //    Console.WriteLine("D");
            //else Console.WriteLine("F");
            //for (int i = 0; i <= 12; i++)
            //{
            //    Console.WriteLine($"Table{i}");
            //    for (int j = 0; j <= 12; j++)
            //    {
            //        Console.WriteLine($"{i}*{j}={i * j}");
            //    }
            //    Console.WriteLine("-----------");
            //}
            //Console.WriteLine("Enter Number Of Student");
            //int numStudent=int.Parse(Console.ReadLine());
            //int[] students_grade=new int[numStudent];
            //for (int i = 0; i < numStudent; i++) 
            //{
            //    Console.Write($"Enter grade for student{i+1}:");
            //   students_grade[i]=int.Parse(Console.ReadLine());

            //}
            //for (int i = 0; i < students_grade.Length; i++) 
            //{
            //    Console.WriteLine($"Grades For Students{i+1}");
            //    Console.WriteLine(students_grade[i]);

            //}
            //int counter = 0;
            //int sumarr = 0;
            //for (int i = 0; i < numStudent; i++) { 
            //counter++;
            //    sumarr += students_grade[i];

            //}
            //Console.WriteLine($"Average for all students grades:{sumarr/counter}");

            //Console.WriteLine("Enter Number Of Numbers");
            //int Numberofarray = int.Parse(Console.ReadLine());
            //int[] longest_distance = new int[Numberofarray];
            //for (int i = 0; i < longest_distance.Length; i++)
            //{
            //    Console.WriteLine($"Enter Number {i + 1}");
            //    longest_distance[i] = int.Parse(Console.ReadLine());
            //}
            //int firstnum = longest_distance[0];
            //int lastnum=longest_distance[Numberofarray-1];
            //int numlongest_distance = 0;
            //for (int i = 0; i < longest_distance.Length - 1; i++)
            //{
            //    numlongest_distance=longest_distance[i];
            //    for (int j = longest_distance.Length - 1; j > 0; j--)
            //    {
            //        if (numlongest_distance == longest_distance[j])
            //        {
            //            numlongest_distance = j;

            //        }

            //        // Console.WriteLine($"The the longest distance is between  the {i}{longest_distance[i]} and the{j}{longest_distance[j]}with a distance of {j - i}cells");


            //    }


            //}
            //Console.WriteLine(numlongest_distance);
            #endregion

            #region lab 3
            //int[,] multiplication = new int[10, 10];
            //for (int i = 1; i <10; i++)
            //{
            //    for (int j = 1; j <10; j++) 
            //    {
            //        multiplication[i, j] = (i + 1) * (j + 1);
            //    }
            //}


            //for (int i = 1; i < multiplication.GetLength(0); i++)
            //{
            //    Console.WriteLine($"Table{i+1}");
            //    for (int j = 1; j < multiplication.GetLength(1); j++)
            //    {
            //        Console.WriteLine($"{i+1}*{j+1}= {multiplication[i, j]}");  
            //    }
            //}
            //Console.WriteLine("Enter Number Tarcks");
            //int number_tracks = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Number Students");
            //int number_student=int.Parse(Console.ReadLine());

            //int[,] student_age = new int[number_tracks, number_student];
            //for (int i = 0; i < student_age.GetLength(0); i++) 
            //{
            //    Console.WriteLine($"Track No {i + 1}");
            //    for (int j = 0; j < student_age.GetLength(1); j++) 
            //    {
            //        Console.WriteLine($"Enter age for studednt{j+1}");
            //        student_age[i,j]=int.Parse(Console.ReadLine());

            //    }
            //}

            //for (int i = 0; i < student_age.GetLength(0); i++)
            //{
            //    Console.WriteLine($"Track No {i + 1}");
            //    for (int j = 0; j < student_age.GetLength(1); j++)
            //    {

            //        Console.WriteLine($"Age for Student {j + 1}");
            //        Console.WriteLine(student_age[i, j]);

            //    }
            //}
            //int counter = 0;
            //int sum = 0;
            //for (int i = 0; i < student_age.GetLength(0); i++)
            //{

            //    for (int j = 0; j < student_age.GetLength(1); j++)
            //    {
            //        sum += student_age[i, j];
            //        counter++;


            //    }

            //}
            //Console.WriteLine($"Avg age={sum / counter}");

            //int[][]age=new int[number_tracks][];
            //for (int i = 0; i < age.Length; i++)
            //{
            //    age[i]=new int[number_student];

            //}
            //for (int i = 0; i < age.Length; i++)
            //{
            //    Console.WriteLine($"Track No {i + 1}");
            //    for (int j = 0; j < age[i].Length; j++) 
            //    {
            //        Console.WriteLine($"Enter age for studednt{j + 1}");

            //        age[i][j]=int.Parse(Console.ReadLine());

            //    }
            //}
            //for (int i = 0; i < age.Length; i++)
            //{
            //    Console.WriteLine($"Track No {i + 1}");
            //    for (int j = 0; j < age[i].Length; j++)
            //    {
            //        Console.WriteLine($"Age for Student {j + 1}");
            //        Console.WriteLine(age[i][j]); 

            //    }
            //}
            //int totalAge = 0;
            //int totalStudents = 0;

            //for (int i = 0; i < age.Length; i++)
            //{
            //    for (int j = 0; j < age[i].Length; j++)
            //    {
            //        totalAge += age[i][j];
            //        totalStudents++;                    
            //    }               
            //}
            //Console.WriteLine($"Avg age ={totalAge / totalStudents}");

            //Rectangle rectangle1 = new Rectangle();
            //rectangle1.Width = 10;
            //rectangle1.Height = 10;
            //Console.WriteLine(rectangle1.Area());
            //Console.WriteLine(rectangle1.Perimeter());
            //Console.WriteLine(rectangle1.Getstring());

            //TimeSpan T1 = new TimeSpan();
            //T1.Hours = 15;
            //T1.Minutes = 55;
            //T1.Seconds = 20;
            //Console.WriteLine(T1.TotalSeconds());
            //Console.WriteLine(T1.Getstring());  
            //Console.WriteLine("Enter size of timeSpans");
            //int number_timeSpans=int.Parse(Console.ReadLine());
            //TimeSpan[] arr_timeSpans = new TimeSpan[number_timeSpans];
            //for (int i = 0; i < arr_timeSpans.Length; i++)
            //{
            //    Console.WriteLine("Enter Hours");
            //    arr_timeSpans[i].Hours=int.Parse(Console.ReadLine());
            //    Console.WriteLine("Enter Minutes");
            //    arr_timeSpans[i].Minutes = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Enter Seconds");
            //    arr_timeSpans[i].Seconds = int.Parse(Console.ReadLine());


            //}
            //Console.WriteLine("befor sorting");
            //foreach (TimeSpan span in arr_timeSpans) 
            //{
            //    Console.WriteLine(span.Getstring());
            //}
            //TimeSpan temp=new TimeSpan();
            //for (int i = 0; i < arr_timeSpans.Length-1; i++)
            //{
            //    if (arr_timeSpans[i].TotalSeconds()> arr_timeSpans[i+1].TotalSeconds())
            //    {
            //        temp = arr_timeSpans[i];
            //        arr_timeSpans[i] = arr_timeSpans[i + 1];
            //        arr_timeSpans[i+1]=temp;

            //    }

            //}
            //Console.WriteLine("after sorting");

            //foreach (TimeSpan span in arr_timeSpans)
            //{
            //    Console.WriteLine(span.Getstring());
            //}

            #endregion

            #region Lab 4
            //Employees employee1 = new Employees();
            //employee1.ID = 1;
            //employee1.Salary = 10000;
            //employee1.Hiredate = new hiredata(12,11,1999);
            //employee1.Gender = 'M';
            //Console.WriteLine(employee1.Information());
            //Console.WriteLine("Enter number of employess");
            //int number_emp = int.Parse(Console.ReadLine());
            //Employees[] employees = new Employees[number_emp];
            //for (int i = 0; i < employees.Length; i++)
            //{
            //    Console.WriteLine("Enter ID");
            //    int iD = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Enter Salary");
            //    int salary = int.Parse(Console.ReadLine());
            //        Console.WriteLine("Enter Day");
            //        int day = int.Parse(Console.ReadLine());
            //        Console.WriteLine("Enter Month");
            //        int month = int.Parse(Console.ReadLine());
            //        Console.WriteLine("Enter Year");
            //        int year = int.Parse(Console.ReadLine());
            //        hiredata hiredata_emp = new hiredata(day, month, year);
            //    Console.WriteLine("Enter Gender");
            //    char gender = char.Parse(Console.ReadLine());
            //    employees[i] = new Employees()
            //    {

            //        ID = iD,
            //        Gender = gender,
            //        Hiredate = hiredata_emp,
            //        Salary = salary



            //    };


            //    foreach (Employees employee in employees)
            //    {

            //        Console.WriteLine(employee.Information());

            #endregion

            //string str = "welcome to OOP";
            //char[] charArray = str.ToCharArray();

            //for (int i = 0, j = str.Length - 1; i < j; i++, j--)
            //{
            //    charArray[i] = str[j];
            //    charArray[j] = str[i];
            //}

            //string mytxt = new string(charArray);
            //Console.WriteLine(mytxt);
            //int x, y = 0;
            //for (x = 1; x < 10; x++) 
            //{
            //    y = y + x; 
            //    x += 2;
            //}
            //Console.WriteLine(" Y  = " + y);
            //Console.ReadLine();

            //int index = 0;
            //int[,] array = { { 1, 2, 3 }, { 4, 5, 6 } };

            //int w = array.GetLength(0);
            //int h = array.GetLength(1);
            //int[] single = new int[w * h];

            //for (int y = 0; y < h; y++)
            //{
            //    for (int x = 0; x < w; x++)
            //    {
            //        single[index] = array[x, y];
            //        Console.Write(single[index] + " ");
            //        index++;
            //    }

            //}

            //string str = "w(elc)o(me) to()()()() OOP";
            //char[] chararr= str.ToCharArray();
            //string strclean = "";
            //for (int i = 0; i < chararr.Length; i++) 
            //{
            //    if (chararr[i] == '(' || chararr[i] == ')')
            //    {
            //        chararr[i]=' ';

            //    }
            //    else {
            //        strclean += chararr[i];
            //    }

            //}
            //char[] chararr2 = strclean.ToCharArray();
            //Array.Reverse(chararr2);
            //foreach (var C in chararr2)
            //{
            //    Console.Write(C);
            //}

            //string str= "welcome to OOP";
            //string reslut = "";
            //for (int i = 0; i < str.Length; i++)
            //{
            //    if (!reslut.Contains(str[i])) {
            //    reslut += str[i];
            //    }
            //}
            //Console.WriteLine(reslut);

            //temp t=new temp ();
            //Console.WriteLine(temp.largest(new int[] { 1, 2, 3, 4, 5, 6 })); 




        }





    }
        }
    

