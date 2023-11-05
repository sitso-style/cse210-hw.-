using System;

Console.Write("What is your grade percentage? ");
string answer = Console.ReadLine();
int percent = int.Parse(answer);

string letter = "";

if (percent >= 90)
{
    letter = "A";
}
else if (percent >= 80)
{
    letter = "B";
}
else if (percent >= 70)
{
    letter = "c";
}
else if (percent >= 60)
{
    letter = "D";
}
else
{
    letter = "F";
}

Console.WriteLine($"your grade is: {letter}");

if (percent >= 70)
{
    Console.WriteLine("Congratulations! You passed the course.");

}
else
{
    Console.WriteLine("Sorry, you did not pass this course.");
}
