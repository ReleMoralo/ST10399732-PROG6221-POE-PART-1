using System;
using System.Media;
using NAudio.Wave;
class Program
{
    static void Main()
    {
        //Also before this we should play the voice message for the cyber bot
        PlayAudio("welcome.wav"); // We are going to create a method for this ,his is just calling the method
        Console.WriteLine("");

        //This is an ASCII IMAGE FOR THE CYBER BOT

        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("      .-\"      \"-.");
        Console.WriteLine("    /            \\");
        Console.WriteLine("   |              |");
        Console.WriteLine("   |,  .-.  .-.  ,|");
        Console.WriteLine("   | )(_o/  \\o_)( |");
        Console.WriteLine("   |/     /\\     \\|");
        Console.WriteLine("   (_     ^^     _)");
        Console.WriteLine("    \\__|IIIIII|__/");
        Console.WriteLine("     | \\IIIIII/ |");
        Console.WriteLine("     \\          /");
        Console.WriteLine("      `--------`");
        Console.WriteLine("  [ CYBERSECURITY CHATBOT! ]");
        Console.WriteLine("     Protecting Your Data!");
        Console.ResetColor();

        Console.WriteLine("");

        //This should play after the voice play the words must come in an art form 
        //Changing the color between user and chatbot for readability
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Hello and welcome to a Cybersecurity Awareness Chatbot!!");
        Console.WriteLine("May i start ny asking for your name"); //This is it to get the name of the user
        Console.ResetColor();
        Console.WriteLine("");
        string userName = Console.ReadLine();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("");
        Console.WriteLine("Welcome " + userName + " How can i be of help today ? ");
        Console.ResetColor();

        Console.WriteLine("");
        
        //Here we should add the code that will handle if the user asks how are you? what is your purpose and what can i ask you about.

        while (true) // This is a while loop which will loop indifinte if users inputs the right answers all the time
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Please type a number of the topic you would like to know about");
            Console.WriteLine("");
            Console.WriteLine("Topics of Cybersecurity");
            Console.WriteLine("1. Password Safety");
            Console.WriteLine("2. Safe Browsing");
            Console.WriteLine("3. Phishing");
            Console.WriteLine("4. Chatbot information");
            Console.WriteLine("5. EXIT");
            Console.ResetColor();

            //This is for taking the input from the user for the option selection and other questions that may arrise
            string userChoice = Console.ReadLine();


            switch (userChoice.ToLower().Trim())
            {
                //Five Options to be handled for Cyberssecurity
                case "1":
                    PasswordSafety();
                    break;
                case "2":
                    Console.WriteLine("Safe browsing consists of not using torrents and using known sites");
                    break;
                case "3":
                    Console.WriteLine("Provide guidelines on avoiding malicious websites and using secure connections");
                    break;
                case "4":
                    Console.WriteLine("I am a Cybersecurity Awareness Chatbot, designed to help users stay safe online!\"");
                    break;
                case "5":
                    Console.WriteLine("Goodbye ," + userName + " Stay safe online !!");
                    return;
                case "":
                    Console.WriteLine("Invalid operation please choose from the given options");
                    break;

                //This is to the handle the three questions which are ,How are you ,what is your purpose and what can i ask you about.
                case "how are you":
                    Console.WriteLine("I am just a Chatbot. I am here to ansnwer only related questions");
                    break;
                case "what is your purpose":
                    Console.WriteLine("I here to educate you about the importance of Cybersecurity");
                    break;
                case "what can i ask you about":
                    Console.WriteLine("Anything related to the five options given above");
                    break;
                default:
                    Console.WriteLine("Invalid operation ,Please input a valid operation to get help");
                    break;
            }

            //This is just a line for readability between loop iterations
            Console.WriteLine("");
        }

    }
    static void PlayAudio(string filePath)
    {
        try
        {
            SoundPlayer player = new SoundPlayer(filePath);
            player.Play(); // Plays sound while showing the welcome message and ASCII LOGO
        }
        catch (Exception e)
        {
            Console.WriteLine("Error playing sound: " + e.Message);
        }
    }

    static void PasswordSafety()
    {
        Console.WriteLine("A safe password consists of 12 characters, Mixed not only numbers letters. Number ,letters and signs");
    }
}
