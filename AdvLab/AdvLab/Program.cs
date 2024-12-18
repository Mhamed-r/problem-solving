
using  emp;
using System;
namespace AdvLab

{
    internal class Program
    {


        //class queue<T>
        //{
        //    T[] queue_arr;
        //    int front;
        //    int last;
        //    int count;
        //    int Size;
        //    public queue(int size)
        //    {
        //        queue_arr = new T[size];
        //        front = -1;
        //        last = -1;
        //        this.Size = size;
        //        count = 0;


        //    }
        //    public void Enqueue(T item)
        //    {

        //        if (front < queue_arr.Length)
        //        {
        //            front = (front + 1) % Size;
        //            queue_arr[front] = item;
        //             count++;

        //        }

        //    }
        //    public T Dequeue()
        //    {

        //        if (last > -1) { 
        //            T item = queue_arr[last];
        //            last = (last + 1) % Size;
        //           count--;
        //        }
        //        else
        //            return default(T);

        //        return queue_arr[last];



        //    }
        //    public bool IsFull() {

        //        if (count == Size)
        //            return true;
        //        else { return false; }

        //    }
        //    public bool IsEmpty()
        //    {

        //        if (count == 0)
        //            return true;
        //        else { return false; }

        //    }





        //}
        class Point3D
        {
            public int x { get; set; }
            public int y { get; set; }

            public int z { get; set; }

           
            public Point3D()
            {

            }
            public Point3D(int x, int y, int z) : this()
            {
                this.x = x;
                this.y = y;
                this.z = z;
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
                Point3D D =(Point3D)obj;
                return (x==D.x&&y==D.y&&z==D.z);
            }

        }
        class qrr_queue<T>
        {
            T[] queue_arr;
            int Head;
            int Tail;
            int size;
            int index;

            public qrr_queue(int size)
            {
                this.size = size;
                this.queue_arr = new T[size];
                this.Head = 0;
                this.Tail = 0;
                this.index = 0;



            }

            public void Enqueue(T item)
            {
                if (Tail < queue_arr.Length)
                {

                    queue_arr[Tail++] = item;

                    index++;

                }
                else { throw new Exception("Error"); }




            }
            public T Dequeue()
            {

                if (Head < queue_arr.Length)
                {

                    return queue_arr[Head++];

                    index--;
                }
                else
                {
                    throw new Exception("Error");
                }




            }
            public T Peek()
            {



                if (Tail == 0)
                {

                    throw new Exception("Error");
                }
                else
                {
                    T item1 = queue_arr[0];
                    T temp=default(T);

                    for (int i = 0; i < Tail-1; i=i+1)
                    {
                       // temp = queue_arr[i];
                        queue_arr[i] = queue_arr[i+1];

                       // queue_arr[queue_arr.Length - 1] = default(T);



                    }
                    Tail--;
                    index--;
                    return item1;
                }

            }

            public bool Is_Empty()
            {

                if (index == 0)
                {
                    return true;

                }
                else return false;

            }
            public bool Is_Full()
            {

                if (index == size)
                {
                    return true;

                }
                else return false;

            }
        }

            static void Main(string[] args)
            {
            #region part_one


            //    emp.Class1.employeeservice etm = new emp.Class1.employeeservice(1, "Mohamed", 30, new DateOnly(2022, 1, 1), 15);
            //Console.WriteLine(etm.ToString());
            #endregion
            #region queue

            qrr_queue<int> S = new qrr_queue<int>(5);
                S.Enqueue(2);
                S.Enqueue(3);
                S.Enqueue(4);
                S.Enqueue(5);
                S.Enqueue(5);
            Console.WriteLine(S.Is_Full());




            Console.WriteLine(S.Peek());
            Console.WriteLine(S.Peek());
            Console.WriteLine(S.Peek());
            Console.WriteLine(S.Peek());        
            Console.WriteLine(S.Is_Empty());

            S.Enqueue(4);
            S.Enqueue(2);
            S.Enqueue(3);
            S.Enqueue(7);


            Console.WriteLine(S.Peek());
            Console.WriteLine(S.Peek());
            Console.WriteLine(S.Peek());
            Console.WriteLine(S.Peek());








            #endregion
            #region Part3
            Point3D P = new Point3D(10, 10, 10);
            Console.WriteLine(P.ToString());
            Point3D P1= new Point3D(10, 10, 10);
            Point3D P2 = new Point3D(10, 11, 10);

            if (P1 == P2)
            {


                Console.WriteLine("Eqlues");

            }
            else { Console.WriteLine("Not Eqlues"); }
            Console.WriteLine("Enter Number");
            int Num=int.Parse(Console.ReadLine());

            Point3D[] arr = new Point3D[Num];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new Point3D();
                Console.WriteLine($"Enter No:1");
                arr[i].x=int.Parse(Console.ReadLine());
                Console.WriteLine($"Enter No:2");

                arr[i].y = int.Parse(Console.ReadLine());
                Console.WriteLine($"Enter No:3");

                arr[i].z = int.Parse(Console.ReadLine());

            }
            for (int i = 0; i < arr.Length-1; i++) {

                if (arr[i].x > arr[i + 1].x && arr[i].y >arr[i + 1].y) {
                    Point3D temp=default(Point3D);
                    temp=arr[i];
                    arr[i]=arr[i+1];
                    arr[i+1]=temp;
                
                
                }
            
            
            }
            foreach (Point3D p in arr)
            {
                Console.WriteLine(p);
            }

            #endregion

        }
    }
    }





