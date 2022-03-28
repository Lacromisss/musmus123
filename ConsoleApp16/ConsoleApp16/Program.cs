using System;

namespace ConsoleApp16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fullName,grupNo;
            do
            {
                Console.WriteLine("tam ad daxil edin");
                fullName = Console.ReadLine();
            } while (!Student.CheckFullName(fullName));
            
            
            do
            {
                Console.WriteLine("no daxil edin :");
                grupNo = Console.ReadLine();
            } while (!Student.CheckGroupNo(grupNo));

            Console.WriteLine("yas daxil et :");
            int Age = int.Parse(Console.ReadLine());


            Student student = new Student(fullName, grupNo, Age);


            
        }
    }
}
