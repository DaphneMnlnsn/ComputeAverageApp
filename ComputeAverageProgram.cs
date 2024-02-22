using System;

namespace ComputeAverageApp
{
    class ComputeAverageProgram
    {
        static void Main(string[] args)
        {
            double grade1, grade2, grade3, grade4, grade5, average, round;

            Console.WriteLine("Enter 5 grades separated by new line: ");
            grade1 = Convert.ToDouble(Console.ReadLine());
            grade2 = Convert.ToDouble(Console.ReadLine());
            grade3 = Convert.ToDouble(Console.ReadLine());
            grade4 = Convert.ToDouble(Console.ReadLine());
            grade5 = Convert.ToDouble(Console.ReadLine());

            average = (grade1 + grade2 + grade3 + grade4 + grade5) / 5;
            round = Math.Round(average);

            Console.WriteLine("The average is " + average + " and round off to " + round);
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}