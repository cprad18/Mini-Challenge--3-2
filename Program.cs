//Christopher Prado
//Date Revised: 12OCT22
//Mini Challenge #3 "Build an app where you ask 2 questions 
//We will ask the users name
//We will ask what time the user woke up
// We will print out user name and what time they woke up
//Make sure you print the results in one line
//Peer Review by: 

Console.Clear();

bool playagain = true;
string noPlay = Console.ReadLine();

while (playagain){

Console.WriteLine("What is your name?");

string myName = Console.ReadLine();

Console.WriteLine("What time did you wake up?");

string myTime = Console.ReadLine();

Console.WriteLine(myName + " woke up today at " + myTime);
Console.WriteLine("If you would like to continue playing press any key or "no" if you want to stop");

if(noPlay == "no"){
    playagain again = false;
}else{
    playagain = true;
}
}




