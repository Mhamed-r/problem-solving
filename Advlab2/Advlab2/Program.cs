using System.Diagnostics;
using System.IO;

namespace Advlab2
{
    class Point3D : IComparable<Point3D>,IDisposable
    {
        public int x { get; set; }
        public int y { get; set; }

        public int z { get; set; }


        public Point3D()
        {

        }
        public Point3D(int x, int y, int z) : this()
        {

            bool Status = int.TryParse(x.ToString(), out x);
            this.x = x;
            bool Status1 = int.TryParse(y.ToString(), out y);
            this.y = y;
            bool Status3 = int.TryParse(z.ToString(), out z);
            this.z = z;


            //checked
            //{
            //    if (x is int)
            //        this.x = x;

            //    if (y is int)
            //    {
            //        this.y = y;
            //    }
            //    if (z is int)
            //    {
            //        this.z = z;

            //    }



        }




        public override string ToString()
        {
            return $"{x}-{y}-{z}";
        }
        public static bool operator ==(Point3D D1, Point3D D2)
        {
            if (D1.x == D1.x && D1.y == D2.y && D1.z == D2.z)

                return true;

            return false;



        }
        public static bool operator !=(Point3D D1, Point3D D2)
        {
            if (D1.x == D1.x && D1.y == D2.y && D1.z == D2.z)

                return true;

            return false;
        }
        public override bool Equals(object? obj)
        {
            //if (obj.GetType() == typeof(Design3D);
            Point3D D = (Point3D)obj;
            return (x == D.x && y == D.y && z == D.z);
        }

        public int CompareTo(Point3D? obj)
        {

            if (x > obj.x && y>obj.y) return 1;
            else if (x == obj.x && y == obj.y) return 0;
            else return -1;
            // return x.CompareTo(obj.x).CompareTo(obj.y);
        }

        public void Dispose()
        {
            Console.WriteLine("Distractor"); ;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Checked & parse
            //checked
            //{
            //    Exception ex = new Exception();

            //    Console.WriteLine("Enter Number X");
            //    int X = int.Parse(Console.ReadLine());
            //    if (X is int x) ;
            //    else Console.WriteLine(ex.Message);

            //    Console.WriteLine("Enter Number Y");

            //    int Y = int.Parse(Console.ReadLine());
            //    if (Y is int y) ;
            //   else Console.WriteLine(ex.Message);

            //    Console.WriteLine("Enter Number Z");

            //    int Z = int.Parse(Console.ReadLine());
            //    if (Z is int z) ;
            //    else Console.WriteLine(ex.Message);

            //    Point3D D1 = new Point3D(x, y, z);
            //    Console.WriteLine(D1);
            //}
            #endregion
            #region Try parse

            //Console.WriteLine("Enter Number X");

            //int x = 0;
            //bool Status = int.TryParse(Console.ReadLine(), out x);

            //Console.WriteLine($"Status{Status}");
            //Console.WriteLine("Enter Number Y");

            //int y = 0;
            //bool Status1 = int.TryParse(Console.ReadLine(), out y);

            //Console.WriteLine($"Status{Status1}");

            //Console.WriteLine("Enter Number Z");

            //int z = 0;
            //bool Status3 = int.TryParse(Console.ReadLine(), out z);
            //Console.WriteLine($"Status{Status3}");


            //Point3D D1 = new Point3D(x, y, z);
            //Console.WriteLine(D1);
            #endregion




            #region convert
            //Exception ex = new Exception();

            //Console.WriteLine("Enter Number X");
            //int X = Convert.ToInt32(Console.ReadLine());
            //if (X is int x) ;
            //else Console.WriteLine(ex.Message);

            //Console.WriteLine("Enter Number Y");

            //int Y = Convert.ToInt32(Console.ReadLine());
            //if (Y is int y) ;
            //else Console.WriteLine(ex.Message);

            //Console.WriteLine("Enter Number Z");

            //int Z = Convert.ToInt32(Console.ReadLine());
            //if (Z is int z) ;
            //else Console.WriteLine(ex.Message);

            //Point3D D1 = new Point3D(x, y, z);
            //Console.WriteLine(D1);

            #endregion



            Point3D P = new Point3D(10, 10, 10);
            Console.WriteLine(P.ToString());
            Point3D P1 = new Point3D(10, 10, 10);
            Point3D P2 = new Point3D(10, 11, 10);

            Console.WriteLine(P1.CompareTo(P2));


            //if (P1 == P2)
            //{


            //    Console.WriteLine("Eqlues");

            //}
            //else { Console.WriteLine("Not Eqlues"); }
            //Console.WriteLine("Enter Number");
            //int Num = int.Parse(Console.ReadLine());

            //Point3D[] arr = new Point3D[Num];
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = new Point3D();
            //    Console.WriteLine($"Enter No:1");
            //    arr[i].x = int.Parse(Console.ReadLine());
            //    Console.WriteLine($"Enter No:2");

            //    arr[i].y = int.Parse(Console.ReadLine());
            //    Console.WriteLine($"Enter No:3");

            //    arr[i].z = int.Parse(Console.ReadLine());

            //}
            //Array.Sort(arr);



            //    for (int i = 0; i < arr.Length - 1; i++)
            //    {

            //        if (arr[i].x > arr[i + 1].x && arr[i].y > arr[i + 1].y)
            //        {
            //            Point3D temp = default(Point3D);
            //            temp = arr[i];
            //            arr[i] = arr[i + 1];
            //            arr[i + 1] = temp;


            //        }


            //    }
            //foreach (Point3D p in arr)
            //{
            //    Console.WriteLine(p);
            //}
            //}


            try {

                Console.WriteLine("Enter Number X");
               int x=int.Parse(Console.ReadLine());

                Console.WriteLine("Enter Number Y");

               int y=int.Parse(Console.ReadLine());


                Console.WriteLine("Enter Number Z");

                int z = int.Parse(Console.ReadLine());


                Point3D D1 = new Point3D(x, y, z);
                Console.WriteLine(D1);

            }
            catch(Exception ex) {

                // Console.WriteLine(ex.Message);
                string filePath = @"D:\ITI\Intro C#\Labs\Advlab2\Error.txt";                

                    using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    writer.WriteLine("-----------------------------------------------------------------------------");
                    writer.WriteLine("Date : " + DateTime.Now.ToString());
                    writer.WriteLine("Message : " + ex.Message);
                    
                    
                      
                    }
                }



            }
        }
    }

