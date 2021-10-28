using System;

namespace HangmanCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string keepPlaying="y";
            while(keepPlaying=="yes"||keepPlaying=="y"){
                Console.WriteLine("Let's play hangman!");
                HangmanEngine h = new HangmanEngine();
                Console.WriteLine("Did you want to play again?");
                keepPlaying=Console.ReadLine().ToLower();
                if(keepPlaying=="yes"||keepPlaying=="y"){
                    Console.WriteLine("Cool, let's go again!");}
                else{Console.WriteLine("Okay, thanks for playing. Bye!");}
            }
        }
    }
}
