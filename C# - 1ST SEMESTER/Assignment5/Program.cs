using System.ComponentModel.Design;

namespace Assignment5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region VARIABLES
            double double1, double2, double3;
            const int numberOfGrades = 10;
            double sumGrades = 0;
            #endregion

            int option = 0;
            while (true)
            {
                #region MENU
                Console.WriteLine("Select an exercise number to enter the aplication: ");
                Console.WriteLine();
                Console.WriteLine("MENU");
                Console.WriteLine("1. Exercise 1");
                Console.WriteLine("2. Exercise 2");
                Console.WriteLine("3. Exercise 3");
                Console.WriteLine("4. Exercise 4");
                Console.WriteLine("5. Exercise 5");
                Console.WriteLine("6. Exercise 6");
                Console.WriteLine("7. Exit program");
                Console.WriteLine();
                Console.Write("Enter an option: ");
                option = int.Parse(Console.ReadLine());
                #endregion
                switch (option)
                {
                    #region EXERCISE 1
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Exercise 1: Create a program that asks the user to enter 2 doubles: " +
                            "\na minimum and a maximum. The program then asks the user to enter a third double between " +
                            "\nthe minimum and maximum. Check if the third number is inside the range, and, using a " +
                            "\nloop, prompt the user to try again until the entered number is actually inside the range " +
                            "\n(no matter how many tries it takes). Once the number they entered is valid, output their " +
                            "\nnumber back to them along with a success message.\n");
                        Thread.Sleep(500);

                        Console.WriteLine("Write a double number: ");
                        double1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Write a second double number bigger than the first double number: ");
                        double2 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Write a third double number: ");
                        double3 = double.Parse(Console.ReadLine());
                        Console.WriteLine("");
                        Console.Clear();

                        if (double3 <= double1 && double3 >= double2)
                        {
                            Console.WriteLine(double3 + " is inside the range between " + double1 + " and " + double2 + "\n");
                        }
                        else if (double3 >= double1 && double3 <= double2)
                        {
                            Console.WriteLine(double3 + " is inside the range between " + double1 + " and " + double2);
                        }
                        else
                        {
                            Console.WriteLine(double3 + " is not inside the range between " + double1 + " and " + double2 + "\n");
                        }
                        Console.WriteLine();
                        Console.WriteLine("Let's go back to the menu.");
                        Thread.Sleep(2000);
                        break;
                    #endregion
                    #region EXERCISE 2
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Exercise 2 - Create a program that asks the user for an integer, and then outputs the factorial" +
                            "\nof that integer. The factorial of a number is the product of all the integers from 1 to that number. " +
                            "\nFor example, the factorial of 6 is 1*2*3*4*5*6 = 720 . Factorial is not defined for negative numbers, and " +
                            "\nthe factorial of zero is one.");
                        Thread.Sleep(500);

                        Console.Write("\nPlease, write a number you want to know its factorial: ");
                        int number = int.Parse(Console.ReadLine());
                        while (number < 0)
                        {
                            Console.Write("\nFactorial is not defined for negative numbers. Please enter another value: ");
                            number = int.Parse(Console.ReadLine());
                        }
                        int factorial = 1;
                        for (int i = 1; i <= number; i++)
                        {
                            factorial = factorial * i;
                        }
                        Console.WriteLine($"\nThe factorial of {number} is {factorial}");
                        Thread.Sleep(1500);
                        break;
                    #endregion
                    #region EXERCISE 3
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Exercise 3 - Write an algorithm that calculates the sum of all the integers " +
                            "\ncontained (inclusively) between two positive integer limits entered by the user. " +
                            "\nThe program reads the smallest limit first.");
                        Thread.Sleep(500);

                        int numberOne, numberTwo;

                        Console.Write("\nPlease enter any positive number: ");
                        numberOne = int.Parse(Console.ReadLine());

                        while (numberOne < 0)
                        {
                            Console.Write("\nThe number you entered was not a positive one. Please type another one: ");
                            numberOne = int.Parse(Console.ReadLine());
                        }
                        Console.Write("Please enter a second positive number: ");
                        numberTwo = int.Parse(Console.ReadLine());

                        while (numberTwo < 0)
                        {
                            Console.Write("\nThe second number you entered was not a positive one. Please type another one: ");
                            numberTwo = int.Parse(Console.ReadLine());
                        }
                        int minorNumber, majorNumber;
                        if (numberOne < numberTwo)
                        {
                            minorNumber = numberOne;
                            majorNumber = numberTwo;
                        }
                        else
                        {
                            minorNumber = numberTwo;
                            majorNumber = numberOne;
                        }
                        int sum = 0;
                        for (int i = minorNumber; i <= majorNumber; i++)
                        {
                            sum += i;
                        }
                        Console.WriteLine($"\nThe sum of all numbers between {numberOne} and {numberTwo} is {sum}");
                        Thread.Sleep(2000);
                        break;
                    #endregion
                    #region EXERCISE 4
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Exercise 4 - Create four algorithms, each one displaying the following sequences:" +
                            "\n\na) 5 10 15 20 25 30 35 40" +
                            "\nb) 3 5 7 9 11 13 15" +
                            "\nc) 80 70 60 50 40 30 20" +
                            "\nd) 1 2 6 24 120 720");
                        Thread.Sleep(500);

                        Console.Write("\nType the sequence letter you want to check: ");
                        char choice = Console.ReadKey().KeyChar;
                        Console.ReadLine();
                        do
                        {
                            while (true)
                            {
                                if (choice == 'a')
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("Sequence a): \n5 10 15 20 25 30 35 40.");
                                    Thread.Sleep(2000);
                                    break;
                                }
                                else if (choice == 'b')
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("Sequence b):\n3 5 7 9 11 13 15");
                                    Thread.Sleep(2000);
                                    break;
                                }
                                else if (choice == 'c')
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("Sequence c):\n80 70 60 50 40 30 20");
                                    Thread.Sleep(2000);
                                    break;
                                }
                                else if (choice == 'd')
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("Sequence d):\n1 2 6 24 120 720");
                                    Thread.Sleep(2000);
                                    break;
                                }
                                else
                                {
                                    Console.Write("You entered an inexisting letter. Please type another letter from a to d: ");
                                    choice = Console.ReadKey().KeyChar;
                                    Console.ReadLine();
                                }
                            }
                        } while (false);
                        break;
                    #endregion
                    #region EXERCISE 5
                    case 5:
                        Console.Clear();
                        Console.WriteLine("Exercise 5 - Write a program that calculates the average of 10 grades. " +
                            "\nThe program asks the user for each of the grades.");
                        Thread.Sleep(500);

                        Console.WriteLine("\nEnter 10 grades to calculate their average:\n");

                        for (int i = 0; i < numberOfGrades; i++)
                        {
                            Console.Write("Enter grade #{0}: ", i + 1);

                            if (double.TryParse(Console.ReadLine(), out double grade) && grade >= 0)
                            {
                                sumGrades += grade;
                            }
                            else
                            {
                                Console.WriteLine("Invalid input. Please enter a valid numeric value.");
                                i--;
                            }
                        }
                        double average = sumGrades / numberOfGrades;
                        Console.WriteLine("\nThe average of the grades is: " + average);
                        Thread.Sleep(2000);
                        break;
                    #endregion
                    #region EXERCISE 6
                    case 6:
                        Console.Clear();
                        Console.WriteLine("Exercise 6 - Write an algorithm that displays the first 100 numbers of the Fibonacci sequence. " +
                            "\nThis sequence begins with the numbers 1, 1, 2, 3, 5, 8, …, where each new number in the sequence can be " +
                            "\nfound by adding the two previous numbers in the sequence.\n");
                        Thread.Sleep(500);

                        ulong a = 1, b = 1;

                        Console.Write("1 1 ");

                        for (int i = 3; i <= 100; i++)
                        {
                            ulong fib = a + b;
                            Console.Write(fib + " ");
                            Thread.Sleep(10);
                            a = b;
                            b = fib;
                        }
                        Console.WriteLine();
                        Thread.Sleep(2000);
                        break;
                    #endregion
                    #region EXERCISE 7
                    case 7:
                        Console.WriteLine("\nEnding aplication. Have a great day!");
                        Thread.Sleep(2000);
                        Environment.Exit(0);
                        break;
                    #endregion
                    #region DEFAULT
                    default:
                        Console.WriteLine("The number you enter is not in the exercise range. Try another one");
                        break;
                    #endregion
                }
                Thread.Sleep(1500);
                Console.Clear();
            }
        }
    }
}