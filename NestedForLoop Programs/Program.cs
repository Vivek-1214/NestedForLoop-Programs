
using alphabet;
using star;
using System;
namespace System
{
    class program
    {
        public static void Main(String[] args) {


            // pattern_10by10();
            // pattern_4by6();
            // pattern_7by12();
            //number_pattern_01();
            //number_pattern_01_rev();
            //number_pattern_02();
            //number_pattern_02_rev();

            StarPattern star = new StarPattern();
            // star .star_Pattern_01();
            // star.star_Pattern_02();
            //star.star_Pattern_03();
            // star.star_Pattern_04();
            // star.star_Pattern_05();
            // star.star_Pattern_06();
            star.star_Pattern_07();


            // star_Pattern_RightAngleTriangle_reverse();
            // number_pattern_RightAngleTriangle_reverse();
            //number_pattern_03();

            ABCDPattern P = new ABCDPattern();

      //  P.ABCD_pattern();
           // P.ABCD_pattern_rev();
          // P.abcd_pattern();
            // AAAA_pattern();
    // P.AAAA_pattern_rev();

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
            Console.WriteLine("__________________________________________________");
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
            Console.WriteLine("__________________________________________________");
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
            Console.WriteLine("__________________________________________________");
        }

        static void number_pattern_01()
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
            Console.WriteLine("__________________________________________________");
        }

        static void number_pattern_01_rev()
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
            Console.WriteLine("__________________________________________________");
        }

        static void number_pattern_02()
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
            Console.WriteLine("__________________________________________________");
        }

        static void number_pattern_02_rev()
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
            Console.WriteLine("__________________________________________________");
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
            Console.WriteLine("__________________________________________________");
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
            Console.WriteLine("__________________________________________________");
        }

        static void number_pattern_03()
  {
            Console.WriteLine("Enter no of rows");
            int r =Convert.ToInt32( Console.ReadLine());

            Console.WriteLine("Enter no of columns");
            int c = Convert.ToInt32(Console.ReadLine());

            int k = 1;                             //pattern
            for(int i = 1; i <= r; i++)    //row
            {
                for(int j = 1; j <= c; j++)   //coloumn
                {
                    Console.Write((k++) +" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("__________________________________________________");
        }








    }
}
