using System.Numerics;
using System.Runtime.CompilerServices;

namespace Lab5part2
{

    class Duration {
       
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }
        public int Totalsec { get; set; }
        public Duration(int Hours, int Minutes, int Seconds) 
        {
        this.Hours = Hours;
        this.Minutes = Minutes; 
        this.Seconds = Seconds;
        this.Totalsec = (Hours * 3600) + (Minutes * 60) + Seconds;

        }
        public Duration(int Totalsec) {
            this.Totalsec = Totalsec;
            double Hour = 0;
            double Minute = 0;
            double Second = 0;
            if (Totalsec > 0)
            {
                Hour = Totalsec / 3600;
                Totalsec = Totalsec % 3600;
                Minute = Totalsec / 60;
                Second = Totalsec % 60;
                this.Hours = (int)Hour;
                this.Minutes = (int)Minute;
                this.Seconds = (int)Second;
               
            }
            else { Console.WriteLine("please check again"); }
        }

        public static Duration operator +(Duration x, Duration y)

        {


            return new(x.Hours + y.Hours, x.Minutes + y.Minutes, x.Seconds + y.Seconds);

        }
        public static Duration operator + (Duration x, int y)

        {

            return new (x.Totalsec + y);
          

        }
        public static Duration operator +(int x, Duration y)

        {

            return new(y.Totalsec + x);


        }
        public static Duration operator ++(Duration x) {
            //x = new Duration((int)x.Totalsec);
            //x.Minutes++;
            //return x;
            x.Minutes++;
            return x;
           

        }
        public static Duration operator -(Duration x, int y)

        {

            return new Duration(x.Totalsec - y);
            // return new(x.Hours - y.Hours, x.Minutes - y.Minutes, x.Seconds - y.Seconds);

        }
        public static Duration operator --(Duration x) 
        {
            x.Minutes--; return x;
        
        }
        public static bool operator < (Duration x, Duration y) {

            return (x.Totalsec < y.Totalsec);

        }
        public static bool operator > (Duration x, Duration y)
        {

            return (x.Totalsec > y.Totalsec);


        }
        public static bool operator <= (Duration x, Duration y)
        {

            return x.Totalsec <= y.Totalsec;
        }
        public static bool operator >=(Duration x, Duration y)
        {

            return x.Totalsec >= y.Totalsec;
        }
        public static bool operator true(Duration x)
        {

            return x.Totalsec > 0;

        }
        public static bool operator false(Duration x) {
            return x.Totalsec >= 0;
        }


        public static explicit operator DateTime(Duration c) {
            DateTime s = new DateTime(c.Totalsec);
            return s;
            //DateTime dateTime =new DateTime();
            //dateTime.Hour=c.Hours;
            //dateTime.Minute=c.Minutes;
            //dateTime.Second=c.Seconds;
           
        }

        public string Hour_12() {
            if (Hours > 12)
            {
                return $"{Hours - 12:D2}:{Minutes:D2}:{Seconds:D2} PM";
            }
            else if (Hours < 12&& Hours!=0) { return $"{Hours:D2}:{Minutes:D2}:{Seconds:D2} AM"; }
            else { return $"{Hours:D2}:{Minutes:D2}:{Seconds:D2}"; }
        }
        public string getstring()
        {
            
            return $"{Hours:D2}:{Minutes:D2}:{Seconds:D2}"; 
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //    Duration D = new Duration(10, 12, 13);
            //    Console.WriteLine(D.getstring());
            Duration D1 = new Duration(56000);
            Console.WriteLine(D1.getstring());
            //    Duration D2 = new Duration(7800);
            //    Console.WriteLine(D2.getstring());
            //    Duration D3 = new Duration(666);
            //    //D3 = 666 + D3;

            //    Console.WriteLine(D3.getstring());
            //    Duration D4 = new Duration(66750);
            //    Console.WriteLine(D4.Hour_12());


            //Duration D5 = new Duration(1);
            //Console.WriteLine(D5.getstrng());
            //Duration D6 = new Duration();
            //D6 = D1 + 3600;
            //Console.WriteLine(D6.getstring());


            //Duration D7 = new Duration(10,12,5);

            //Console.WriteLine(D7.getstring());
            //Duration D8 = new Duration(8600);
            //Console.WriteLine(D8.getstring());
            //Duration D9 = new Duration();
            //D9 = D8 + D7;
            //Console.WriteLine(D9.getstring());
            //D7++;
            //D=D7++;
            //D = D7--;
            DateTime dt = (DateTime)D1;
            Console.WriteLine(dt.ToString());

        }
    }
}
