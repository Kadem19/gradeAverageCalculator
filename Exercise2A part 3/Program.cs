using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2A_part_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the grade average Calculator!");
            Console.WriteLine("Please enter a grade between 1 And 100 (you can use decimals)");
            Console.WriteLine("Once you are done entering grades press enter again to get your avg.");
            string gradesEntered;
            double totalOfGrades = 0;
            int numberofGrades = 0;
            while ((gradesEntered = Console.ReadLine()) != "")
            {
                totalOfGrades += double.Parse(gradesEntered);
                numberofGrades++;
            }

            double avgGrade = totalOfGrades / numberofGrades;

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
