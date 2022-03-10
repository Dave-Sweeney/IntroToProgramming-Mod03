using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // EX 1 - Task 2.  Call the SetInstructorName function, and pass your name to it as a value.
            SetInstructorName("David Sweeney");
            
            SetCourseTitle("CS101");
            
            // EX 2 - Task 2.  Create a nested if statement that checks if a class is in the program, 
            // if it is required, and if it is an elective.  Then output the result text to the Console
            // window.  Call this function from within Main.
            ValidateClass("CS101", true, true, true);
            ValidateClass("CS201", true, true, false);
            ValidateClass("CS301", true, false, true);
            ValidateClass("PHYS101", false, true, true);
            ValidateClass("PHYS288", false, true, false);
            ValidateClass("MATH355", false, false, true);
            ValidateClass("GYM089", false, false, false);

            DisplayReminders("Wednesday");
            DisplayReminders("Friday");
            DisplayReminders("Sunday");

            CalculateAverage();
            CalculateAverageFromUserInput();
            Console.ReadKey();


        }

        // Ex 1 - Task 1.1  Create a function called SetInstructorName that accepts a string value but doesn't return
        // a value
        static void SetInstructorName(string name)
        {
            
        }

        // EX 1 - Task 1.2  Create a function called SetCourseTitle that accepts a string value but doesn't return
        // a value.
        static void SetCourseTitle(string title)
        {
            // EX 1 - Task 4.  Call the ValidateCourseTitle function from within the SetCourseTitle function,
            // passing in the title that is passed to the SetCourseTitle function.
            ValidateCourseTitle(title);

        }

        // EX 1 - Task 3.  Create a function called ValidateCourseTitle that accepts a string and returns a 
        // Boolean result.
        static bool ValidateCourseTitle(string validateTitle)
        {
            bool output;
            
            // EX 2 - Task 1.1.  Create an if else statement to validate the length of a course title.
            if (validateTitle.Length > 0)
            {
                output = true;
            }
            else
            {
                output = false;
            }

            // EX 2 - Task 1.2.  Create an if else statement to output a statement that indicates the success
            // or failure of the course length validation routine.
            if (output)
            {
                Console.WriteLine("Success");
            }
            else
            {
                Console.WriteLine("Failure");
            }
            return output;
        }

        // EX 2 - Task 2.  Create a nested if statement that checks if a class is in the program, 
        // if it is required, and if it is an elective.  Then output the result text to the Console
        // window.  Call this function from within Main.
        static void ValidateClass(string title, bool isInProgram, bool isRequired, bool isElective)
        {
            if (isInProgram)
            {
                if (isRequired)
                {
                    Console.WriteLine($"{ title } is in the program and is required.");
                }
                else if (isElective)
                {
                    Console.WriteLine($"{ title } is in the program and is an elective.");
                }
                else
                {
                    Console.WriteLine($"{ title } is in the program but is not required and not an elective.");
                }
            }
            else
            {
                Console.WriteLine($"{ title } is not in the program.");
            }
        }

        // EX 2 Task 3.  Create a function that uses a switch statement to display reminders on the console
        // when a discussion, post, quiz, or assignment is due.  Use the following logic:  Discussions on 
        // Wednesday, Quiz on Friday, and Assignment on Sunday.
        static void DisplayReminders(string dayOfWeek)
        {
            switch (dayOfWeek)
            {
                case "Wednesday":
                    Console.WriteLine("Discussions are due.");
                    break;
                case "Friday":
                    Console.WriteLine("Quiz is due.");
                    break;
                case "Sunday":
                    Console.WriteLine("Assignment is due.");
                    break;
                default:
                    break;
            }

            //DayOfWeek day = DateTime.Today.DayOfWeek;

            //switch(day)
            //{
            //    case DayOfWeek.Wednesday:
            //        Console.WriteLine("Discussions are due");
            //        break;
            //    case DayOfWeek.Friday:
            //        Console.WriteLine("Quiz is due");
            //        break;
            //    case DayOfWeek.Sunday:
            //        Console.WriteLine("Assignment is due");
            //        break;
            //    default:
            //        Console.WriteLine("Nothing due at this time.");
            //        break;

            //}
        }

        // EX 3 Task 1.  Create a for loop that iterates over an array of grades to calculate the average.
        // Because you have not learned how to create arrays yet, there is stub code for this function already
        // created for you in the starter project with an array declared.  Use that for this task.
        static void CalculateAverage()
        {
            double[] grades = new double[] { 89, 98, 99, 90, 95 };
            double average = 0.0;
            double total = 0.0;
            
            for (int i = 0; i < grades.Length; i++)
            {
                total += grades[i];
            }

            average = total / grades.Length;
            Console.WriteLine($"GPA: { average }");
        }

        // EX 3 Task 2.  Create a while loop that takes grades from the user and calculates the average
        // of all grades entered.  You have not learned how to accept input from a user in a console
        // application yet.  Therefore, the following lines of code are provided here for your use.
        // C#
        // grade = Double.Parse(Console.Readline());
        static void CalculateAverageFromUserInput()
        {
            double grade = 0.0;
            double total = 0.0;
            double average = 0.0;
            int gradeCounter = 0;

            Console.Write("First grade: ");
            grade = Double.Parse(Console.ReadLine());

            while (grade != -1)
            {
                total = total + grade;
                gradeCounter++;
                Console.Write("Next grade (-1 to exit): ");
                grade = Double.Parse(Console.ReadLine());
            }

            average = total / gradeCounter;
            Console.WriteLine($"GPA: { average }");


        }
    }
}
