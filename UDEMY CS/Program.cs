Console.WriteLine("Welcome to Gamify");
Console.WriteLine("1. Quiz\n 2. Guess the number");
Console.WriteLine("Enter your choice: ");

int choice = 0;
choice = Int32.Parse(Console.ReadLine());
if (choice == 1)
{
    quiz();
}
else if (choice == 2)
{
    guess();
}
else
{
    Console.WriteLine("Enter valid input");
}

static void guess()
{
    Console.WriteLine("Welcome to guessing game\n Guess the correct number and win the game");
    Console.WriteLine("The number is between 1 to 10\n You have 3 chances to get the correct guess\n All the best");
    Random random = new Random();
    int random_num = random.Next(1, 10);
    Console.WriteLine(random_num); // For testing purposes
    Console.WriteLine("Enter your guess: ");
    int guess_number=int.Parse(Console.ReadLine());
    int chance = 3;
    for (int i = chance; i < chance; i--)
    {
        Console.WriteLine($"You have {chance} left");
    }

    if (chance == 2)
    {
        Console.WriteLine("You stll have chances left");
    }
    else if (chance == 1)
    {
        Console.WriteLine("Just one left, make it count");
    }
    else if (chance == 0)
    {
        Console.WriteLine("You have exhausted all your trials");
    }
    else
    {
        Console.WriteLine("Error");
    }
    if (random_num == guess_number)
    {
        Console.WriteLine("Congrats, you won!!");
    }
    else
    {
        Console.WriteLine("Oops");
    }
}

static void quiz()
{
    Console.WriteLine("Welcome to the Quiz\n Answer all the questions carefully and win points on every correct answer\n All the best");
    int points = 0;

    string q1 = "What is the Capital Of India?";
    Console.WriteLine(q1);
    q1 = Console.ReadLine();
    string ans1 = "Delhi";

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

    string q2 = "What is known as the Silicon Valley of India?";
    Console.WriteLine(q2);
    q2 = Console.ReadLine();
    string ans2 = "Bangalore";

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

    string q3 = "Who founded apple?";
    Console.WriteLine(q3);
    q3 = Console.ReadLine();
    string ans3 = "Steve Jobs";

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
        Console.WriteLine(
            $"At least you got the first one right, I suggest googling 'GK', btw you scored {points} point");
    }
    else if (points == 2)
    {
        Console.WriteLine($"Not bad, you got 2 correct, better luck next time, btw you scored {points} points");
    }
    else if (points == 3)
    {
        Console.WriteLine($"Yooohooo, you got all correct, you scored {points} points");
    }
    else
    {
        Console.WriteLine("Just Die bro!!!!!!");
    }
}