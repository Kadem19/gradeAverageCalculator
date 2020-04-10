using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2A_part_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Grade Avg Calculator!");
            Console.WriteLine("How many grades would you like to enter?");
            int numGrades = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter {0} grades!", numGrades);
            Console.WriteLine("Once you have entered {0} grades your average will be shown.", numGrades);

            int gradesEntered = 0;
            float gradesTotal = 0;

            do
            {
                string grade = Console.ReadLine();
                gradesTotal += float.Parse(grade);
                gradesEntered++;
            }

            while (gradesEntered < numGrades);
           

            float avgGrade = gradesTotal / gradesEntered;

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
