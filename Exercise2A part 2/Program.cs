using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2A_part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the score average game!");
            Console.WriteLine("Please Enter 10 grades to see your average grade and letter!");
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();

            Console.WriteLine("Please enter your first grade between 1 and 100 (you can use decimals)");
            float grade1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Please enter your second grade");
            float grade2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Please enter your third grade");
            float grade3 = float.Parse(Console.ReadLine());

            Console.WriteLine("Please enter your fourth grade");
            float grade4 = float.Parse(Console.ReadLine());

            Console.WriteLine("Please enter your fifth grade");
            float grade5 = float.Parse(Console.ReadLine());

            Console.WriteLine("Please enter your sixth grade");
            float grade6 = float.Parse(Console.ReadLine());

            Console.WriteLine("Please enter your seventh grade");
            float grade7 = float.Parse(Console.ReadLine());

            Console.WriteLine("Please enter your eighth grade");
            float grade8 = float.Parse(Console.ReadLine());

            Console.WriteLine("Please enter your ninth grade");
            float grade9 = float.Parse(Console.ReadLine());

            Console.WriteLine("Please enter your tenth grade");
            float grade10 = float.Parse(Console.ReadLine());

            float avgGrade = (grade1 + grade2 + grade3 + grade4 + grade5 + grade6 + grade7 + grade8 + grade9 + grade10) / 10;

            if (avgGrade >= 90)
            {
                Console.WriteLine("Your average score is a " + avgGrade + ". Which is an A.");
            }

            else if (avgGrade >= 80)
            {
                Console.WriteLine("Your average score is an " + avgGrade + ". Which is a B.");
            }
            
            else if (avgGrade >= 70)
            {
                Console.WriteLine("Your average score is a " + avgGrade + ". Which is a C.");
            }

            else if (avgGrade <= 79)
            {
                Console.WriteLine("Your average score is a " + avgGrade + ". Which is a D.");
            }

        }
    }
}
