using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ConsoleChatbotApp
{  
     public class Chatbot
    {
        public void Start()
        {
            Console.ForegroundColor = ConsoleColor.Green;//colours
            Console.WriteLine("Welcome please feel free to ask us questions.");
            Console.ResetColor();

            Console.WriteLine("-------------------------");//boarders
            Console.WriteLine("Cyber security Chatbot");
            Console.WriteLine("-------------------------");

            foreach (char c in "Welcome please feel free to ask us questions.")//typing effects
            {
                Console.Write(c);
                Thread.Sleep(70);
            }
            Console.WriteLine();   

            
            //added another method to these

           
        }


        
        public void console() //basic response system added
        {  
            string input = Console.ReadLine().ToLower();

            while (true) { //while loop to continue running

            if (input == "how are you?") // questions users would ask and information about cybersecurity
            {
                Console.WriteLine("I am a Chatbot here to assist you");
            }
            else if (input.Contains("what is your purpose?"))
            {
                Console.WriteLine("I am here to assist you on questions you have about cyber security");
            }
            else if (input.Contains("what can i ask you about?")) //amother if statement
            {
                Console.WriteLine("You may ask me about: phising,password safety,safe browsing");
                string input1 = Console.ReadLine().ToLower();

                if (input1 == "phising") // user needs to choose from options
            {
                Console.WriteLine("Make sure that you never click on links or open unexpected emails.");
            } 
            else if (input1.Contains("password safety"))
            {
                Console.WriteLine("Make sure to enable two-factor authentication on all accounts.");
            }
            else if (input1 == "browsing Safety")
            {
                Console.WriteLine("Always keep your browser updated and manager browser permissions.");
            }
            else if (string.IsNullOrWhiteSpace(input1)) //input validation
            {
                Console.WriteLine("Sorry I don't quite understand that.Could you please rephrase that?");
            }
            }
            else
            {
                Console.WriteLine("Sorry I don't quite undertstand that.");//add input invalidation?
            }
            }
          

           
            //add another user input  
            
        }
    }
}
