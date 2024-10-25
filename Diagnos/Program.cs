string answer1;

string answer2;

string answer3;

int fails = 0;

int chance = 0;

int correct = 0;

string chances;


Console.WriteLine("Welcome to the question house!");
Console.Write("We will ask you some questions about what we are thinking about and you will try to guess them!");
Console.ReadLine();

Console.Clear();
Console.WriteLine("How many chances do you want to get? 1 or 2?");
chances = Console.ReadLine();
if (chances == "1")
{
    chance++;
    Console.WriteLine($"Alright, you get {chance} chance left!");
    Console.ReadLine();
}
if (chances == "2")
{
    chance++;
    chance++;
    Console.WriteLine($"Alright, you get {chance} chances left!");
    Console.ReadLine();
}
if (chances == "")
{
    Console.WriteLine("You have to choose how many guesses you want!");
    chances = Console.ReadLine();
}


Console.Clear();
Console.WriteLine("The words are Poland, Table, Pneumonoultramicroscopicsilicovolcanoconiosis, guess what I am thinking about!");
answer1 = Console.ReadLine();
while (answer1 == "")
{
    if (answer1 == "")
    {
        Console.WriteLine("Listen buddy, you need to answer it.");
        answer1 = Console.ReadLine();
    }
}
if (answer1 == "Poland")
{

    chance--;
    if (chance == 1) 
    {
        fails++;
        Console.WriteLine($"WRONG! You have used 1 your chances, you have {chance} left, try again!");
        answer1 = Console.ReadLine();
    }
}
if (answer1 == "Table")
{
    chance--;
    if (chance == 1) 
    {
        fails++;
        Console.WriteLine($"WRONG You have used 1 your chances, you have {chance} left, try again!");
        answer1 = Console.ReadLine();
    }
}
if (answer1 == "Pneumonoultramicroscopicsilicovolcanoconiosis")
{
    {
        correct++;
        Console.WriteLine("You got it right! The answer WAS Pneumonoultramicroscopicsilicovolcanoconiosis!");
        Console.ReadLine();
    }
}
Console.WriteLine($"You answered the first and you have {chance} chance/s left and {fails} fails");
Console.WriteLine("Ready for the second question?");
Console.ReadLine();
Console.Clear();

