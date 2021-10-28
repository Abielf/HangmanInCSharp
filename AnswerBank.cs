using System;

namespace HangmanCSharp{

    /*point of this class is to prompt the user for what difficulty 
    they want their game set to, and set the answer to a word from the appropriate
    array. NOTE: the difference in difficulty is wordlength*/

class Answer{
    //three arrays are the potential hangman solutions
private string[] easy= new string[]{"color", "birds", "apple"};
private string[] medium= new string[]{"council", "binding", "academy"};
private string[] hard= new string[]{"abandoned", "bachelors", "caboodles"};

private string choice;

public string solution
{get ; private set;}

public Answer(){
}


public void getChoice(){
solution="Not yet set";
    while(solution == "Not yet set"){
    Console.WriteLine("Choose your difficulty! Enter easy(5 letters), medium(7 letters), hard (9 letters)!");
    choice=Console.ReadLine().ToLower();
    solution=validateChoice(choice);
    }
}

public string validateChoice(string c){
    string s;
    Random r=new Random();
    if(c=="easy"){s = easy[r.Next(3)];}
    else if(c=="medium"){s = medium[r.Next(3)];}
    else if(c=="hard"){s = hard[r.Next(3)];}
    else {
        Console.WriteLine("Invalid choice!");
        s="Not yet set";
        }
    return s;
}

}
}