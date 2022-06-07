using System;

namespace Number_Guess_Randomly
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GetAppInfo();   //Run GetAppInfo Function to get info

            GreetUser();    //Ask for users Name and Greet


            while (true)
            {
                //Set A Number
                //int correctNumber = 18;

                //Create a New Random Object
                Random random = new Random();

                //Set A Number
                int correctNumber = random.Next(1, 25);

                // Guess a Number Var
                int guess = 0;

                Console.WriteLine("Guess a Number from 1 to 25");

                // While guess is not equal to correct number
                while (guess != correctNumber)
                {
                    //Get User Input
                    string num = Console.ReadLine();

                    // Make sure its a number Not A Alphabets
                    if (!int.TryParse(num, out guess))
                    {

                        /* //Change text Color
                        Console.ForegroundColor = ConsoleColor.Red;

                        //Tell User its not alphabet
                        Console.WriteLine("Please Enter an Actual Number");

                        //Reset text Color
                        Console.ResetColor();*/

                        //Print error Message
                        PrintColorMessage(ConsoleColor.Red, "Please Used an Actual Number");

                        //Keep Going
                        continue;

                    }

                    //Cast to int and put in guess
                    guess = Int32.Parse(num);

                    //Match guess to correct number
                    if (guess != correctNumber)
                    {
                        //Change Forground Color
                        Console.ForegroundColor = ConsoleColor.Red;

                        //Output
                        Console.WriteLine("Wromg Number, Please try again");

                        //Reset text Color
                        Console.ResetColor();

                    }

                }
                //Output success Message

                //Change Forground Color
                Console.ForegroundColor = ConsoleColor.Yellow;

                //Output
                Console.WriteLine("You Are Correct!!! ");

                //Reset text Color
                Console.ResetColor();


                //Ask to Play Agaian
                Console.WriteLine("Play Again? [Y or N]");

                //Get Answers
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else if(answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }

            }

        }

        // Get and Display App Info
        static void GetAppInfo()
        {
            //Set App Var
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Atif Aqeel";

            //Change Forground Color
            Console.ForegroundColor = ConsoleColor.DarkGray;

            //Write Out App Info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            //Change test Color
            Console.ForegroundColor = ConsoleColor.Green;

        }


        //Ask User Name And Greeting
        static void GreetUser()
        {
            //User Input
            Console.WriteLine("Please Enter Your Name :");
            String name = Console.ReadLine();
            Console.WriteLine("Hello {0}, let's play a game...", name);

            //Reset text Color
            Console.ResetColor();
        }


        //Print Color Messages
        static void PrintColorMessage(ConsoleColor color, string message)
        {
            //Change text Color
            Console.ForegroundColor = color;

            //Tell User its not alphabet
            Console.WriteLine(message);

            //Reset text Color
            Console.ResetColor();
        }



    }
}
