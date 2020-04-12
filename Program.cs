/* Anthony Simon
 * SD7 11 Apr 2020
 * Math Games */

using System;

namespace MathGame
{
    class Program
    {
        static void Main(string[] args)
        {
            /* To initialize a session, you will ask the users to select the type of problem they want too practice and the 
             * number of problems. You will echo the problem type and the number of problems to the user.*/

            Flashcards flashcards = new Flashcards();
            Console.WriteLine("Welcome to my Math Game, what would you like to work on today?");
            Console.WriteLine("1. Addition ");
            Console.WriteLine("2. Subtraction ");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.WriteLine("Please Make A Selection ");

            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    flashcards.Addition();
                    break;
                case 2:
                    flashcards.Subtraction();
                    break;
                case 3:
                    flashcards.Multiplication();
                    break;
                case 4:
                    flashcards.Division();
                    break;
            }
            Console.WriteLine($"You are smarter than I thought with a {flashcards.Score}");
        }
    }

    class Flashcards
    {
        public int Score { get; set; }
        public int NumberOfQuestions { get; set; }
        int minValue;
        int maxValue;
        Random random = new Random();

        // The problems will generate random integers between 1 and 12, or whatever range you choose.
        public Flashcards()
        {
            NumberOfQuestions = 10;
            minValue = 1;
            maxValue = 12;
        }

        public Flashcards(int questions, int min, int max)
        {
            NumberOfQuestions = questions;
            minValue = min;
            maxValue = max;
        }

        public int Addition()
        {
            int correct = NumberOfQuestions;
            for (int i = 1; i <= NumberOfQuestions; i++)
            {
                int value1 = random.Next(minValue, maxValue);
                int value2 = random.Next(minValue, maxValue);
                Console.Write($"{i}. {value1} + {value2} = ");
                int answer = int.Parse(Console.ReadLine());
                if (answer == value1 + value2)
                {
                    Console.WriteLine("Correct!");
                }
                else
                {
                    /*  if the user misses a problem the application will display the correct answer to the problem. */
                    Console.WriteLine($"Sorry, the correct answer is  {value1 + value2} :/");
                    correct--;
                }
            }
            /* At the conclusion of the session the application will report the number of correctly answered questions 
            * and give a numeric score*/
                    return Score = correct * 100 / NumberOfQuestions;
        }
        public int Subtraction()
        {
            int correct = NumberOfQuestions;
            for (int i = 1; i <= NumberOfQuestions; i++)
            {
                int value1 = random.Next(minValue, maxValue);
                int value2 = random.Next(minValue, maxValue);
                if (value1 < value2)
                {
                    int t = value1;
                    value1 = value2;
                    value2 = t;
                }
                Console.Write($"{i}. {value1} - {value2} = ");
                int answer = int.Parse(Console.ReadLine());
                if (answer == value1 - value2)
                {
                    Console.WriteLine("Correct!");
                }
                else
                {
                    /*  if the user misses a problem the application will display the correct answer to the problem. */
                    Console.WriteLine($"Sorry, the correct answer is  {value1 - value2} :/");
                    correct--;
                }
            }
            /* At the conclusion of the session the application will report the number of correctly answered questions 
            * and give a numeric score*/
            return Score = correct * 100 / NumberOfQuestions;
        }
        public int Multiplication()
        {
            int correct = NumberOfQuestions;
            for (int i = 1; i <= NumberOfQuestions; i++)
            {
                int value1 = random.Next(minValue, maxValue);
                int value2 = random.Next(minValue, maxValue);
                Console.Write($"{i}. {value1} X {value2} = ");
                int answer = int.Parse(Console.ReadLine());
                if (answer == value1 * value2)
                {
                    Console.WriteLine("Correct!");
                }
                else
                {
                    /*  if the user misses a problem the application will display the correct answer to the problem. */
                    Console.WriteLine($"Sorry, the correct answer is  {value1 * value2} :/");
                    correct--;
                }
            }
            /* At the conclusion of the session the application will report the number of correctly answered questions 
            * and give a numeric score*/
            return Score = correct * 100 / NumberOfQuestions;
        }
        public int Division()
        {
            int correct = NumberOfQuestions;
            for (int i = 1; i <= NumberOfQuestions; i++)
            {
                float value1 = random.Next(minValue, maxValue);
                float value2 = random.Next(minValue, maxValue);
                Console.Write($"{i}. {value1} / {value2} = ");
                float answer = float.Parse(Console.ReadLine());
                if (answer + 0.1 > value1 / value2 && answer - 0.1 < value1 / value2)
                {
                    Console.WriteLine("Close counts!");
                }
                else
                {
                    /*  if the user misses a problem the application will display the correct answer to the problem. */
                    Console.WriteLine($"Sorry, the correct answer is  {value1 / value2} :/");
                    correct--;
                }
            }
            /* At the conclusion of the session the application will report the number of correctly answered questions 
             * and give a numeric score*/ 
            return Score = correct * 100 / NumberOfQuestions;
        }

    }
}
