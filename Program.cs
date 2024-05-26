using System;

class Program
{
    static void Main()
    {
        int age;

        Console.Write("Enter your age: ");
        age = Convert.ToInt32(Console.ReadLine());

        if (age >= 18)
        {
            Console.WriteLine("Congratulation! You are eligible for casting your vote.");
        }
        else
        {
            Console.WriteLine("Sorry, you are not eligible to cast your vote.");
        }

        Console.ReadLine(); 
    }
}