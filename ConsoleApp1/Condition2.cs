using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Condition2
    {
        bool isEqual = true;
        int A = 20;
        int B = 20; 

        public int Sum(int A, int B)
        {
             int pluss = 0;
             int gange = 0;
            if (A != B)
            {
                Console.WriteLine("A og B er ulike, så jeg regner ut summen av de!");
                isEqual = false;
                pluss = A + B;
            }
            else
            {
                Console.WriteLine("A og B er like, så jeg multipliserer dem!");
                isEqual = true;
                gange = A * B;
            }

            if (isEqual)
            {
                return gange;
            }
            else
            {
                return pluss;
            }
        }

        public void Run()
        {
            Console.WriteLine($"Dette er resultatet:{Sum(A,B)}");
        }
    }
}
