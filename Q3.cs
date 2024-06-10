using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam2
{
    class All
    {
        public delegate int AreaDelegate(int length, int width);
        public delegate int GreaterDelegate(int n1, int n2);
        public delegate int PowerDelegate(int n, int p);

        public int Area(int length, int width)
        {
            return length * width;
        }

        public int Greater(int n1, int n2)
        {
            if(n1 > n2)
            {
                return n1;
            }
            else
            {
                return n2;
            }
        }

        public int Power(int n, int p)
        {
            int r = (int)Math.Pow(n, p);

            return r;
        }
    }

    internal class Q3
    {
        static void Main(string[] args)
        {
            All obj = new All();

            // Delegate for area function
            All.AreaDelegate areaDelegate = obj.Area;
            int area = areaDelegate(5, 3);

            // Delegate for greater function
            All.GreaterDelegate greaterDelegate = obj.Greater;
            int greaterValue = greaterDelegate(10, 20);

            // Delegate for power function
            All.PowerDelegate powerDelegate = obj.Power;
            int powerValue = powerDelegate(5, 2);

            Console.WriteLine($"Area: {area}");
            Console.WriteLine($"Greater value: {greaterValue}");
            Console.WriteLine($"Power: {powerValue}");
        }
    }
}
