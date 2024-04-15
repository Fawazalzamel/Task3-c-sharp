//Task 1 of LINQ
using System;
using System.Linq;



class evenNumFunction
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5 };

        var evenNumbers = numbers.Where(n => n % 2 == 0);

        foreach (var number in evenNumbers)
        {
            Console.WriteLine(number);
        }
    }
}

//Task 2 LINQ

class avgStudentGrades
{
    static void Main()
    {

        int[] grades = { 52, 82, 63, 94, 95 };


        var avgGrades = grades.Average();
        Console.WriteLine(avgGrades);
    }

}

//Task Functions 1


class Greeting
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your name?");
        string name = Console.ReadLine();

        GreetUser(name);
    }

    static void GreetUser(string name)
    {
        Console.WriteLine($"Hello {name}");
    }
}


//Task 2 Functions

class calculateVolume { 
    static void Main() {

        Console.WriteLine("What is your length?");
        string lengthInput = Console.ReadLine();

        double.TryParse(lengthInput, out var length);

        Console.WriteLine("What is your width?");
        string widthInput = Console.ReadLine();

        double.TryParse(lengthInput, out var width);

        Console.WriteLine("What is your height?");
        string heightInput = Console.ReadLine();

        double.TryParse(lengthInput, out var height);

        Console.WriteLine($"The Volume is {length*width*height}");
       
    }

    
}