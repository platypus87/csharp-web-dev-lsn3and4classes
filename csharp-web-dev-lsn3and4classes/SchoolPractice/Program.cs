using System;

namespace SchoolPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            // TODO: Instantiate your objects and test your exercise solutions with print statements here.
            Student Mart = new Student();
            Mart.Name = "Mart";
            Mart.NumberOfCredits = 1;
            Mart.Gpa = 4.0;
            Console.WriteLine(Mart.Name);
            Console.WriteLine(Mart.NumberOfCredits);
            Console.WriteLine(Mart.Gpa);
        }
    }
}
