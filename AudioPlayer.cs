
using System;
using System.Media;



namespace ConsoleChatbotApp
{  //place audio in correct place
   internal class AudioPlayer
    {
        public void Play() {
            //Used path full instead of file names in order to work
          SoundPlayer player = new SoundPlayer("C:\\Users\\david\\source\\repos\\ConsoleChatbotApp\\ConsoleChatbotApp\\bin\\Debug\\chatbotGreeting.wav");
            player.Play();

        }


        
    }
}
