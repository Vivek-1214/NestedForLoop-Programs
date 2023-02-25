
using System;
namespace Nested
{
    class program
    {
        public static void Main(String[] args) { 

            //write a program which shows table from 2 to 5 in on frame
             int table;
             
             for(int i = 2; i <= 5; i++)
             {
                 for(int j=1;j<=10;j++)
                 {
                     table=i* j;                    // 2,4,6,8....20

                     Console.WriteLine(table);
                 } Console.WriteLine();
             }

            // pattern_10by10();
            // pattern_4by6();
            // pattern_7by12();
            //number_pattern_1234();
            //number_pattern_54321();
            //number_pattern_11111();
            //number_pattern_55555();

            //star_Pattern_RightAngleTriangle();
            //number_Pattern_RightAngleTriangle();

            // star_Pattern_RightAngleTriangle_reverse();
            // number_pattern_RightAngleTriangle_reverse();

        }

        static void pattern_10by10()
        {
            //print * pattern 10 * 10

             for (int i = 1; i <= 10; i++)
             {
                 for(int j = 1; j <= 10; j++)
                 {
                     Console.Write('*');
                 }
                    Console.WriteLine();
             }
        }

        static void pattern_4by6()
        {
            //print * pattern 4 * 6

            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 6; j++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
        }

        static void pattern_7by12()
        {   //print * pattern 7 * 12
            for (int i = 1; i <= 7; i++)
            {
                for(int j = 1; j <= 12; j++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
        }

        static void number_pattern_1234()
        {
            //print no. pattern of 5 rows like 1234

            for(int i = 1; i <= 5; i++)
            {
                for(int j = 1; j <= 5; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }

        static void number_pattern_54321()
 {
            //print no. pattern of 5 rows like 54321

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 5; j >=1; j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }

        static void number_pattern_11111()
        {
            //print no. pattern of 5 rows like 11111

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }

        static void number_pattern_55555()
        {
            //print no. pattern of 5 rows like 55555

            for (int i = 5; i >= 1; i--)
            {
                for (int j = 1; j <= 5; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }

        static void star_Pattern_RightAngleTriangle()
        {
            //Write a program  to display the " * " pattern like right angle triangle 

            for (int i = 1; i <= 5; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write('*'); 
                }
                Console.WriteLine();
            }
        }

        static void  number_Pattern_RightAngleTriangle()
        {
            //prine no. pattern of 5 rows  base on number of rows

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }

        static void star_Pattern_RightAngleTriangle_reverse()
        {
            //prine star pattern of 5 rows  base on number of rows reverse

            for (int i = 5; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
        }

        static void number_pattern_RightAngleTriangle_reverse()
        {
            //prine no. pattern of 5 rows  base on number of rows reverse

            for (int i = 5; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }







    }
}
