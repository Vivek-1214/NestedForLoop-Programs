
using System;
namespace Nested
{
    class program
    {
        public static void Main(String[] args)
        {
            /*1)Write a program  to display the pattern like right angle triangle 

            for(int i = 1; i <= 10; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }*/

            /*2)Write a program  to display the pattern like reverse right angle triangle 

            for (int i = 10; i >=0 ; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }*/

            /* 3)Write a program to display the number like right angle triangle

            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }*/

            /*4) Write a program pattern like right angle triangle with a number which will repeat a number in a row

            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }*/

            //5)Write a program  to display the pattern like a pyramid 

            //5) write a program which shows table from 2 to 5 in on frame
            int table;
            for(int i = 2; i <= 5; i++)
            {
                for(int j=1;j<=10;j++)
                {
                    table=i* j;                    // 2,4,6,8....20

                    Console.WriteLine(table);
                } Console.WriteLine();
            }

        }
    }
}
