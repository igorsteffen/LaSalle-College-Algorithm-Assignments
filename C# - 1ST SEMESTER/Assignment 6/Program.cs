using System;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;

namespace Assignment_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ASSIGNMENT 6 - ONLY THE ODD ONES! (1,3,5 AND 7);

            #region FUNCTIONS
            static bool ehPrimo(int numberChosen)
            {
                if (numberChosen <= 1)
                {
                    return false;
                }
                if (numberChosen <= 3)
                {
                    return true;
                }
                if (numberChosen % 2 == 0 || numberChosen % 3 == 0)
                {
                    return false;
                }

                for (int i = 5; i * i <= numberChosen; i += 6)
                {
                    if (numberChosen % i == 0 || numberChosen % (i + 2) == 0)
                        return false;
                }
                return true;
            }

            static int primeNumbersRange(int N)
            {
                int primeCount = 0;
                for (int i = 1; i <= N; i++)
                {
                    if (ehPrimo(i))
                    {
                        Console.Write(i + " ");
                        primeCount++;
                        //Thread.Sleep(1);
                    }
                }
                return primeCount;
            }
            #endregion

            #region VARIABLES
            int option = 0;
            int decision = 1, numberN = 0, sequence = 1, anotherTry = 1, numberChosen;
            #endregion

            #region INTRODUCTION
            Console.WriteLine("\n\n\n\n\n\n\n\n\n");
            Console.WriteLine("ASSIGNMENT 6 \nGROUP 9 \nIGOR STEFFEN \nEXERCISES RELATED TO GROUP 9: 1,3,5 and 7\n");
            Thread.Sleep(500);
            Console.Write("LOADING");
            Thread.Sleep(300);
            Console.Write(".");
            Thread.Sleep(300);
            Console.Write(".");
            Thread.Sleep(300);
            Console.Write(".");
            Thread.Sleep(300);
            Console.Clear();
            #endregion

            while (true)
            {
                #region MENU                 
                Console.WriteLine("EXERCISE MENU: \n");
                Console.WriteLine("1 - Exercise 1");
                Console.WriteLine("2 - Exercise 3");
                Console.WriteLine("3 - Exercise 5");
                Console.WriteLine("4 - Exercise 7");
                Console.WriteLine("5 - EXIT MENU");
                Console.WriteLine();
                Console.Write("Please, select the exercise you want to see: ");
                while (!Int32.TryParse(Console.ReadLine(), out option) || option < 1 || option > 5)
                {
                    Console.Clear();
                    Console.WriteLine("\n\n\n\n\n\n\n\n");
                    Console.WriteLine("PLEASE USE ONLY NUMBERS BETWEEN 1 AND 5. TRY AGAIN");
                    Thread.Sleep(500);
                    Console.Write("REDIRECTING TO MENU");
                    Thread.Sleep(500);
                    Console.Write(".");
                    Thread.Sleep(500);
                    Console.Write(".");
                    Thread.Sleep(500);
                    Console.Write(".");
                    Thread.Sleep(500);
                    Console.Clear();
                    break;
                    #endregion
                }
                switch (option)
                {
                    #region EXERCISE 1
                    case 1:
                        while (decision == 1)
                        {
                            Console.Clear();
                            Console.WriteLine("YOU HAVE SELECTED OPTION 1 - EXERCISE 1\n");
                            string texto1 = "Write a program that asks a number 'n' to the user, \nthen the program must to read 'n' numbers and \ndetermines the largest and the smallest. \n'n' number must be >= 1\n";
                            foreach (char letra in texto1)
                            {
                                Console.Write(letra);
                                Thread.Sleep(1);
                            }
                            Console.WriteLine();
                            Console.Write("Please write a number(any number >= 1): ");

                            while (!Int32.TryParse(Console.ReadLine(), out numberN) || numberN < 1)
                            {
                                Console.Clear();
                                Console.WriteLine("\n\n\n\n\n\n\n\n");
                                Console.WriteLine("PLEASE USE ONLY NUMBERS GREATER THAN 1. TRY AGAIN");
                                Thread.Sleep(500);
                                Console.Write("REDIRECTING TO THE QUESTION");
                                Thread.Sleep(500);
                                Console.Write(".");
                                Thread.Sleep(500);
                                Console.Write(".");
                                Thread.Sleep(500);
                                Console.Write(".");
                                Thread.Sleep(500);
                                Console.Clear();
                                Console.Write("Please write a number(any number >= 1): ");
                                continue;
                            }
                            Console.WriteLine();
                            for (int i = 1; i <= numberN; i++)
                            {
                                if (i > 1)
                                {
                                    Console.Write(" ");
                                }
                                string iAsString = i.ToString();
                                foreach (char digito in iAsString)
                                {
                                    Console.Write(digito);
                                    Thread.Sleep(1);
                                }
                            }
                            Console.WriteLine($"\nThe smallest number is 1 and the largest number is {numberN}");
                            Thread.Sleep(1000);

                            Console.WriteLine("\nWanna try again? \n1 - Yes \n2 - No\n");
                            while (!Int32.TryParse(Console.ReadLine(), out decision))
                            {
                                Console.Clear();
                                Console.WriteLine("\n\n\n\n\n\n\n\n");
                                Console.WriteLine("PLEASE USE ONLY NUMBERS");
                                Thread.Sleep(500);
                                Console.Write(".");
                                Thread.Sleep(500);
                                Console.Write(".");
                                Thread.Sleep(500);
                                Console.Write(".");
                                Thread.Sleep(500);
                                Console.Clear();
                                Console.WriteLine("\nWanna try again? \n1 - Yes \n2 - No\n");
                                continue;
                            }
                        }
                        Console.WriteLine("\n");
                        Console.Write("REDIRECTING TO MENU");
                        Thread.Sleep(300);
                        Console.Write(".");
                        Thread.Sleep(300);
                        Console.Write(".");
                        Thread.Sleep(300);
                        Console.Write(".");
                        Thread.Sleep(300);
                        Console.Clear();
                        break;
                    #endregion
                    #region EXERCISE 2
                    case 2:
                        Console.Clear();
                        Console.WriteLine("YOU HAVE SELECTED OPTION 2 - EXERCISE 3\n");
                        string texto2 = "Write a C++ program that prints out the following output on the screen: \n\n@\n@@\n@@@\n@@@@\n@@@@@\n@@@@\n@@@\n@@\n@\n";
                        foreach (char letra in texto2)
                        {
                            Console.Write(letra);
                            Thread.Sleep(1);
                        }
                        Console.Write("\nPress 1 to print de sequence or any other number to go back to menu: ");
                        while (!Int32.TryParse(Console.ReadLine(), out sequence))
                        {
                            Console.Clear();
                            Console.WriteLine("\n\n\n\n\n\n\n\n");
                            Console.WriteLine("PLEASE USE ONLY NUMBERS. TRY AGAIN");
                            Thread.Sleep(500);
                            Console.Write("REDIRECTING TO THE QUESTION");
                            Thread.Sleep(500);
                            Console.Write(".");
                            Thread.Sleep(500);
                            Console.Write(".");
                            Thread.Sleep(500);
                            Console.Write(".");
                            Thread.Sleep(500);
                            Console.Clear();
                            Console.Write("\nPress 1 to print de sequence or any other number to go back to menu: ");
                            continue;
                        }
                        Console.Clear();
                        Console.WriteLine();
                        while (sequence == 1)
                        {
                            int firstHalf = 5;

                            for (int i = 1; i <= firstHalf; i++)
                            {
                                for (int j = 1; j <= i; j++)
                                {
                                    string iAsString = i.ToString();
                                    foreach (char digito in iAsString)
                                    {
                                        Console.Write("@");
                                        Thread.Sleep(100);
                                    }
                                }
                                Console.WriteLine();
                            }
                            Console.WriteLine();
                            for (int i = firstHalf - 1; i >= 1; i--)
                            {
                                for (int j = 1; j <= i; j++)
                                {
                                    string iAsString = i.ToString();
                                    foreach (char digito in iAsString)
                                    {
                                        Console.Write("@");
                                        Thread.Sleep(100);
                                    }
                                }
                                Console.WriteLine();
                            }
                            Console.Clear();
                            Console.Write("\nType 1 for sequence again or any number to go back to menu: ");
                            while (!Int32.TryParse(Console.ReadLine(), out sequence))
                            {
                                Console.Clear();
                                Console.WriteLine("\n\n\n\n\n\n\n\n");
                                Console.WriteLine("PLEASE USE ONLY NUMBERS. TRY AGAIN");
                                Thread.Sleep(500);
                                Console.Write("REDIRECTING TO THE QUESTION");
                                Thread.Sleep(500);
                                Console.Write(".");
                                Thread.Sleep(500);
                                Console.Write(".");
                                Thread.Sleep(500);
                                Console.Write(".");
                                Thread.Sleep(500);
                                Console.Clear();
                                Console.Write("\nPress 1 to print de sequence or any other number to go back to menu: ");
                                continue;
                            }
                            Console.Clear();
                        }
                        Console.Clear();
                        Console.WriteLine("\n\n\n\n\n\n\n\n");
                        Console.Write("REDIRECTING TO MENU");
                        Thread.Sleep(300);
                        Console.Write(".");
                        Thread.Sleep(300);
                        Console.Write(".");
                        Thread.Sleep(300);
                        Console.Write(".");
                        Thread.Sleep(300);
                        Console.Clear();
                        break;
                    #endregion
                    #region EXERCISE 3
                    case 3:
                        decision = 1;
                        Console.Clear();
                        Console.WriteLine("YOU HAVE SELECTED OPTION 3 - EXERCISE 5\n");
                        string texto3 = "Write a program that prints 10 by 10 multiplication table\n";
                        foreach (char letra in texto3)
                        {
                            Console.Write(letra);
                            Thread.Sleep(1);
                        }
                        Console.WriteLine("Press any key to print the table");
                        Console.ReadLine();
                        Console.Clear();

                        while (decision == 1)
                        {
                            Console.Clear();
                            int tableSize = 10;
                            int maxNumber = tableSize * tableSize;

                            for (int i = 1; i <= tableSize; i++)
                            {
                                for (int j = 1; j <= tableSize; j++)
                                {
                                    int result = i * j;

                                    Console.Write(result.ToString().PadLeft(maxNumber.ToString().Length) + " ");

                                }
                                Console.WriteLine();
                                Thread.Sleep(100);
                            }
                            Console.WriteLine("\nWanna print again? \n1 - Yes \n2 - No\n");
                            while (!Int32.TryParse(Console.ReadLine(), out decision) || decision < 1 || decision > 2)
                            {
                                Console.Clear();
                                Console.WriteLine("\n\n\n\n\n\n\n\n");
                                Console.WriteLine("PLEASE USE ONLY NUMBERS BETWEEN 1 AND 2");
                                Thread.Sleep(500);
                                Console.Write(".");
                                Thread.Sleep(500);
                                Console.Write(".");
                                Thread.Sleep(500);
                                Console.Write(".");
                                Thread.Sleep(500);
                                Console.Clear();
                                Console.WriteLine("\nWanna print again? \n1 - Yes \n2 - No\n");
                                continue;
                            }
                        }
                        Console.Clear();
                        Console.WriteLine("\n\n\n\n\n\n\n\n");
                        Console.Write("REDIRECTING TO MENU");
                        Thread.Sleep(300);
                        Console.Write(".");
                        Thread.Sleep(300);
                        Console.Write(".");
                        Thread.Sleep(300);
                        Console.Write(".");
                        Thread.Sleep(300);
                        Console.Clear();
                        break;
                    #endregion
                    #region EXERCISE 4
                    case 4:
                        Console.Clear();
                        Console.WriteLine("YOU HAVE SELECTED OPTION 4 - EXERCISE 7\n");
                        string texto4 = "Prime number is a number that is greater than 1 and divided by 1 or itself." +
                            "\nIn other words, prime numbers can't be divided by other numbers than itself or 1. " +
                            "\nWrite a program that displays all prime numbers between 1 and n(read by console).\n";
                        foreach (char letra in texto4)
                        {
                            Console.Write(letra);
                            Thread.Sleep(1);
                        }
                        while (anotherTry == 1)
                        {
                            Console.Write("\nPlease right a number equal or greater than 1: ");
                            while (!Int32.TryParse(Console.ReadLine(), out numberChosen) || numberChosen < 1)
                            {
                                Console.Clear();
                                Console.WriteLine("\n\n\n\n\n\n\n\n");
                                Console.WriteLine("PLEASE USE ONLY NUMBERS AND EQUAL OR GREATER THAN 1. TRY AGAIN");
                                Thread.Sleep(500);
                                Console.Write("REDIRECTING TO THE QUESTION");
                                Thread.Sleep(500);
                                Console.Write(".");
                                Thread.Sleep(500);
                                Console.Write(".");
                                Thread.Sleep(500);
                                Console.Write(".");
                                Thread.Sleep(500);
                                Console.Clear();
                                Console.Write("\nPlease right a number equal or greater than 1: ");
                                continue;                                
                            }                            
                            Console.WriteLine();
                            //Include a timer just to see how long the machine took to complete the task
                            Stopwatch stopwatch = new Stopwatch();
                            //Where the clock starts
                            stopwatch.Start();
                            //prime numbers counter
                            int primeCount = primeNumbersRange(numberChosen);
                            //Where the clock stops
                            stopwatch.Stop();

                            Console.WriteLine($"\n\nPrime numbers between 1 and {numberChosen}: {primeCount}");
                            Console.WriteLine("Time elapsed: " + stopwatch.Elapsed.TotalSeconds + " seconds");
                            Thread.Sleep(2000);

                            Console.WriteLine("\nDo you wanna try another value?\n1 - Yes\n2 - No\n");
                            while (!Int32.TryParse(Console.ReadLine(), out anotherTry) || anotherTry < 1 || anotherTry > 2)
                            {
                                Console.Clear();
                                Console.WriteLine("\n\n\n\n\n\n\n\n");
                                Console.WriteLine("ONLY NUMBERS 1 AND 2 ARE ACCEPTED. TRY AGAIN");
                                Thread.Sleep(500);
                                Console.Write(".");
                                Thread.Sleep(500);
                                Console.Write(".");
                                Thread.Sleep(500);
                                Console.Write(".");
                                Thread.Sleep(500);
                                Console.Clear();
                                Console.WriteLine("\nDo you wanna try another value?\n1 - Yes \n2 - No\n");
                                continue;
                                }
                            Console.Clear();
                        }
                        Console.WriteLine("\n");
                        Console.Write("REDIRECTING TO MENU");
                        Thread.Sleep(300);
                        Console.Write(".");
                        Thread.Sleep(300);
                        Console.Write(".");
                        Thread.Sleep(300);
                        Console.Write(".");
                        Thread.Sleep(300);
                        Console.Clear();                        
                        break;
                    #endregion
                    #region EXERCISE 5
                    case 5:
                        Console.WriteLine("\n\n\n");
                        Console.Write("ENDING APPLICATION");
                        Thread.Sleep(400);
                        Console.Write(".");
                        Thread.Sleep(300);
                        Console.Write(".");
                        Thread.Sleep(300);
                        Console.Write(".");
                        Thread.Sleep(300);
                        Console.Clear();
                        Console.WriteLine("\n\n\n\n\n\n\n\n\n");
                        Console.WriteLine("**********\nH A V E \nA \nG R E A T \nD A Y \nT E A C H E R ! \n********** ");
                        Console.WriteLine();
                        Thread.Sleep(2000);
                        Environment.Exit(0);
                        break;
                        #endregion
                }
            }
        }
    }
}