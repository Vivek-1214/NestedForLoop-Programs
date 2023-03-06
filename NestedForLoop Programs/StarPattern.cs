using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace star
{
    internal class StarPattern
    { 
        
        public void star_Pattern_01()
        {
            //Write a program  to display the " * " pattern like right angle triangle 

            int num=10;
            for (int i=1;i<=num;i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine("__________________________________________________");
        }
        public void star_Pattern_02()
        {
            //prine star pattern of 5 rows  base on number of rows reverse

            for (int i = 10; i >= 1; i--)
            {
                for (int j = i; j >= 1; j--)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
            Console.WriteLine("__________________________________________________");
        }
        public void star_Pattern_03()
        {
            int num = 5;
            for (int i = 1; i <= num; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
            for (int i = 5; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }

        }

        public void star_Pattern_04()
        {
            int num = 10;

            for(int i=1;i<=num;i++)
            {
                for(int j = num - i; j>=1; j--)
                {
                    Console.Write(" ");
                }
                for(int k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
              
            }
            Console.WriteLine("__________________________________________________");
        }
        public void star_Pattern_05()
        {
            int num = 10;
                for (int i = 1; i <=num; i++)
                {
                    for (int j =1; j <= i; j++)
                    {
                        Console.Write(" ");
                    }
                    for (int k = num-i; k >=1; k--)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();

                
            }
            Console.WriteLine("__________________________________________________");
        }

        public void star_Pattern_06()
        {
            int num = 10;

            for (int i = 1; i <= num; i++)
            {
                for (int j = num - i; j >= 1; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }
                for (int l = 1; l <= i; l++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                Console.WriteLine();

            }
        }

        public  void star_Pattern_07()
        { int num=5;
            for (int i = 1; i <= num; i++)
            {
                for(int j = num - i;j >= 1;j--)
                {
                    Console.Write(" ");
                }
                for(int k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
           for(int i = 1; i <= 5; i++)
            {
                for(int j=1;j<=i; j++)
                {
                    Console.Write(" ");
                }
                for(int k=num-i;k>=1; k--)
                {
                    Console.Write("*");
                }
                for (int k = num - i; k >= 1; k--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        }

            
        }

