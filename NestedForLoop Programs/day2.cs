using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Days2
{
    internal class ABCDPattern
    {

         public void ABCD_pattern()
        {

            Console.WriteLine("Enter no of rows");
            int r = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter no of columns");
            int c = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= r; i++)    //row
            {
                for (int j = 1; j <= c; j++)   //coloumn
                {
                    Console.Write(Convert.ToChar(64 + j));
                }
                Console.WriteLine();
            }
            Console.WriteLine("__________________________________________________");
        }

            public void ABCD_pattern_rev()
                {

            Console.WriteLine("Enter no of rows");
            int r = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter no of columns");
            int c = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= r; i++)    //row
            {
                for (int j = c; j >= 1; j--)   //coloumn
                {
                    Console.Write(Convert.ToChar(64 + j));
                }
                Console.WriteLine();
            }
            Console.WriteLine("__________________________________________________");
        }

        public void abcd_pattern()
        {

            Console.WriteLine("Enter no of rows");
            int r = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter no of columns");
            int c = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= r; i++)    //row
            {
                for (int j = 1; j <= c; j++)   //coloumn
                {
                    Console.Write(Convert.ToChar(96 + j));
                }
                Console.WriteLine();
            }
            Console.WriteLine("__________________________________________________");
        }

        public void AAAA_pattern()
        {

            Console.WriteLine("Enter no of rows");
            int r = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter no of columns");
            int c = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= r; i++)    //row
            {
                for (int j = 1; j <= c; j++)   //coloumn
                {
                    Console.Write(Convert.ToChar(64 + i));
                }
                Console.WriteLine();
            }
            Console.WriteLine("__________________________________________________");
        }

        public void AAAA_pattern_rev()
        {

            Console.WriteLine("Enter no of rows");
            int r = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter no of columns");
            int c = Convert.ToInt32(Console.ReadLine());

            for (int i = r; i >= 1; i--)    //row
            {
                for (int j = 1; j <= c; j++)   //coloumn
                {
                    Console.Write(Convert.ToChar(64 + i));
                }
                Console.WriteLine();
            }
            Console.WriteLine("__________________________________________________");
        }
    }
}
