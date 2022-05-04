using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringReverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter any string to Reverse: ");
            string name = Console.ReadLine();

            string revname = "";

            foreach(char item in name)
            {
                revname = item + revname;
            }
            Console.WriteLine(revname + " Revers of " + name);

            Console.ReadLine();
        }
    }
}
