namespace Assignment_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region FUNCTIONS
            static bool IsString(string studentsNames)
            {
                foreach (char character in studentsNames)
                {
                    if (!char.IsLetter(character))
                    {
                        return false;
                    }
                }
                return true;
            }
            #endregion

            #region ARRAYS
            string[] studentsNames = new string[5];
            int[] studentsAges = new int[5];
            int[] indexStudentsNamesAges = { 0, 1, 2, 3, 4 };
            #endregion

            #region VARIABLES
            int option = 0;
            int index = 0;
            int tryAnother = 1;
            int windowWidth = Console.WindowWidth;
            int windowHeight = Console.WindowHeight;
            int smallestAge = studentsAges[0];
            int largestAge = studentsAges[0];
            string smallestName = studentsNames[0];
            string largestName = studentsNames[0];
            #endregion

            #region INTRODUCTION
            string assignment = "A S S I G N M E N T - 7";
            int leftPadding = (windowWidth - assignment.Length) / 2;
            int topPadding = (windowHeight - 1) / 2;
            string centeredText = new string(' ', leftPadding) + assignment;
            for (int i = 0; i < topPadding; i++)
            {
                Console.WriteLine();
            }
            Console.WriteLine(centeredText);

            string textSpaces = " ";
            int leftPaddingSpaces = (windowWidth - textSpaces.Length) / 2 - 11;
            string centeredSpaces = new string(' ', leftPaddingSpaces) + textSpaces;
            Console.Write(centeredSpaces);

            string textArray = "A   R   R   A   Y   S";
            foreach (char text in textArray)
            {
                Console.Write(text);
                Thread.Sleep(60);
            }
            Console.WriteLine();
            Console.WriteLine();
            string loading = "LOADING";
            int leftPaddingLoading = (windowWidth - loading.Length) / 2 - 2;
            string centeredLoading = new string(' ', leftPaddingLoading) + loading;
            Console.Write(centeredLoading);

            string dots = "...";
            foreach (char points in dots)
            {
                Console.Write(points);
                Thread.Sleep(600);
            }
            Console.Clear();
            #endregion

            while (true)
            {
                #region MENU
                Console.WriteLine("ASSIGNMENT OPTIONS:\n");
                Thread.Sleep(500);
                Console.WriteLine("OPTION 1 - ENTER THE NAMES: Read 5 names from the console" +
                    "\nand save it into the array of names(1).\n");
                Thread.Sleep(100);
                Console.WriteLine("OPTION 2 - ENTER THE AGES: Read 5 ages from the console" +
                    "\nand save it into the array of ages(2).\n");
                Thread.Sleep(100);
                Console.WriteLine("OPTION 3 - DISPLAY INFORMATION: Display all the names and the" +
                    "\nages together.\n");
                Thread.Sleep(100);
                Console.WriteLine("OPTION 4 - DISPLAY SMALLEST AND LARGEST AGE: Get the smalles" +
                    "\nand the largest age and display it in the console.\n");
                Thread.Sleep(100);
                Console.WriteLine("OPTION 5 - GET AVERAGE: Get the average of the ages and" +
                    "\ndisplay it.\n");
                Thread.Sleep(100);
                Console.WriteLine("OPTION 6 - DISPLAY NAME BY INDEX: Ask to the user for and index" +
                    "\n(n) and display the name and the age is stored in the array in" +
                    "the index (n).\n");
                Thread.Sleep(100);
                Console.WriteLine("OPTION 7 - EXIT\n\n");
                Thread.Sleep(100);
                Console.Write("Enter the OPTION NUMBER you want: ");
                while (!Int32.TryParse(Console.ReadLine(), out option) || option < 1 || option > 7)
                {
                    Console.WriteLine("\n*****ONLY NUMBERS FROM 1 TO 7 ARE ACCEPTED*****");
                    Thread.Sleep(1500);
                    Console.Clear();
                    break;
                    #endregion
                }
                switch (option)
                {
                    #region EXERCISE 1
                    case 1:
                        int i = 0;
                        Console.Clear();
                        Console.WriteLine("OPTION 1 SELECTED!");
                        Thread.Sleep(500);
                        string textOption1 = "\n\nENTER THE NAMES.\n";
                        foreach (char text1 in textOption1)
                        {
                            Console.Write(text1);
                            Thread.Sleep(1);
                        }

                        for (i = 0; i < studentsNames.Length;)
                        {
                            Console.Write($"\nEnter a name #{i + 1}: ");
                            studentsNames[i] = Console.ReadLine();
                            if (String.IsNullOrEmpty(studentsNames[i]))
                            {
                                Console.WriteLine("*****YOU MUST TYPE SOMETHING*****");
                                Thread.Sleep(1000);
                                Console.Clear();
                                continue;
                            }
                            if (!IsString(studentsNames[i]))
                            {
                                Console.WriteLine("*****ONLY CHARACTERS ACCEPTED*****");
                                Thread.Sleep(1000);
                                Console.Clear();
                                continue;
                            }
                            i++;
                            continue;
                        }
                        Console.WriteLine();
                        Console.WriteLine("*****NAMES SUCCESSFULLY REGISTERED*****");
                        Thread.Sleep(2000);
                        Console.Clear();
                        break;
                    #endregion
                    #region EXERCISE 2
                    case 2:
                        i = 0;
                        Console.Clear();
                        Console.WriteLine("OPTION 2 SELECTED!");
                        Thread.Sleep(500);
                        string textOption2 = "\n\nENTER THE AGES.\n";
                        foreach (char text2 in textOption2)
                        {
                            Console.Write(text2);
                            Thread.Sleep(1);
                        }
                        for (i = 0; i < studentsAges.Length;)
                        {
                            Console.Write($"\nEnter an age #{i + 1}: ");
                            while (!Int32.TryParse(Console.ReadLine(), out studentsAges[i]))
                            {
                                Console.WriteLine("*****ONLY NUMBERS ACCEPTED*****");
                                Thread.Sleep(1000);
                                Console.Clear();
                                continue;
                            }
                            if (studentsAges[i] <= 0)
                            {
                                Console.WriteLine("\n*****STUDENT NOT BORN YET. ENTER ANOTHER AGE*****");
                                Thread.Sleep(700);
                                continue;
                            }
                            i++;
                            continue;
                        }
                        Console.WriteLine();
                        Console.WriteLine("*****AGES SUCCESSFULLY REGISTERED*****");
                        Thread.Sleep(2000);
                        Console.Clear();
                        break;
                    #endregion
                    #region EXERCISE 3
                    case 3:
                        i = 0;
                        Console.Clear();
                        Console.WriteLine("OPTION 3 SELECTED!");
                        Thread.Sleep(500);
                        string textOption3 = "\n\nDISPLAY INFORMATION.\n";
                        foreach (char text3 in textOption3)
                        {
                            Console.Write(text3);
                            Thread.Sleep(1);
                        }
                        Thread.Sleep(500);

                        for (i = studentsNames.Length - 1; i < studentsNames.Length;)
                        {
                            if (studentsNames[i] == null || studentsAges[i] == null)
                            {
                                Console.Clear();
                                string noNamesNoAges = "*****NO NAMES AND AGES VALUES DECLARED****";
                                int leftPaddingNoNamesNoAges = (windowWidth - noNamesNoAges.Length) / 2;
                                int topPaddingNoNamesNoAges = (windowHeight - 1) / 2;
                                string centeredText3 = new string(' ', leftPaddingNoNamesNoAges) + noNamesNoAges;
                                for (int j = 0; j < topPaddingNoNamesNoAges; j++)
                                {
                                    Console.WriteLine();
                                }
                                Console.WriteLine(centeredText3);
                                Thread.Sleep(1000);
                                break;
                            }
                            else
                            {
                                string a = "INDEX";
                                string b = "NAMES";
                                string c = "AGES";

                                Console.WriteLine();
                                Console.WriteLine($"{a,-10} {b,-15} {c}");
                                Console.WriteLine();

                                for (i = 0; i < indexStudentsNamesAges.Length; i++)
                                {
                                    Console.WriteLine($"{indexStudentsNamesAges[i],-10} {studentsNames[i],-15} {studentsAges[i]}");
                                    Console.WriteLine();
                                }
                            }
                        }
                        Thread.Sleep(2000);
                        string returning = "\n\nRETURNING TO MENU, PLEASE WAIT";
                        int leftPaddingReturning = (windowWidth - returning.Length) / 2;
                        string centeredTextA = new string(' ', leftPaddingReturning) + returning;
                        Console.Write(centeredTextA);
                        dots = "...";
                        foreach (char points5 in dots)
                        {
                            Console.Write(points5);
                            Thread.Sleep(500);
                        }
                        Console.Clear();
                        break;
                    #endregion
                    #region EXERCISE 4
                    case 4:
                        i = 0;
                        Console.Clear();
                        Console.WriteLine("OPTION 4 SELECTED!");
                        Thread.Sleep(500);
                        string textOption4 = "\n\nDISPLAY SMALLEST AND LARGEST AGE.\n";
                        foreach (char text4 in textOption4)
                        {
                            Console.Write(text4);
                            Thread.Sleep(1);
                        }
                        Thread.Sleep(500);

                        smallestAge = studentsAges[0];
                        smallestName = studentsNames[0];

                        for (i = 0; i < studentsAges.Length; i++)
                        {
                            if (studentsNames[i] == null || studentsAges[i] == null)
                            {
                                Console.Clear();
                                string noNamesNoAges = "*****NO NAMES AND AGES VALUES DECLARED****";
                                int leftPaddingNoNamesNoAges = (windowWidth - noNamesNoAges.Length) / 2;
                                int topPaddingNoNamesNoAges = (windowHeight - 1) / 2;
                                string centeredText3 = new string(' ', leftPaddingNoNamesNoAges) + noNamesNoAges;
                                for (int j = 0; j < topPaddingNoNamesNoAges; j++)
                                {
                                    Console.WriteLine();
                                }
                                Console.WriteLine(centeredText3);
                                Thread.Sleep(1000);
                                break;
                            }
                            else
                            {
                                if (studentsAges[i] < smallestAge)
                                {
                                    smallestAge = studentsAges[i];
                                    smallestName = studentsNames[i];
                                }

                                if (studentsAges[i] > largestAge)
                                {
                                    largestAge = studentsAges[i];
                                    largestName = studentsNames[i];
                                }
                            }
                        }
                        Console.WriteLine();
                        Console.WriteLine($"Largest age: {largestAge} - {largestName}");
                        Console.WriteLine($"Smallest age: {smallestAge} - {smallestName}");
                        Thread.Sleep(2000);
                        string returning2 = "\n\nRETURNING TO MENU, PLEASE WAIT";
                        int leftPaddingReturning2 = (windowWidth - returning2.Length) / 2;
                        string centeredTextB = new string(' ', leftPaddingReturning2) + returning2;
                        Console.Write(centeredTextB);
                        dots = "...";
                        foreach (char points6 in dots)
                        {
                            Console.Write(points6);
                            Thread.Sleep(500);
                        }
                        Console.Clear();
                        break;
                    #endregion
                    #region EXERCISE 5
                    case 5:
                        i = 0;
                        Console.Clear();
                        Console.WriteLine("OPTION 5 SELECTED!");
                        Thread.Sleep(500);
                        string textOption5 = "\n\nGET AVERAGE.\n";
                        foreach (char text5 in textOption5)
                        {
                            Console.Write(text5);
                            Thread.Sleep(1);
                        }
                        Thread.Sleep(500);
                        if (studentsNames[i] == null || studentsAges[i] == null)
                        {
                            Console.Clear();
                            string noNamesNoAges2 = "*****NO NAMES AND AGES VALUES DECLARED****";
                            int leftPaddingNoNamesNoAges2 = (windowWidth - noNamesNoAges2.Length) / 2;
                            int topPaddingNoNamesNoAges2 = (windowHeight - 1) / 2;
                            string centeredTextC = new string(' ', leftPaddingNoNamesNoAges2) + noNamesNoAges2;
                            for (int j = 0; j < topPaddingNoNamesNoAges2; j++)
                            {
                                Console.WriteLine();
                            }
                            Console.WriteLine(centeredTextC);
                            Thread.Sleep(800);
                        }
                        else
                        {
                            int sumAges = 0;
                            int numberOfAges = 5;
                            int averageAges = 0;

                            for (i = 0; i < studentsAges.Length; i++)
                            {
                                sumAges += studentsAges[i];
                            }
                            averageAges = sumAges / numberOfAges;

                            Console.WriteLine($"\nThe average of the ages inserted is: {averageAges}");
                            Thread.Sleep(2000);
                            Console.WriteLine();
                        }
                        Thread.Sleep(200);
                        string returning3 = "\n\n\nRETURNING TO MENU, PLEASE WAIT";
                        int leftPaddingReturning3 = (windowWidth - returning3.Length) / 2;
                        string centeredTextD = new string(' ', leftPaddingReturning3) + returning3;
                        Console.Write(centeredTextD);
                        dots = "...";
                        foreach (char points7 in dots)
                        {
                            Console.Write(points7);
                            Thread.Sleep(500);
                        }
                        Console.Clear();
                        break;
                    #endregion
                    #region EXERCISE 6
                    case 6:
                        i = 0;
                        Console.Clear();
                        Console.WriteLine("OPTION 6 SELECTED!");
                        Thread.Sleep(500);
                        string textOption6 = "\n\nDISPLAY NAME BY INDEX.\n";
                        foreach (char text6 in textOption6)
                        {
                            Console.Write(text6);
                            Thread.Sleep(1);
                        }
                        Thread.Sleep(500);

                        if (studentsNames[i] == null || studentsAges[i] == null)
                        {
                            Console.Clear();
                            string noNamesNoAges = "*****NO NAMES AND AGES VALUES DECLARED****";
                            int leftPaddingNoNamesNoAges = (windowWidth - noNamesNoAges.Length) / 2;
                            int topPaddingNoNamesNoAges = (windowHeight - 1) / 2;
                            string centeredText3 = new string(' ', leftPaddingNoNamesNoAges) + noNamesNoAges;
                            for (int j = 0; j < topPaddingNoNamesNoAges; j++)
                            {
                                Console.WriteLine();
                            }
                            Console.WriteLine(centeredText3);
                            Thread.Sleep(1000);
                            Console.Clear();
                        }
                        else
                        {
                            while (tryAnother == 1)
                            {
                                Console.WriteLine("\nSelect the INDEX number you want to check the data inserted:");
                                string indexNumbers = "[0   1   2   3   4]\n\n";
                                int leftPaddingIndexNumbers = (windowWidth - indexNumbers.Length) / 2 - 30;
                                string centeredTextF = new string(' ', leftPaddingIndexNumbers) + indexNumbers;
                                Console.Write(centeredTextF);

                                while (!Int32.TryParse(Console.ReadLine(), out index) || index < 0 || index > 4)
                                {
                                    Console.WriteLine("\n*****ONLY NUMBERS BETWEEN 0 AND 4 ARE ACCEPTED*****");
                                    Thread.Sleep(1500);
                                    Console.Clear();
                                    Console.WriteLine("\nSelect the INDEX number you want to check the data inserted:");
                                    string indexNumbers2 = "[0   1   2   3   4]\n\n";
                                    int leftPaddingIndexNumbers2 = (windowWidth - indexNumbers2.Length) / 2 - 30;
                                    string centeredTextG = new string(' ', leftPaddingIndexNumbers2) + indexNumbers2;
                                    Console.Write(centeredTextG);
                                    continue;
                                }
                                switch (index)
                                {
                                    case 0:
                                        Console.WriteLine($"INDEX 0: {studentsNames[0]} {studentsAges[0]} \n");
                                        Thread.Sleep(500);
                                        Console.WriteLine("Wanna check another INDEX number?\n1 - YES\n2 - NO\n");
                                        tryAnother = Convert.ToInt32(Console.ReadLine());
                                        Console.Clear();
                                        break;
                                    case 1:
                                        Console.WriteLine($"INDEX 1: {studentsNames[1]} {studentsAges[1]} \n");
                                        Thread.Sleep(500);
                                        Console.WriteLine("Wanna check another INDEX number?\n1 - YES\n2 - NO\n");
                                        tryAnother = Convert.ToInt32(Console.ReadLine());
                                        Console.Clear();
                                        break;
                                    case 2:
                                        Console.WriteLine($"INDEX 2: {studentsNames[2]} {studentsAges[2]} \n");
                                        Thread.Sleep(500);
                                        Console.WriteLine("Wanna check another INDEX number?\n1 - YES\n2 - NO\n");
                                        tryAnother = Convert.ToInt32(Console.ReadLine());
                                        Console.Clear();
                                        break;
                                    case 3:
                                        Console.WriteLine($"INDEX 3: {studentsNames[3]} {studentsAges[3]} \n");
                                        Thread.Sleep(500);
                                        Console.WriteLine("Wanna check another INDEX number?\n1 - YES\n2 - NO\n");
                                        tryAnother = Convert.ToInt32(Console.ReadLine());
                                        Console.Clear();
                                        break;
                                    case 4:
                                        Console.WriteLine($"INDEX 4: {studentsNames[4]} {studentsAges[4]} \n");
                                        Thread.Sleep(500);
                                        Console.WriteLine("Wanna check another INDEX number?\n1 - YES\n2 - NO\n");
                                        tryAnother = Convert.ToInt32(Console.ReadLine());
                                        Console.Clear();
                                        break;
                                }
                            }
                        }
                        break;
                    #endregion
                    #region EXERCISE 7
                    case 7:
                        Console.Clear();
                        string ending = "ENDING APPLICATION";
                        int leftPaddingEnding = (windowWidth - ending.Length) / 2;
                        int topPaddingEnding = (windowHeight - 1) / 2;
                        string centeredText7 = new string(' ', leftPaddingEnding) + ending;
                        for (int j = 0; j < topPaddingEnding; j++)
                        {
                            Console.WriteLine();
                        }
                        Console.Write(centeredText7);

                        foreach (char points7 in dots)
                        {
                            Console.Write(points7);
                            Thread.Sleep(300);
                        }
                        Thread.Sleep(1000);
                        Console.Clear();

                        string greatDay = "H A V E   A   G R E A T   D A Y   T E A C H E R";
                        int leftPaddingGreatDay = (windowWidth - greatDay.Length) / 2;
                        int topPaddingGreatDay = (windowHeight - 1) / 2;
                        string centeredText8 = new string(' ', leftPaddingGreatDay) + greatDay;
                        for (int j = 0; j < topPaddingGreatDay; j++)
                        {
                            Console.WriteLine();
                        }
                        Console.Write(centeredText8);
                        Thread.Sleep(2000);
                        Environment.Exit(0);
                        break;
                        #endregion
                }
            }
        }
    }
}
