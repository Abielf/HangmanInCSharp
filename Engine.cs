using System;

namespace HangmanCSharp
{
    class HangmanEngine
    {
        private string display="";

        //player guess
        private char g;

        private string guessBank="";
        private int guessesLeft=6;

        //get difficulty and answer
        public Answer a = new Answer();
        

        //gameDone variable is 0 while game is going, changes to 1 for a win and 2 for a loss that triggers final guess
        private int gameDone=0;


        public HangmanEngine(){
            
            a.getChoice();
            //DEBUG CHEAT! haha, comment out this once the project is complete----------------------------------------
            //Console.WriteLine(a.solution);
            
            //loop building display string
            for(int i=0;i<a.solution.Length;i++){
                display=display+"*";
            }
            play();

            if(gameDone==2){lastChance();}

            /*to do list: 
            check for game end (code 0, 1, or 2)
            on bad end, give player final chance to guess full solution
             */

        }

        //method responsible for game logic
        private void play(){
            while(gameDone==0){ 
                Console.WriteLine(display);
                makeGuess();
                if(a.solution.Contains(g)){
                    Console.WriteLine("Good Guess!");
                    string temp="";
                    for(int i=0;i<a.solution.Length;i++){
                        if(a.solution[i]==g){
                            temp=temp+g;
                        }else{temp=temp+display[i];}
                    }
                    display = temp;
                    if(display.Equals(a.solution)){
                        Console.WriteLine("You did it! You win!");
                        gameDone=1;
                        }
                }else { 
                    Console.WriteLine("Bzzt, wrong!");
                    guessesLeft--;
                    switch(guessesLeft){
                        case 0:
                        Console.WriteLine("And that's the head! Game over, you lose!");
                        gameDone=2;
                        break;

                        case 1:
                        Console.WriteLine("Right arm....");
                        break;

                        case 2:
                        Console.WriteLine("Left arm....");
                        break;

                        case 3:
                        Console.WriteLine("Right leg.....");
                        break;

                        case 4:
                        Console.WriteLine("Left leg....");
                        break;

                        case 5:
                        Console.WriteLine("Thats a body....");
                        break;
                        }
                    }
                }

        }

        //method responsible for prompting player for guess and validating
        private void makeGuess(){
            while(true){
                Console.WriteLine("Letters you've guessed:"+guessBank);
                Console.WriteLine("Guess a letter!");
            string guess=Console.ReadLine();
            if(guess.Length!=1){
                Console.WriteLine("Invalid guess, enter a single letter");
                continue;
            }
            g=Convert.ToChar(guess);
            if(!char.IsLetter(g)){
                Console.WriteLine("Invalid guess, enter a single letter");
                continue;}
            g=char.ToLower(g);
            if(guessBank.Contains(g)){
                Console.WriteLine("You guessed that already! Try again.");
                continue;}
            guessBank=guessBank+g;
            break;
            }
        }

        private void lastChance(){
                Console.WriteLine("Or DO YOU?");
                Console.WriteLine("This is it! Your final moment! You get one last guess before you lose.");
                Console.WriteLine("Make your guess, choose your fate.");
                string lastGuess = Console.ReadLine().ToLower();
                if(lastGuess.Equals(a.solution)){
                    Console.WriteLine("You did it! Against all odds, in the final hour, you won!");
                    }else {Console.WriteLine("Wrong! You lose! For real this time, too! Good game!");}
        }
    }
}