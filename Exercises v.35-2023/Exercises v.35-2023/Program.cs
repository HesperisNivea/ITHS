﻿using Exercises_v._35_2023;
using System.Collections.Generic;
//Console.WriteLine("First Name is " + args[0]); // Added "Izabela" to command line argument (properties/debug)


//DrawBox(20, 20);

//Ex20();

//EX22 
//Console.WriteLine("Write a sequence, if you want to stop press enter.");
//List<string> list = new List<string>();
//bool loopBreaker = true;
//while (loopBreaker)
//{
//    string randomString = Console.ReadLine();
//    if (randomString == string.Empty)
//    {
//        loopBreaker = false;
//    }
//     list.Add(randomString);
//}
//Ex22(list);
// EX22

////EX23
//ConsoleKeyInfo keyInfo = new ConsoleKeyInfo();
//string randomString = Console.ReadLine();
//keyInfo = Console.ReadKey();
//char randomChar = keyInfo.KeyChar ;

//IndexOFAll(randomString, randomChar);
////EX23

//EX26
Counter counter = new Counter();
for (int i = 0; i < 100; i++)
{

    counter.CountUp();
    Console.WriteLine(counter.Count);
}
counter.Reset();
Console.WriteLine(counter.Count);
//EX26

void Ex10()
{
    string hej = "Hej";

    foreach (char c in hej)
    {
        Console.WriteLine(c);
    }

}

void Ex11()
{
    string[] numbers = new string[] { "noll", "ett", "tva", "tre", "fyra", "fem", "fem", "sex", "sju", "atta", "nio" };
    Console.WriteLine("Write a number: ");


    if (Int32.TryParse(Console.ReadLine(), out int result))
    {
        Console.WriteLine(numbers[result]);
    }
    else
    { Console.WriteLine("Something went wrong"); }


}
void Ex12()
{
    Console.WriteLine("How many numbers would you like to write down? :");
    int lenghtOfArray = Int32.Parse(Console.ReadLine());

    int[] numbers = new int[lenghtOfArray];

    for (int i = 0; i < lenghtOfArray; i++)
    {
        Console.WriteLine("Write a number nr.1: ");
        int number = Int32.Parse(Console.ReadLine());
        numbers[lenghtOfArray - i - 1] = number;

    }

    foreach (int num in numbers)
    {
        Console.WriteLine(num);
    }
}
void Ex15()
{

    string palindrom = Console.ReadLine();

    if (palindrom.Length % 2 == 1)
    {
        for (int i = 0; i < palindrom.Length; i++)
        {
            if (palindrom[i] != palindrom[palindrom.Length - 1 - i])
            {
                Console.WriteLine("This is not a palindrom.");
                break;
            }

        }
    }


}


void Ex16()
{
    string userInput = Console.ReadLine();
    string[] dividedUserInput = userInput.Split(' ');

    int number1 = int.Parse(dividedUserInput[0]);
    int number2 = int.Parse(dividedUserInput[2]);

    if (dividedUserInput[1] == "+")
    {
        Console.WriteLine(number1 + number2);
    }
    else if (dividedUserInput[1] == "-")
    {
        Console.WriteLine(number1 - number2);
    }
    else if (dividedUserInput[1] == "*")
    {
        Console.WriteLine(number1 * number2);
    }
    else if (dividedUserInput[1] == "/")
    {
        Console.WriteLine(number1 / number2);
    }
    else
    {
        Console.WriteLine("Wrong Input!");
    }
}
void Ex17()
{
    string randomSequence = Console.ReadLine();

    string input = Console.ReadLine();

    bool containsSearchResult = randomSequence.Contains(input);
    Console.WriteLine($"Contains \"{input}\"? {containsSearchResult}");

    string[] splitRandomSequence = randomSequence.Split(input);

    // kollar om input är i mellan eller börjar/slutar randomSequence (olika storlekar av splitRandomSequence)
    if (splitRandomSequence.Length > 1)
    {
        Console.Write(splitRandomSequence[0]);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write(input);
        Console.ResetColor();
        Console.Write(splitRandomSequence[1]);
    }
    else
    {
        if (splitRandomSequence[0][0] == randomSequence[0])
        {
            Console.Write(splitRandomSequence);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(input);
            Console.ResetColor();

        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(input);
            Console.ResetColor();
            Console.WriteLine(splitRandomSequence);
        }
    }

}

void Ex18()
{
    string userInput = Console.ReadLine();
    string[] dividedUserInput = userInput.Split(" ");
    List<int> stringsLength = new List<int>();
    int sum = 0;

    for (int i = 0; i < dividedUserInput.Length; i++)
    {
        stringsLength.Add(dividedUserInput[i].Length);

    }

    foreach (int i in stringsLength)
    {
        sum += i;
    }

    Console.WriteLine("Average number of characters in this sentence is: " + Math.Round((double)sum / dividedUserInput.Length));
}
void DrawBox(int width, int height)
{
    Console.Clear();
    char hash = '#';
    char minus = '-';
    for (int i = 0; i < height; i++)
    {
        Console.WriteLine();
        if (i == 0 || height - 1 == i)
        {
            for (int j = 0; j < width; j++)
            {
                Console.Write(hash);
            }
        }
        else
        {
            for (int j = 0; j < width; j++)
            {
                if (j == 0 || width - 1 == j)
                {
                    Console.Write(hash);
                }
                else
                { Console.Write(minus); }

            }
        }
    }
} //ex 19

void Ex20()
{

    ConsoleKeyInfo keyInfo = new ConsoleKeyInfo();
    Console.SetCursorPosition(2, 2);
    var currentPositionX = 2;
    var currentPositionY = 2;


    while (true)
    {

        keyInfo = Console.ReadKey(true);
        var enumKey = keyInfo.Key;

        if ((int)enumKey == 40)
        {
            currentPositionY++;
            Console.SetCursorPosition(currentPositionX, currentPositionY);
        }
        else if ((int)enumKey == 39)
        {
            currentPositionX++;
            Console.SetCursorPosition(currentPositionX, currentPositionY);
        }
        else if ((int)enumKey == 38)
        {
            currentPositionY--;
            Console.SetCursorPosition(currentPositionX, currentPositionY);
        }
        else if ((int)enumKey == 37)
        {
            currentPositionX--;
            Console.SetCursorPosition(currentPositionX, currentPositionY);
        }
        else if (enumKey.ToString() == "Spacebar")
        {
            currentPositionX++;
            Console.Write('@');
        }
        else
        {
            Console.SetCursorPosition(0, 21); // hardcoded location
            Console.WriteLine("You pressed wrong button.");
            Console.SetCursorPosition(currentPositionX, currentPositionY);
        }


    }





}

void Ex22(List<string> list)
{
    string longestString = "";
    for (int i = 0; i < list.Count - 1; i++)
    {
        if (list[i].Length > longestString.Length)
        {
            longestString = list[i];
        }
    }
    Console.WriteLine($"It is the longest string from the input:\n{longestString}");
}

void IndexOFAll(string text, char c)
{
    Console.WriteLine();
    List<int> listOfIndexes = new List<int>();
    for (int i = 0; i < text.Length; i++)
    {
        if ((char)text[i] == c)
        {
            listOfIndexes.Add(i);
        }
    }
    Console.WriteLine($"Positions of {c} in the given string are:");
    foreach (var index in listOfIndexes)
    {
        Console.WriteLine(index + 1);
    }

}


