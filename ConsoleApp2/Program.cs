using System;
public class Program
{
    public static void Main()
    {
        Console.WriteLine("Task 1");
        // Declaring and initializing variables
        string name = "John Doe";
        int age = 25;
        bool isAdmin = true;

        // Printing the values to console
        Console.WriteLine("Full Name: " + name);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Admin Status: " + isAdmin);
        Console.WriteLine();

        // Calling other  method
        Numbers();
        Console.WriteLine();

        Loop();
        Console.WriteLine();

        Array();
        Console.WriteLine();

        Greet("Alice");
    }

    public static void Numbers()
    {
        Console.WriteLine("Task 2");
        //enter number
        Console.Write("Enter an integer: ");

        int number = Convert.ToInt32(Console.ReadLine());

        // Check if number is even or odd by returning the remainder of the division of number by 2
        if (number % 2 == 0)
        {
            Console.WriteLine("Even");
        }
        else
        {
            Console.WriteLine("Odd");
        }

    }

    public static void Loop()
    {
        Console.WriteLine("Task 3");

        int Num = 1;

        for (int i = Num; i <= 10; i++)
        {
            Console.WriteLine(i);
        }
    }

    public static void Array()
    {
        Console.WriteLine("Task 4");
        // Declaring array
        int[] numbers = { 2, 4, 6, 8, 10 };

        int sum = 0;

        foreach (int number in numbers)
        {
            sum += number;
            Console.WriteLine("Number: " + number);
        }

        Console.WriteLine("Total numbers = " + sum);
    }

    public static void Greet(string name)
    {
        Console.WriteLine("Task 5");
        Console.WriteLine("Hello, " + name + "!");
    }
}


