Console.WriteLine("You are gliding down a calm jungle river in your kayak. The sound of birds and rushing water fills the air. Suddenly, a large orangutan sits upon a mossy rock in the middle of the river, blocking your path. He beats his chest, leans forward, and speaks:");
Console.WriteLine("“Traveler, you shall not pass unless you answer my riddles! You have three chances. Fail, and I’ll send you back the way you came.”");
Console.WriteLine("");
Console.WriteLine("You are bewildered, yet curious.");
Console.WriteLine("");
Console.WriteLine("“Tell me human, what is your name?”");
Console.WriteLine("");
Console.WriteLine("Enter Your Name: ");

// Game asks for your name
string playerName = Console.ReadLine();
Console.WriteLine($"So, your name is " + playerName + "? Let us see if your wits match your paddle strength!");

// Game keeps count and will check how many lives you have at the end of the game, determining the ending you get
int playerLives = 3;

Console.WriteLine("---------"); // Divider for easy reading
Console.WriteLine();
Console.WriteLine("“Here is your first riddle.”");
Console.WriteLine();
Console.WriteLine("The Orangutan leans over your kayak to get closer");
Console.WriteLine();
Console.WriteLine("“I speak without a mouth and hear without ears. I have no body, but I come alive with wind. What am I?”");
Console.WriteLine();

// Console provides a collection of answers
Console.WriteLine("---------"); // Divider for easy reading
Console.WriteLine("1: Fire");
Console.WriteLine("2: Echo");
Console.WriteLine("3: Shadow");
Console.WriteLine("4: River");
Console.WriteLine("---------"); // Divider for easy reading
Console.WriteLine();
Console.WriteLine("Enter the number of the correct answer:");

string answerOne = Console.ReadLine();

if (answerOne == "2")
{
    Console.WriteLine("---------"); // Divider for easy reading
    Console.WriteLine();
    Console.WriteLine($"“Sharp mind, " + playerName + ".”");
}
else
{
    Console.WriteLine("---------"); // Divider for easy reading
    Console.WriteLine();
    Console.WriteLine("“Wrong! The jungle itself is smarter than you.”");
    playerLives -= 1; // Player will lose a life for every answer they get wrong
}
Console.WriteLine();
Console.WriteLine("“Onto your next riddle.”");
Console.WriteLine();
Console.WriteLine("The Orangutan reaches to caress your cheek like the good boy you are."); // This is lore accurate because orangutans have no sense of personal space
Console.WriteLine();
Console.WriteLine("“I have four limbs: two arms, two legs. If I raise one arm and one leg, how many limbs still touch the ground?”");
Console.WriteLine();
Console.WriteLine("---------"); // Divider for easy reading
Console.WriteLine();
Console.WriteLine("Enter the correct number:");

string answerTwo = Console.ReadLine(); // Read as string like normal
int numericAnswer = int.Parse(answerTwo); // Converts string into an int

if (numericAnswer == 2)
{
    Console.WriteLine("---------"); // Divider for easy reading
    Console.WriteLine();
    Console.WriteLine("“Your numbers are true. Perhaps you can paddle onward...”");
}
else
{
    Console.WriteLine("---------"); // Divider for easy reading
    Console.WriteLine();
    Console.WriteLine("“Wrong! Even a fish counts better than you!”");
    playerLives -= 1; // Player loses a life
}
Console.WriteLine();
Console.WriteLine("You are very uncomfortable so you begin to paddle away to the opposite direction, when suddenly...");
Console.WriteLine();
Console.WriteLine("“NOT SO FAST HUMAN!” The orangutan stops you dead at your tracks, staring you down with a furious look.");
Console.WriteLine();
Console.WriteLine("“You have ONE MORE riddle to solve before you may leave...”");
Console.WriteLine();
Console.WriteLine("You stop everything you're doing and freeze, scared for your life on what the orangutan may do to you if you disobey.");
Console.WriteLine();
Console.WriteLine("“Last riddle: What must be broken before you can use it?”");
Console.WriteLine();
Console.WriteLine("1: Egg");
Console.WriteLine("2: Stick");
Console.WriteLine("3: Rock");
Console.WriteLine("4: Lock");
Console.WriteLine();
Console.WriteLine("Enter the number of the correct answer:");

string answerThree = Console.ReadLine();

if (answerThree == "1")
{
    Console.WriteLine("---------"); // Divider for easy reading
    Console.WriteLine();
    Console.WriteLine($"“Yes, yes! You see through the shell of mystery. Well done, " + playerName + "!”");
}
else
{
    Console.WriteLine("---------"); // Divider for easy reading
    Console.WriteLine();
    Console.WriteLine("“Wrong! You are cracked, but more close to that of an egg.”");
    playerLives -= 1; // Player loses a life
}

Console.WriteLine();
Console.WriteLine("The orangutan leans forward and takes a look at you carefully...");

// Game will tally up your lives
if (playerLives == 3) // Player retained all lives
{
    Console.WriteLine($"“Impressive, {playerName}! You answered all riddles correctly! No wisdom lost, no stroke wasted. Here is a banana for your troubles. You may continue on your journey Human. I bid you farewell and safe travels.”");
    Console.WriteLine();
    Console.WriteLine("TRUE ENDING: GAME OVER");
}
else if (playerLives >= 1)  // Player has 1 or 2 lives left
{
    Console.WriteLine($"“You survived, {playerName}, but you stumbled along the way. You may pass, but not before I take your kayak as compensation!”");
    Console.WriteLine();
    Console.WriteLine("NEUTRAL ENDING: TRY AGAIN");
}
else // Player has no lives
{
    Console.WriteLine($"“Enough! Your mind is too dull for my riddles. Back you go!”");
    Console.WriteLine();
    Console.WriteLine("ENDING ENDING: TRY AGAIN");
}

Console.WriteLine();
Console.WriteLine("Press any key to leave the river...");
Console.ReadKey();  // waits for player to press a key before ending the game (I discovered this on accident)