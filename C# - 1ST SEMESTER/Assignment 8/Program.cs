namespace Assignment_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region CONST
            const int NUMBER_ELEMENTS = 10;
            #endregion

            #region VARIABLES
            int index = 0;
            int indexToSearch = -1;
            int idToSearch = 0;
            double midtermGrade = 0;
            double finalprojectGrade = 0;
            double finalexamGrade = 0;
            #endregion

            #region ARRAYS
            string[] menu = { "MY STUDENTS\n", "1.STUDENT DATA", "2.STUDENT GRADE", "3.STUDENTS INFORMATIONS", "4.STUDENT DATA BY ID", "5.GROUP AVERAGE", "6.BEST STUDENT", "7.EXIT APPLICATION\n" };
            int[] studentID = new int[NUMBER_ELEMENTS];
            string[,] studentData = new string[NUMBER_ELEMENTS, 2];
            double[,] grades = new double[10, 4];
            string[] examTypes = { "MIDTERM(30%)", "FINALPROJECT(30%)", "FINALEXAM(40%)", "TOTAL(100%)" };
            #endregion

            while (true)
            {
                #region MENU
                bool isArrayFull = index >= NUMBER_ELEMENTS; //IF INDEX >= NUMBER_ELEMENTS IT WILL ASSIGN TRUE TO THE BOOLEAN isArrayFull AND PRINT A MESSAGE
                for (int i = 0; i < menu.Length; i++)
                {
                    Console.WriteLine(menu[i]); //WILL PRINT THE MENU OPTIONS
                }
                Console.Write("SELECT AN OPTION: ");
                int options = 0;
                while (!Int32.TryParse(Console.ReadLine(), out options) || options < 1 || options > 7)  //VALIDATION
                {
                    Console.Write("ONLY NUMBERS FROM 1 TO 7 ARE ACCEPTED. TRY AGAIN: ");
                    Thread.Sleep(1000);
                    #endregion
                }
                switch (options)
                {
                    #region EXERCISE 1
                    case 1:
                        Console.Clear();
                        Console.WriteLine("1.STUDENT DATA\n");

                        if (!isArrayFull)
                        {
                            Console.Write("Enter Student ID: ");
                            while (!Int32.TryParse(Console.ReadLine(), out studentID[index]) || studentID[index] < 0)
                            {
                                Console.Write("**ONLY POSITIVE NUMBERS ACCEPTED**: ");
                                Thread.Sleep(1000);
                            }

                            Console.Write("Enter First Name: ");
                            studentData[index, 0] = Console.ReadLine();

                            while (String.IsNullOrEmpty(studentData[index, 0]))
                            {
                                Console.Write("**EMPTY DATA IS NOT ALLOWED** TRY AGAIN: ");
                                studentData[index, 0] = Console.ReadLine();
                            }

                            Console.Write("Enter Last Name: ");
                            studentData[index, 1] = Console.ReadLine();
                            while (String.IsNullOrEmpty(studentData[index, 1]))
                            {
                                Console.Write("**EMPTY DATA IS NOT ALLOWED** TRY AGAIN: ");
                                studentData[index, 1] = Console.ReadLine();
                            }
                            index++;

                            Console.WriteLine();
                            Console.WriteLine("**STUDENT DATA SAVED**");
                            Thread.Sleep(1000);
                            Console.Clear();
                        }
                        else
                        {
                            Console.WriteLine("**ARRAY IS FULL**");
                            Thread.Sleep(2000);
                            Console.Clear();
                        }
                        break;
                    #endregion
                    #region EXERCISE 2
                    case 2:
                        int i = 0;
                        Console.Clear();
                        Console.WriteLine("2.STUDENT GRADE");
                        Console.WriteLine();
                        Console.WriteLine("INDEX: " + "\tID: " + "\tFIRST NAME: " + "\tLAST NAME: ");
                        for (i = 0; i < NUMBER_ELEMENTS; i++)
                        {
                            if (studentID[i] != 0)
                                Console.WriteLine($"{i}\t{studentID[i]}\t{studentData[i, 0]}\t\t{studentData[i, 1]}");
                        }
                        Console.WriteLine();
                        Console.WriteLine("SELECT AN STUDENT INDEX TO INSERT THE GRADES: ");
                        while (!Int32.TryParse(Console.ReadLine(), out indexToSearch) || indexToSearch < 0 || indexToSearch > NUMBER_ELEMENTS)
                        {
                            Console.Write("Invalid index. It has to be between 0 and 9, try again: ");
                            Thread.Sleep(1000);
                            continue;
                        }
                        if (studentData[indexToSearch, 0] != null)
                        {
                            Console.Clear();
                            Console.WriteLine("INDEX: " + "\tID: " + "\tFIRST NAME: " + "\tLAST NAME: ");
                            Console.WriteLine($"{indexToSearch}\t{studentID[indexToSearch]}\t{studentData[indexToSearch, 0]}\t\t{studentData[indexToSearch, 1]}");
                            Console.WriteLine();
                            Console.Write("INSERT MIDTERM EXAME GRADE: ");
                            midtermGrade = double.Parse(Console.ReadLine());
                            Console.Write("INSERT FINAL PROJECT GRADE: ");
                            finalprojectGrade = double.Parse(Console.ReadLine());
                            Console.Write("INSERT FINAL EXAM GRADE: ");
                            finalexamGrade = double.Parse(Console.ReadLine());
                            Console.WriteLine();
                            double midtermgradeWeight = midtermGrade * 0.3;
                            double finalprojectgradeWeight = finalprojectGrade * 0.3;
                            double finalexamgradeWeight = finalexamGrade * 0.4;
                            double finalTotal = midtermgradeWeight + finalprojectgradeWeight + finalexamgradeWeight;

                            grades[indexToSearch, 0] = midtermgradeWeight;
                            grades[indexToSearch, 1] = finalprojectgradeWeight;
                            grades[indexToSearch, 2] = finalexamgradeWeight;
                            grades[indexToSearch, 3] = finalTotal;

                            Console.WriteLine("INDEX: " + "\tID: " + "\tFIRST NAME: " + "\tLAST NAME: " + "\tGRADES: ");
                            Console.Write($"{indexToSearch}\t{studentID[indexToSearch]}\t{studentData[indexToSearch, 0]}\t\t{studentData[indexToSearch, 1]}\t\t");
                            for (i = 0; i < grades.GetLength(1); i++)
                            {
                                Console.WriteLine(examTypes[i] + ": " + grades[indexToSearch, i]);
                                Console.Write("\t\t\t\t\t\t");
                            }
                            Thread.Sleep(3000);
                            Console.Clear();
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("INDEX NULL. ENTER STUDENT DATA IN OPTION 1");
                            Thread.Sleep(2000);
                            Console.Clear();
                        }
                        break;
                    #endregion
                    #region EXERCISE 3
                    case 3:
                        Console.Clear();
                        Console.WriteLine("3.STUDENTS INFORMATIONS");
                        Console.WriteLine();
                        Console.WriteLine("ID: " + "\tFIRST NAME: " + "\tLAST NAME: " + "\tGRADES: ");

                        for (i = 0; i < NUMBER_ELEMENTS; i++)
                        {
                            if (studentID[i] != 0)
                            {
                                Console.WriteLine();
                                Console.Write(studentID[i] + "\t" + studentData[i, 0] + "\t\t" + studentData[i, 1] + "\t\t");
                                for (int j = 0; j < grades.GetLength(1); j++)
                                {
                                    Console.WriteLine(examTypes[j] + ": " + grades[i, j] + "\t\t\t\t\t");
                                    Console.Write("\t\t\t\t\t");
                                }
                            }
                        }
                        Console.Write("\nTYPE ANY KEY TO GO BACK TO MENU: ");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    #endregion
                    #region EXERCISE 4
                    case 4:
                        Console.Clear();
                        Console.WriteLine("4.STUDENT DATA BY ID");
                        Console.WriteLine();
                        Console.Write("SELECT AN STUDENT ID FOR GRADE INFORMATION: \n");
                        Console.Write("\nID\tFIRST NAME\tLAST NAME\n");
                        for (i = 0; i < NUMBER_ELEMENTS;i++)
                        {
                            if (studentID[i] != 0)
                            {
                                Console.WriteLine($"{studentID[i]}\t{studentData[i, 0]}\t\t{studentData[i, 1]}");
                            }
                        }
                        while (!Int32.TryParse(Console.ReadLine(), out idToSearch) || idToSearch < 0)
                        {
                            Console.Write("Invalid ID. Try again: ");
                            Thread.Sleep(1000);
                            continue;
                        }
                        Console.WriteLine();
                        for (i = 0; i < NUMBER_ELEMENTS; i++)
                        {
                            if (studentID[i] != idToSearch)
                            {
                                continue;
                            }
                            else
                            {
                                Console.WriteLine("ID: " + "\tFIRST NAME: " + "\tLAST NAME: " + "\tGRADES: ");
                                Console.Write($"{studentID[i]}\t{studentData[i, 0]}\t\t{studentData[i, 1]}\t\t");
                                for (int j = 0; j < grades.GetLength(1); j++)
                                {
                                    Console.WriteLine(examTypes[j] + ": " + grades[i, j]);
                                    Console.Write("\t\t\t\t\t");
                                }
                                break;
                            }
                        }
                        Console.WriteLine();
                        Console.WriteLine("Press enter to go back to menu");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    #endregion
                    #region EXERCISE 5
                    case 5:
                        Console.Clear();
                        Console.WriteLine("5.GROUP AVERAGE");
                        Console.WriteLine();
                        double sum = 0;
                        for (i = 0; i < grades.GetLength(0); i++)
                        {
                            sum += grades[i, 3];
                        }
                        Console.WriteLine($"AVERAGE: {sum / grades.GetLength(0)}");
                        Thread.Sleep(1000);
                        Console.Clear();
                        break;
                    #endregion
                    #region EXERCISE 6
                    case 6:
                        Console.Clear();
                        Console.WriteLine("6.BEST STUDENT");
                        Console.WriteLine();

                        double melhorNota = -1;
                        int melhorAlunoIndex = -1;

                        for (i = 0; i < grades.GetLength(0); i++)
                        {
                            if (grades[i, 3] > melhorNota)
                            {
                                melhorNota = grades[i, 3];
                                melhorAlunoIndex = i;
                            }
                        }

                        if (melhorAlunoIndex != -1)
                        {
                            Console.WriteLine("BEST STUDENT INFORMATION:");
                            Console.WriteLine("ID: " + "\tFIRST NAME: " + "\tLAST NAME: " + "\tGRADES: ");
                            Console.Write($"{studentID[melhorAlunoIndex]}\t{studentData[melhorAlunoIndex, 0]}\t\t{studentData[melhorAlunoIndex, 1]}\t\t");
                            for (int j = 0; j < grades.GetLength(1); j++)
                            {
                                Console.WriteLine(examTypes[j] + ": " + grades[melhorAlunoIndex, j]);
                                Console.Write("\t\t\t\t\t");
                            }
                        }
                        else
                        {
                            Console.WriteLine("No students found. Enter student data first.");
                        }
                        Console.WriteLine();
                        Console.WriteLine("Press enter to go back to menu");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    #endregion
                    #region EXERCISE 7
                    case 7:
                        Console.Clear();
                        Console.WriteLine("ENDING APPLICATION...");
                        Thread.Sleep(1000);
                        Environment.Exit(0);
                        break;
                        #endregion
                }
            }
        }
    }
}
