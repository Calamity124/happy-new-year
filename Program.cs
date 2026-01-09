using System;

class Program
{
    static void Main()
    {
        
        int option = 0;
        do
        {
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine("\n===Student Utility===");
        Console.WriteLine("1. Add two numbers \n2. Check if number is even or odd \n3. Calculate the average of 5 numbers \n4. Guessing game \n5. Exit");
        Console.ResetColor();
       
       try
        {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("Choose an option: ");
        option =Convert.ToInt32(Console.ReadLine());
        Console.ResetColor();

        Console.Clear();

        switch (option)
        {
            case 1: 
            addNumbers();
            break;

            case 2:
            CheckEvenOdd();
            break;

            case 3:
            Calculator();
            break;

            case 4:
            GuessGame();
            break;

            case 5:
            Console.WriteLine("Thank you!");
            break;

            default:
            Console.WriteLine("Invalid Option!");
            break;
        }
        }
        catch (FormatException)
            {
                Console.Clear();
                Console.WriteLine("Invalid Option!");
                
            }
        } while (option !=5);
        
    }

    static int addNumbers()
    {
        int a = 0;
        int b = 0;
        int result = 0;
        

        try
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

        Console.WriteLine("---Adding two numbers---");

        Console.Write("Enter a number: ");
        a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter a number: ");
        b = Convert.ToInt32(Console.ReadLine());
        
        result = a + b;

        Console.WriteLine($"\nThe sum of {a} and {b} is: " + result);
        
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid Input!");
        }    
        Console.WriteLine("");
        Console.ResetColor();
   
        return result;
        
    }


    static int CheckEvenOdd()
    {
         Console.ForegroundColor = ConsoleColor.Green;
        int a = 0;
        Console.WriteLine("---Odd or Even---");

        Console.Write("Enter a number: ");
        a = Convert.ToInt32(Console.ReadLine());

        if (a % 2 == 0)
        {
            Console.WriteLine("The number is Even.");
        }
        else
        {
            Console.WriteLine("The number is Odd.");
        }
        Console.WriteLine("");
        
        Console.ResetColor();

        return a;
    }
    
    static double Calculator()
    {
        int[] numbers = new int[5];
        double sum = 0;
        double average;

        Console.WriteLine("----- Average Calculator -----");
       

        for ( int i = 0; i < numbers.Length; i++)
        {
            Console.Write($"Enter your {i + 1} input: ");
            numbers[i] = Convert.ToInt32(Console.ReadLine());  
            sum += numbers[i];      
        }
        Console.WriteLine($"The sum of all numbers is {sum} ");  

        average = sum / numbers.Length;
        Console.WriteLine($"The average of {sum} is {average}");
        Console.WriteLine("");

        
        
        return average;
        
    }

    static int GuessGame()
    {
        int guess = 0;
        int guesses = 0; 

        Random random = new Random();

        int num = random.Next(1, 11);

        Console.WriteLine("------- Guessing Number Game -------");

        while (guess != num)
        {
            try
            {
        Console.Write("Enter your guess: ");
        guess = Convert.ToInt32(Console.ReadLine()); 
        guesses++;

        Console.WriteLine("Guesses: " +  guesses);
           
       if (guess < num)
        {
            Console.WriteLine($"{guess} is too low! ");
        }
        else if (guess > num)
        {
            Console.WriteLine($"{guess} is too high! ");
        }
       
         }
        catch (FormatException)
        {
            Console.WriteLine("Incorrect Input!");
        }

        }

        Console.WriteLine($"\nYou Won! The secret number is {num}");
        Console.WriteLine("");

        return guess;
    }
}

