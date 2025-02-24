Console.WriteLine("Welcome to Quiz App");
Console.WriteLine("Give answers to the questions and earn points accordingly");

int points=0;

string q1 ="What is the Capital Of India?";
Console.WriteLine(q1);
q1 = Console.ReadLine();
string ans1="Delhi";

if (q1 == ans1.Trim())
{
    Console.WriteLine("Your answer is correct");
    points = points + 1;
    Console.WriteLine($"Your score is: {points}");
}
else
{
    Console.WriteLine("Try again later");
    points = points - 1;
    Console.WriteLine($"Your score is: {points}");
}

string q2="What is known as the Silicon Valley of India?";
Console.WriteLine(q2);
q2=Console.ReadLine();
string ans2="Bangalore";

if (q2 == ans2.Trim())
{
    Console.WriteLine("Your answer is correct");
    points = points + 1;
    Console.WriteLine($"Your score is: {points}");
}
else
{
    Console.WriteLine("Try again later");
    points = points - 1;
    Console.WriteLine($"Your score is: {points}");
}

string q3="Who founded apple?";
Console.WriteLine(q3);
q3=Console.ReadLine();
string ans3="Steve Jobs";

if (q3 == ans3.Trim())
{
    Console.WriteLine("Your answer is correct");
    points = points + 1;
    Console.WriteLine(points);
}
else
{
    Console.WriteLine("Try again later");
    points = points - 1;
    Console.WriteLine(points);
}

if (points == 1)
{
    Console.WriteLine($"At least you got the first one right, I suggest googling 'GK', btw you scored {points} point");
}
else if (points == 2)
{
    Console.WriteLine($"Not bad, you got 2 correct, better luck next time, btw you scored {points} points");
}
else if(points==3)
{
    Console.WriteLine($"Yooohooo, you got all correct, you scored {points} points");
}
else
{
    Console.WriteLine("Just Die bro!!!!!!");
}