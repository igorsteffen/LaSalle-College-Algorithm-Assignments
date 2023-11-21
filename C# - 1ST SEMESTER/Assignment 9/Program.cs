namespace Assignment9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region FUNCTIONS:
            static void MenuAccess(string[] menu)
            {
                for (int i = 0; i < menu.Length; i++)
                {
                    Console.WriteLine(menu[i]);
                }
            }
            static bool isLeapYear(int year)
            {
                if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            static int numberOfDays(int month, int year)
            {
                switch (month)
                {
                    case 1:  // January
                    case 3:  // March
                    case 5:  // May
                    case 7:  // July
                    case 8:  // August
                    case 10: // October
                    case 12: // December
                        return 31;

                    case 4:  // April
                    case 6:  // June
                    case 9:  // September
                    case 11: // November
                        return 30;

                    case 2:  // February
                        return isLeapYear(year) ? 29 : 28;

                    default:
                        return -1;  // INVALID VALUE FOR THE MONTH
                }
            }
            static void max(int numberA, int numberB)
            {
                if (numberA < numberB)
                {
                    Console.WriteLine($"\n**NUMBER {numberB} IS LARGER THAN {numberA}**");
                }
                else
                {
                    Console.WriteLine($"\n**NUMBER {numberA} IS LARGER THAN {numberB}**");
                }
            }
            static void isBetween(int numberOne, int numberTwo, int numberThree)
            {
                if (numberThree > numberOne && numberThree < numberTwo)
                {
                    Console.WriteLine($"#{numberThree} IS BETWEEN #{numberOne} AND #{numberTwo}");
                }
                else
                {
                    Console.WriteLine($"#{numberThree} IS NOT BETWEEN #{numberOne} AND #{numberTwo}");
                }
            }
            static double exponentiation(double baseNumber, int exponent)
            {
                double result = 1.0;

                if (exponent < 0)
                {
                    baseNumber = 1 / baseNumber;
                    exponent = -exponent;
                }

                for (int i = 0; i < exponent; i++)
                {
                    result *= baseNumber;
                }

                return result;
            }
            static double Round(double numberReal1, int precisionNumber)
            {
                double factor = exponentiation(10, precisionNumber);
                double roundedNumber = (int)((numberReal1 * factor) + 0.5) / factor;
                return roundedNumber;

            }
            static bool IsPrime(int toCheck)
            {
                if (toCheck <= 1)
                {
                    return false;
                }
                for (int i = 2; i * i <= toCheck; i++)
                {
                    if (toCheck % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
            static int countDigits(int numberToCheck)
            {
                if (numberToCheck < 0)
                {
                    numberToCheck *= -1;
                }

                int count = 0;
                do
                {
                    count++;
                    numberToCheck /= 10;
                } while (numberToCheck != 0);

                return count;
            }
            static bool firstDayEarlier(int day1, int month1, int year1, int day2, int month2, int year2)
            {
                if (year1 < year2)
                {
                    return true;
                }
                else if (year1 > year2)
                {
                    return false;
                }
                if (month1 < month2)
                {
                    return true;
                }
                else if (month1 > month2)
                {
                    return false;
                }
                return day1 < day2;
            }
            static void displayTomorrow(int day3, int month3, int year3, out int nextDay, out int nextMonth, out int nextYear)
            {
                int daysInMonth = numberOfDays(month3, year3);

                if (day3 < daysInMonth)
                {
                    nextDay = day3 + 1;
                    nextMonth = month3;
                    nextYear = year3;
                }
                else
                {
                    nextDay = 1;
                    if (month3 < 12)
                    {
                        nextMonth = month3 + 1;
                        nextYear = year3;
                    }
                    else
                    {
                        nextMonth = 1;
                        nextYear = year3 + 1;
                    }
                }
            }
            #endregion

            #region VARIABLES
            string isNullYet = "";
            int option = 0;
            int month = 0;
            int year = 0;
            int exponent = 0;
            int precisionNumber = 0;
            int numberToCheck = 0;
            int numberA, numberB, numberOne, numberTwo, numberThree, number, precision, toCheck, inputNumber, numberOfDigits, day1, month1, year1, day2, month2, year2, day3, month3, year3;
            double baseNumber, numberReal1;
            string[] monthsOfTheYear = { "JANUARY", "FEBRUARY", "MARCH", "APRIL", "MAY", "JUNE", "JULY", "AUGUST", "SEPTEMBER", "OCTOBER", "NOVEMBER", "DECEMBER" };
            #endregion

            while (true)
            {
            #region MENU LAYOUT
            if (year == 0)
            {
                isNullYet = " - NOT ASSIGNED";
                }
                else
                {
                    isNullYet = "";
                }

            string[] menu = { "1. LEAP YEAR VALIDATION.", $"2. NUMBER OF DAYS IN A MONTH OF THE YEAR: **{year}{isNullYet}**.", "3. INTEGERS COMPARISON.", "4. BETWEEN NUMBERS.", "5. EXPONENTIATION.", "6. ROUNDING NUMBERS.", "7. PRIME NUMBERS", "8. INTEGER AMOUNT OF DIGITS.", "9. DATE ORDER.", "10. NEXT DATE", "11. EXIT APPLICATION" };
            #endregion
                #region MENU
                Console.WriteLine("ASSIGNMENT 9");
                Console.WriteLine();
                MenuAccess(menu);
                Console.WriteLine();
                Console.Write("SELECT AN OPTION: ");
                while (!Int32.TryParse(Console.ReadLine(), out option) || option < 1 || option > 11)
                {
                    Console.Write("**OUT OF RANGE**\nTRY AGAIN: ");
                }
                #endregion
                switch (option)
                {
                    #region EXERCISE 1
                    case 1:
                        int decisionCase1 = 1;
                        while (decisionCase1 == 1)
                        {
                            Console.Clear();
                            Console.WriteLine("1. LEAP YEAR VALIDATION.");
                            Console.WriteLine();
                            Console.Write("TYPE AN YEAR: ");
                            while (!Int32.TryParse(Console.ReadLine(), out year))
                            {
                                Console.Write("**ONLY NUMBERS ACCEPTED**\nTRY AGAIN: ");
                            }

                            isLeapYear(year);

                            if (isLeapYear(year))
                            {
                                Console.WriteLine();
                                Console.WriteLine($"**{year} IS A LEAP YEAR**");
                                Thread.Sleep(1000);
                                Console.WriteLine();
                            }
                            else
                            {
                                Console.WriteLine();
                                Console.WriteLine($"**{year} IS NOT A LEAP YEAR**");
                                Thread.Sleep(1000);
                                Console.WriteLine();
                            }
                            Console.Write("CHECK ANOTHER YEAR? \n1 - YES \n2 - NO\n\n");
                            while (!Int32.TryParse(Console.ReadLine(), out decisionCase1) || decisionCase1 < 1 || decisionCase1 > 2)
                            {
                                Console.Write("**ONLY NUMBERS 1 OR 2 ARE ACCEPTED**\nTRY AGAIN: ");
                            }
                        }
                        Console.Clear();
                        break;
                    #endregion
                    #region EXERCISE 2
                    case 2:
                        int decisionCase2 = 1;
                        while (decisionCase2 == 1)
                        {
                            Console.Clear();
                            Console.WriteLine("2. NUMBER OF DAYS IN A MONTH.");
                            Console.WriteLine();
                            Console.Write($"TYPE A MONTH FROM {year}:\n1 - JANUARY\n2 - FEBRUARY\n3 - MARCH\n4 - APRIL\n5 - MAY\n6 - JUNE\n7 - JULY\n8 - AUGUST\n9 - SEPTEMBER\n10 - OCTOBER\n11 - NOVEMBER\n12 - DECEMBER\n\n>");
                            while (!Int32.TryParse(Console.ReadLine(), out month) || month < 1 || month > 12)
                            {
                                Console.Write("**ONLY NUMBERS FROM 1 TO 12 ACCEPTED**\nTRY AGAIN: ");
                            }
                            numberOfDays(month, year);
                            Console.WriteLine();
                            Console.WriteLine($"**NUMBER OF DAYS IN {monthsOfTheYear[month - 1]} OF {year} ARE: {numberOfDays(month, year)}");
                            Console.WriteLine();
                            Console.Write("CHECK ANOTHER MONTH? \n1 - YES \n2 - NO\n\n");
                            while (!Int32.TryParse(Console.ReadLine(), out decisionCase2) || decisionCase2 < 1 || decisionCase2 > 2)
                            {
                                Console.Write("**ONLY NUMBERS 1 OR 2 ARE ACCEPTED**\nTRY AGAIN: ");
                            }
                        }
                        Console.Clear();
                        break;
                    #endregion
                    #region EXERCISE 3
                    case 3:
                        int decisionCase3 = 1;
                        while (decisionCase3 == 1)
                        {
                            Console.Clear();
                            Console.WriteLine("3. INTEGERS COMPARISON.\n");
                            Console.Write("TYPE A VALUE FOR NUMBER A: ");
                            while (!Int32.TryParse(Console.ReadLine(), out numberA))
                            {
                                Console.Write("**ONLY NUMBERS ARE ACCEPTED**\nTRY AGAIN: ");
                            }
                            Console.WriteLine();
                            Console.Write("TYPE A VALUE FOR NUMBER B: ");
                            while (!Int32.TryParse(Console.ReadLine(), out numberB))
                            {
                                Console.Write("**ONLY NUMBERS ARE ACCEPTED**\nTRY AGAIN: ");
                            }
                            Console.WriteLine();
                            max(numberA, numberB);

                            Console.WriteLine("\nTRY AGAIN? \n1 - YES \n2 - NO\n");
                            while (!Int32.TryParse(Console.ReadLine(), out decisionCase3) || decisionCase3 < 1 || decisionCase3 > 2)
                            {
                                Console.Write("**ONLY NUMBERS 1 OR 2 ARE ACCEPTED**\nTRY AGAIN: ");
                            }
                        }
                        Console.Clear();
                        break;
                    #endregion
                    #region EXERCISE 4
                    case 4:
                        int decisionCase4 = 1;
                        while (decisionCase4 == 1)
                        {
                            Console.Clear();
                            Console.WriteLine("4. BETWEEN NUMBERS.\n");
                            Console.Write("TYPE A VALUE FOR NUMBER #1: ");
                            while (!Int32.TryParse(Console.ReadLine(), out numberOne))
                            {
                                Console.Write("**ONLY NUMBERS ARE ACCEPTED**\nTRY AGAIN: ");
                            }
                            Console.WriteLine();

                            Console.Write("TYPE A VALUE FOR NUMBER #2: ");
                            while (!Int32.TryParse(Console.ReadLine(), out numberTwo) || numberTwo < numberOne)
                            {
                                Console.Write($"**ONLY NUMBERS GREATER THAN {numberOne} ARE ACCEPTED**\nTRY AGAIN: ");
                            }
                            Console.WriteLine();

                            Console.Write($"TYPE A VALUE FOR THE NUMBER #3 TO CHECK IF IT'S WITHIN THE RANGE OF #{numberOne} AND #{numberTwo}: ");
                            while (!Int32.TryParse(Console.ReadLine(), out numberThree))
                            {
                                Console.Write("**ONLY NUMBERS ARE ACCEPTED**\nTRY AGAIN: ");
                            }
                            Console.WriteLine();
                            isBetween(numberOne, numberTwo, numberThree);

                            Console.WriteLine("\nTRY AGAIN? \n1 - YES \n2 - NO\n");
                            while (!Int32.TryParse(Console.ReadLine(), out decisionCase4) || decisionCase4 < 1 || decisionCase4 > 2)
                            {
                                Console.Write("**ONLY NUMBERS 1 OR 2 ARE ACCEPTED**\nTRY AGAIN: ");
                            }
                        }
                        Console.Clear();
                        break;
                    #endregion
                    #region EXERCISE 5
                    case 5:
                        int decisionCase5 = 1;
                        while (decisionCase5 == 1)
                        {
                            Console.Clear();
                            Console.WriteLine("5. EXPONENTIATION.\n");
                            Console.Write("TYPE A NUMBER TO BE THE BASE OF EXPONENTIATION: ");
                            while (!Double.TryParse(Console.ReadLine(), out baseNumber))
                            {
                                Console.Write("**ONLY NUMBERS ARE ACCEPTED**\nTRY AGAIN: ");
                            }
                            Console.Write("TYPE A NUMBER TO BE THE EXPONENT: ");
                            while (!Int32.TryParse(Console.ReadLine(), out exponent))
                            {
                                Console.Write("**ONLY NUMBERS ARE ACCEPTED**\nTRY AGAIN: ");
                            }
                            double result = exponentiation(baseNumber, exponent);

                            Console.WriteLine($"{baseNumber}^{exponent} = {result}");

                            Console.WriteLine("\nTRY AGAIN? \n1 - YES \n2 - NO\n");
                            while (!Int32.TryParse(Console.ReadLine(), out decisionCase5) || decisionCase5 < 1 || decisionCase5 > 2)
                            {
                                Console.Write("**ONLY NUMBERS 1 OR 2 ARE ACCEPTED**\nTRY AGAIN: ");
                            }
                        }
                        Console.Clear();
                        break;
                    #endregion
                    #region EXERCISE 6
                    case 6:
                        int decisionCase6 = 1;
                        while (decisionCase6 == 1)
                        {
                            Console.Clear();
                            Console.WriteLine("6. ROUNDING NUMBERS.\n");
                            Console.Write("TYPE A NUMBER TO BE THE BASE OF EXPONENTIATION: ");
                            while (!Double.TryParse(Console.ReadLine(), out numberReal1))
                            {
                                Console.Write("**ONLY NUMBERS ARE ACCEPTED**\nTRY AGAIN: ");
                            }
                            Console.WriteLine();
                            Console.Write("TYPE THE NUMBER'S PRECISION: ");
                            while (!Int32.TryParse(Console.ReadLine(), out precisionNumber))
                            {
                                Console.Write("**ONLY NUMBERS ARE ACCEPTED**\nTRY AGAIN: ");
                            }
                            double roundedNumber = Round(numberReal1, precisionNumber);

                            Console.WriteLine($"Rounded to {precisionNumber} decimal places: {roundedNumber}");

                            Console.WriteLine("\nTRY AGAIN? \n1 - YES \n2 - NO\n");
                            while (!Int32.TryParse(Console.ReadLine(), out decisionCase6) || decisionCase6 < 1 || decisionCase6 > 2)
                            {
                                Console.Write("**ONLY NUMBERS 1 OR 2 ARE ACCEPTED**\nTRY AGAIN: ");
                            }
                        }
                        Console.Clear();
                        break;
                    #endregion
                    #region EXERCISE 7
                    case 7:
                        int decisionCase7 = 1;
                        while (decisionCase7 == 1)
                        {
                            Console.Clear();
                            Console.WriteLine("7. PRIME NUMBERS\n");
                            Console.Write("TYPE A NUMBER TO CHECK IF IT IS A PRIME NUMBER: ");
                            while (!Int32.TryParse(Console.ReadLine(), out toCheck))
                            {
                                Console.Write("**ONLY NUMBERS ACCEPTED**\nTRY AGAIN: ");
                            }
                            bool isPrime = IsPrime(toCheck);

                            if (isPrime)
                            {
                                Console.WriteLine();
                                Console.WriteLine($"**{toCheck} IS A PRIME NUMBER.**");
                            }
                            else
                            {
                                Console.WriteLine();
                                Console.WriteLine($"**{toCheck} IS NOT A PRIME NUMBER.**");
                            }
                            Console.WriteLine("\nTRY AGAIN? \n1 - YES \n2 - NO\n");
                            while (!Int32.TryParse(Console.ReadLine(), out decisionCase7) || decisionCase7 < 1 || decisionCase7 > 2)
                            {
                                Console.Write("**ONLY NUMBERS 1 OR 2 ARE ACCEPTED**\nTRY AGAIN: ");
                            }
                        }
                        Console.Clear();
                        break;
                    #endregion
                    #region EXERCISE 8
                    case 8:
                        int decisionCase8 = 1;
                        while (decisionCase8 == 1)
                        {
                            Console.Clear();
                            Console.WriteLine("8. INTEGER AMOUNT OF DIGITS.\n");
                            Console.Write("TYPE A NUMBER: ");
                            while (!Int32.TryParse(Console.ReadLine(), out numberToCheck))
                            {
                                Console.Write("**ONLY NUMBERS ACCEPTED**\nTRY AGAIN: ");
                            }
                            Console.WriteLine();
                            numberOfDigits = countDigits(numberToCheck);

                            Console.WriteLine($"THERE ARE {numberOfDigits} DIGITS IN #{numberToCheck}");

                            Console.WriteLine("\nTRY AGAIN? \n1 - YES \n2 - NO\n");
                            while (!Int32.TryParse(Console.ReadLine(), out decisionCase8) || decisionCase8 < 1 || decisionCase8 > 2)
                            {
                                Console.Write("**ONLY NUMBERS 1 OR 2 ARE ACCEPTED**\nTRY AGAIN: ");
                            }
                        }
                        Console.Clear();
                        break;
                    #endregion
                    #region EXERCISE 9
                    case 9:
                        int decisionCase9 = 1;
                        while (decisionCase9 == 1)
                        {
                            Console.Clear();
                            Console.WriteLine("9. DATE ORDER.\n");
                            Console.Write("TYPE 1ST DAY: ");
                            while (!Int32.TryParse(Console.ReadLine(), out day1) || day1 < 1 || day1 > 31)
                            {
                                Console.Write("**ONLY NUMBERS ACCEPTED FROM 1 TO 31**\nTRY AGAIN: ");
                            }
                            Console.WriteLine();
                            Console.Write("TYPE 1ST MONTH: ");
                            while (!Int32.TryParse(Console.ReadLine(), out month1) || month1 < 1 || month1 > 12)
                            {
                                Console.Write("**ONLY NUMBERS ACCEPTED FROM 1 TO 12**\nTRY AGAIN: ");
                            }
                            Console.WriteLine();
                            Console.Write("TYPE 1ST YEAR: ");
                            while (!Int32.TryParse(Console.ReadLine(), out year1))
                            {
                                Console.Write("**ONLY NUMBERS ACCEPTED**\nTRY AGAIN: ");
                            }
                            Console.WriteLine();
                            Console.WriteLine("--------------------------");
                            Console.Write("TYPE 2ND DAY: ");
                            while (!Int32.TryParse(Console.ReadLine(), out day2) || day2 < 1 || day2 > 31)
                            {
                                Console.Write("**ONLY NUMBERS ACCEPTED FROM 1 TO 31**\nTRY AGAIN: ");
                            }
                            Console.WriteLine();
                            Console.Write("TYPE 2ND MONTH: ");
                            while (!Int32.TryParse(Console.ReadLine(), out month2) || month2 < 1 || month2 > 12)
                            {
                                Console.Write("**ONLY NUMBERS ACCEPTED FROM 1 TO 12**\nTRY AGAIN: ");
                            }
                            Console.WriteLine();
                            Console.Write("TYPE 2ND YEAR: ");
                            while (!Int32.TryParse(Console.ReadLine(), out year2))
                            {
                                Console.Write("**ONLY NUMBERS ACCEPTED**\nTRY AGAIN: ");
                            }
                            Console.WriteLine();

                            bool firstDateBeforeSecond = firstDayEarlier(day1, month1, year1, day2, month2, year2);

                            if (firstDateBeforeSecond)
                            {
                                Console.WriteLine($"{day1}/{month1}/{year1} COMES FIRST THAN {day2}/{month2}/{year2}.");
                            }
                            else
                            {
                                Console.WriteLine($"{day2}/{month2}/{year2} COMES FIRST THAN {day1}/{month1}/{year1}.");
                            }

                            Console.WriteLine("\nTRY AGAIN? \n1 - YES \n2 - NO\n");
                            while (!Int32.TryParse(Console.ReadLine(), out decisionCase9) || decisionCase9 < 1 || decisionCase9 > 2)
                            {
                                Console.Write("**ONLY NUMBERS 1 OR 2 ARE ACCEPTED**\nTRY AGAIN: ");
                            }
                        }
                        Console.Clear();
                        break;
                    #endregion
                    #region EXERCISE 10
                    case 10:
                        int decisionCase10 = 1;
                        while (decisionCase10 == 1)
                        {
                            Console.Clear();
                            Console.WriteLine("10. NEXT DATE.\n");
                            Console.Write("TYPE A DAY: ");
                            while (!Int32.TryParse(Console.ReadLine(), out day3) || day3 < 1 || day3 > 31)
                            {
                                Console.Write("**ONLY NUMBERS ACCEPTED FROM 1 TO 31**\nTRY AGAIN: ");
                            }
                            Console.WriteLine();
                            Console.Write("TYPE A MONTH: ");
                            while (!Int32.TryParse(Console.ReadLine(), out month3) || month3 < 1 || month3 > 12)
                            {
                                Console.Write("**ONLY NUMBERS ACCEPTED FROM 1 TO 12**\nTRY AGAIN: ");
                            }
                            Console.WriteLine();
                            Console.Write("TYPE A YEAR: ");
                            while (!Int32.TryParse(Console.ReadLine(), out year3))
                            {
                                Console.Write("**ONLY NUMBERS ACCEPTED**\nTRY AGAIN: ");
                            }
                            Console.WriteLine();

                            displayTomorrow(day3, month3, year3, out int nextDay, out int nextMonth, out int nextYear);

                            Console.WriteLine($"NEXT DATE IS: {nextDay} {nextMonth} {nextYear}");
                            Console.WriteLine("\nTRY AGAIN? \n1 - YES \n2 - NO\n");
                            while (!Int32.TryParse(Console.ReadLine(), out decisionCase10) || decisionCase10 < 1 || decisionCase10 > 2)
                            {
                                Console.Write("**ONLY NUMBERS 1 OR 2 ARE ACCEPTED**\nTRY AGAIN: ");
                            }
                        }
                        Console.Clear();
                        break;
                    #endregion
                    #region EXERCISE 11
                    case 11:
                        Environment.Exit(0);
                        break;
                        #endregion
                }
            }
        }
    }
}
