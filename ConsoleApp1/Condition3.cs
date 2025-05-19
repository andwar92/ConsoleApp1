using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Condition3
    {
        bool isEqual = true;
        int a = 10;
        int b = 30;

        public void Run()
        {
            int c = 0;
            if (a < b)
            {

                isEqual = true;
                Console.WriteLine("True");
             
            }
            else
            {
                isEqual = false;
                Console.WriteLine("False");
            }
        }
    }
}
