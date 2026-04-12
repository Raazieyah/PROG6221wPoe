using ConsoleChatbotApp;
using Microsoft.VisualBasic;
using System;
using System.Media;



class Programs 
{

static void Main(string[] args) 
{

//ASCII art (Logo) was first created

Console.WriteLine(@"
  ___  _  _  ____  ____  ____  ____  _____  ____ 
 / __)( \/ )(  _ \( ___)(  _ \(  _ \(  _  )(_  _)
( (__  \  /  ) _ < )__)  )   / ) _ < )(_)(   )(  
 \___) (__) (____/(____)(_)\_)(____/(_____) (__) 
"
    );

        //Methods being called

    AudioPlayer myObject3 = new AudioPlayer();//Sound being played
    myObject3.Play();

    User myObject = new User();  //user response
    myObject.response();

    Chatbot myObject1 = new Chatbot();// colours,boarders,typing effects
    myObject1.Start();

    Chatbot myObject2 = new Chatbot();
    myObject2.console();

    
}
}









