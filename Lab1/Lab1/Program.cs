using System;

namespace Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ASCII
            //Console.WriteLine("Enter Your Char To convert");
            //char AsciiC = char.Parse(Console.ReadLine());
            //int AsciiN = AsciiC;
            //Console.WriteLine($"ASCII CODE:{AsciiN}" );


            #endregion
            #region Reverse ASCII
            // Console.WriteLine("Enter Number To convert ");
            //int AsciiNum = int.Parse(Console.ReadLine());
            // char AsciiChar = (char)AsciiNum;
            // Console.WriteLine($"Your Char: {AsciiChar}");

            #endregion
            #region odd or even
            //Console.Write("Enter Number: ");
            //int Numbertocheck = int.Parse(Console.ReadLine());
            //if (Numbertocheck % 2==0)
            //    Console.WriteLine("Number is even");
            //else
            //    Console.WriteLine("Number is odd");

            //Console.Write("Enter Number: ");
            //int x = int.Parse(Console.ReadLine());
            //Console.WriteLine((x % 2 == 0) ? "even":"odd");  
            #endregion
            #region opration 4 two numbers
            //Console.WriteLine("Enter First Number");
            //int numberone = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Second Number");
            //int numbertwo = int.Parse(Console.ReadLine());
            //Console.WriteLine($"Sum = {numberone+numbertwo}\nsub = {numberone-numbertwo}\nmult = {numberone*numbertwo}");

            #endregion
            #region grade
            //Console.WriteLine("Enter student degree");
            //byte degree = byte.Parse(Console.ReadLine());
            //if(degree>=80 && degree<=100)
            //    Console.WriteLine("A");
            //else if(degree>=65 && degree<=79)
            //    Console.WriteLine("B");
            //else if (degree>=55 && degree<=64)
            //    Console.WriteLine("C");
            //else if (degree>=50 && degree<=54)
            //    Console.WriteLine("D");
            //else
            //    Console.WriteLine("F");
            #endregion
            #region Mult
            //for (byte i = 1; i <= 12; i++)
            //{
            //    Console.WriteLine($"Table {i}\n");
            //    for (byte j = 0; j <= 12; j++)
            //    {

            //        Console.WriteLine($"{i}*{j}={i * j}");
            //    }
            //    Console.WriteLine("-----------");
            //}
            #endregion
            #region store grede
            //Console.WriteLine("Enter number of students ");
            //int numberofstudents = int.Parse( Console.ReadLine());
            //int[]students = new int[numberofstudents];
            //for (int i = 0; i < students.Length; i++) {
            //    Console.WriteLine($"Students grade{i+1}");
            //    students[i] = int.Parse( Console.ReadLine());


            //}
            //for (int i = 0; i < numberofstudents; i++)
            //{
            //    Console.WriteLine($"Grade {i+1} :{students[i]}");
            //}
            //int sum = 0;

            //for (int i = 0; i < students.Length; i++)
            //{
            //    sum += students[i];

            //}
            //Console.WriteLine($"Averge = {sum/numberofstudents} ");
            #endregion
            #region longest disance
            //Console.WriteLine("Enter numbers of array ");
            //int numofarray = int.Parse(Console.ReadLine());

            //int[] numbers = new int[numofarray];


            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.Write($"Enter NO({i + 1}):");
            //    numbers[i] = int.Parse(Console.ReadLine());

            //}
            //int max = 0;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    int temp = numbers[i];
            //    for (int j = i + 1; j < numbers.Length; j++)
            //    {
            //        if (temp == numbers[j])
            //            max = j;
            //    }
            //}

            //Console.WriteLine($"longest disance between two equal cell :{max}");



            #endregion
            #region bonus
            //Console.WriteLine("Enter numbers of array ");
            //int Numofarray = int.Parse(Console.ReadLine());

            //int[] Numbers = new int[Numofarray];
            //for (int i = 0; i < Numofarray; i++)
            //{
            //    Console.Write($"Enter NO({i + 1}):");
            //    Numbers[i] = int.Parse(Console.ReadLine());
            //}
            //int sum = 0;

            //for (int i = 0; i < Numbers.Length; i++)
            //{
            //    sum += Numbers[i];

            //}
            //Console.WriteLine($"Sum: {sum}");
            ////Console.WriteLine($"Sum: {Numbers.Sum()}");
            //int max = Numbers[0];
            //for (int i = 0; i < Numbers.Length; i++)
            //{

            //    if (Numbers[i] > max)
            //        max = Numbers[i];
            //}

            //Console.WriteLine($"Max: {max}");

            ////Console.WriteLine($"Max: {Numbers.Max()}");
            //for (int i = Numbers.Length - 1; i >= 0; i--)
            //{
            //    Console.Write($"Enter NO({i + 1}):");
            //    Console.WriteLine(Numbers[i]);
            //}
            //int coun = 0;
            //foreach (int number in Numbers)
            //{
            //    if (Numbers[number] == Numbers[number + 1])
            //    {
            //        coun++;
            //    }
            //}
            //    Console.WriteLine($"count: {coun}");
            //int[] DistinctNum = new int[Numbers.Length];
            //foreach (var num in Numbers)
            //{
            //    if (Numbers[num] != Numbers[num+1])
            //    {
            //        for (int i = 0;i < DistinctNum.Length;i++)
            //            DistinctNum[i] = num;

            //    }
            //    else break;

            //}
            //foreach (var item in DistinctNum)
            //{
            //    Console.WriteLine(item);
            //}
            //int firstmax = 0;
            //int secondmax = 0;
            //for (int i = 0; i < Numbers.Length; i++)
            //{

            //    if (Numbers[i] > firstmax) { firstmax = Numbers[i]; }
            //    for (int j = 0; j < Numbers.Length; j++)
            //    {
            //        if (Numbers[j] > secondmax && Numbers[j] == firstmax)
            //         break; 
            //        else 
            //         secondmax = Numbers[j];
            //    }     
            //}
            //Console.WriteLine($"second largest element in an array: {secondmax}");
            //int min = Numbers[0];
            //int indexmin = 0;
            //for (int i = 0;i < Numbers.Length; i++)
            //{
            //    if (Numbers[i] < min)
            //    {
            //        min = Numbers[i];
            //        indexmin = i;
            //    }
            //}
            //Console.WriteLine($"minimum element in an array:{min} index Number:{indexmin}");
            #endregion
            #region count

            //int count = 0;
            //for (int i = 0; i < 100000000; i++)
            //{
            //    string numberString = i.ToString();
            //    foreach (char c in numberString)
            //    {
            //        if (c == '1')
            //            count++;
            //    }

            //}
            //Console.WriteLine($"count the occurrence of 1: {count}");





            //    int count = 0; int n = 99999999;
            //    for (int i = 1; i <= n; i *= 10)
            //    {
            //        int lowerNumbers = n - (n / i) * i;
            //        int higherNumbers = n / (i * 10);
            //        int currentDigit = (n / i) % 10;

            //    if (currentDigit < 1)
            //        {
            //            count += higherNumbers * i;
            //        }
            //    else if (currentDigit == 1) 
            //        { 
            //            count += higherNumbers * i + lowerNumbers + 1; 
            //        } 
            //        else { count += (higherNumbers + 1) * i; }
            //    }
            //    Console.WriteLine($"count the occurrence of 1: {count}");
            //}



            #endregion
        }
    }
}
    