using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2a
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the addition game.");
            Console.WriteLine("Enter ten numbers to be added between 1 and 100 and you will be given an answer at the end!");
            Console.WriteLine("Press any key to play...");
            Console.ReadLine();

            Console.WriteLine("Please enter your first of ten numbers between 0 and 100");
            int num1 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Please enter your second number between 0 and 100");
            int num2 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Please enter your third number between 0 and 100");
            int num3 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Please enter your fourth number between 0 and 100");
            int num4 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Please enter your fith number between 0 and 100");
            int num5 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Please enter your sixth number between 0 and 100");
            int num6 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Please enter your seventh number between 0 and 100");
            int num7 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Please enter your eighth number between 0 and 100");
            int num8 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Please enter your ninth number between 0 and 100");
            int num9 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Please enter your tenth number between 0 and 100");
            int num10 = int.Parse(Console.ReadLine());

            Console.WriteLine("Your answer is " + (num1 + num2 + num3 + num4 + num5 + num6 + num7 + num8 + num9 + num10));
        }
    }
}
