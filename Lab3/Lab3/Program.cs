using System.Dynamic;

namespace Lab3
{
    struct Rectangle {
        //members
        int width
            , height;

        //validation

        public int Width
        {
            set
            {
                if (value > 0)
                    width = value;
                else
                    throw new Exception("invalid value number");
            }
            get { return width; }
        }
        public int Height
        {
            set
            {
                if (value > 0)
                    height = value;
                else
                    throw new Exception("invalid height number");
            }
            get { return height; }
        }
        //opertions
        public string Getstring() {

            return $"Width:{width}\nHeight:{height}";
        }
        public double RectangleArea(int x, int y) {
            return x * y;
        
        }
        public double Rectangleperimeter(int x, int y)
        {
            return (x + y)*2;

        }
    }

    struct Time {
        //members
        int hours,minutes,seconds;


        //validation
        public int Hours
        {
            set {
            if (value < 24 && value >=0)
                hours = value;
            else
                    throw new Exception("invalid Hours number");
            }
            get { return hours; }
        }
        public int Minutes
        {
            set
            {
                if (value < 60 && value >= 0)
                    minutes = value;
                else
                    throw new Exception("invalid Minutes number");
            }
            get { return minutes; }
        }
        public int Seconds
        {
            set
            {
                if (value < 60 && value >= 0)
                    seconds = value;
                else
                    throw new Exception("invalid Minutes number");
            }
            get { return seconds; }
        }

        //opertions
        public int TotalSeconds() {

            return hours * 3600 + minutes * 60 + seconds;
        }
        public string Getstring() {
            return $"Time {hours}:{minutes}:{seconds}";


        }

    }









    internal class Program
    {
        static void Main(string[] args)
        {
            #region MultiTable 
            //int[,] MultiTable = new int[10, 10];
            //for (int i = 0; i < 10; i++)
            //{

            //    for (int j = 0; j < 10; j++)
            //    {
            //        MultiTable[i, j] = (i + 1) * (j + 1);
            //    }
            //}
            //for (int i = 0; i < MultiTable.GetLength(0); i++)
            //{
            //    Console.WriteLine($"Table Of {i + 1} ");

            //    for (int j = 0; j < MultiTable.GetLength(1); j++)
            //    {
            //        Console.WriteLine($"{MultiTable[i, j]}");


            //    }








            //}
            #endregion

            #region Avg age
            //Console.WriteLine("Enter Number of Tracks");
            //int Numoftracks = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Number of Students");
            //int Numofstudednt = int.Parse(Console.ReadLine());
            //Console.WriteLine("---------");
            //int[,]Ageofstudent = new int[Numoftracks, Numofstudednt];

            //for (int i = 0; i < Numoftracks; i++)
            //{

            //for (int j = 0; j < Numofstudednt; j++) 
            //    {
            //        Console.WriteLine($"Enter Age For Student{j+1} ");
            //        Ageofstudent[i, j] = int.Parse(Console.ReadLine());
            //    }

            //}


            //for (int i = 0; i < Numoftracks; i++)
            //{
            //    Console.WriteLine($"\nNumber of Student in Track: {i + 1}\n ");

            //    for (int j = 0; j < Numofstudednt; j++)
            //    {
            //        Console.WriteLine($"Age of Studednt{j+1}:{Ageofstudent[i, j]}");


            //    }
            //}
            //int totalAge = 0;
            //int totalStudents = 0;
            //for (int i = 0; i < Numoftracks; i++)
            //{ 

            //for (int j = 0; j < Numofstudednt; j++) 
            //    {

            //        totalAge += Ageofstudent[i, j];

            //        totalStudents++;


            //    }
            //}
            //Console.WriteLine($"Avrge:{totalAge/totalStudents}");


            //int[][] Ageofstudent = new int[Numoftracks][];
            //for (int i = 0; i < Numoftracks; i++) 
            //{

            //    Ageofstudent[i] = new int[Numofstudednt];

            //}

            #endregion

            #region Rectangle
            //Rectangle r = new Rectangle();

            //r.Height = 10;
            //r.Width = 20;
            //Console.WriteLine(r.RectangleArea(r.Height,r.Width));
            //Console.WriteLine(r.Rectangleperimeter(r.Height,r.Width));
            //Console.WriteLine(r.Getstring());
            #endregion
            #region Time Span


            //Time t = new Time();
            //t.Hours = 12;
            //t.Minutes = 55;
            //t.Seconds = 55;
            //Console.WriteLine(t.Getstring());
            //Console.WriteLine(t.TotalSeconds());

            Console.WriteLine("Enter Size of array");
            int Size = int.Parse(Console.ReadLine());
            Time[] timeArray = new Time[Size];
            for (int i = 0; i < Size; i++)
            {
                Console.WriteLine($"\nEnter time {i + 1}:");
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Minutes: ");
                int minutes = int.Parse(Console.ReadLine());
                Console.Write("Seconds: ");
                int seconds = int.Parse(Console.ReadLine());
                timeArray[i] = new Time { Hours = hours, Minutes = minutes, Seconds = seconds };

            }
            Console.WriteLine("Array befober sorting");
            for (int i = 0; i < Size; i++)
            {
                
                Console.WriteLine(timeArray[i].Getstring());
            }
            Time temp = new Time();
          
          
            for (int i = 0; i < timeArray.Length - 1; i++)
            {
                for (int j = 0; j < timeArray.Length - 1; j++) {
                    if (timeArray[j].Hours > timeArray[j + 1].Hours
                     || (timeArray[j].Hours == timeArray[j + 1].Hours
                     && timeArray[j].Minutes > timeArray[j + 1].Minutes)
                     || (timeArray[j].Hours == timeArray[j + 1].Hours
                     && timeArray[j].Minutes == timeArray[j + 1].Minutes
                     && timeArray[j].Seconds > timeArray[j + 1].Seconds))
                    {
                    
                    temp = timeArray[j];
                    timeArray[j] =timeArray[j + 1];
                    timeArray[j + 1] =temp;



                    }
                    
                
                
                }   


                //if (timeArray[i].Hours > timeArray[i + 1].Hours)
                //{
                //    tempH.Hours = timeArray[i].Hours;
                //    timeArray[i].Hours = timeArray[i + 1].Hours;
                //    timeArray[i + 1].Hours = tempH.Hours;
                //}
                //else if (timeArray[i].Minutes > timeArray[i + 1].Minutes)
                //{
                //    tempM.Minutes = timeArray[i].Minutes;
                //    timeArray[i].Minutes = timeArray[i + 1].Minutes;
                //    timeArray[i + 1].Minutes = tempM.Minutes;


                //}
                //else if (timeArray[i].Seconds > timeArray[i + 1].Seconds)
                //{
                //    tempS.Seconds = timeArray[i].Seconds;
                //    timeArray[i].Seconds = timeArray[i + 1].Seconds;
                //    timeArray[i + 1].Seconds = tempS.Seconds;

                //}
            }
            Console.WriteLine("Array after sorting");
            for (int i = 0; i < Size; i++)
            {
               
                Console.WriteLine(timeArray[i].Getstring());
            }
            #endregion



        }
    }
}
