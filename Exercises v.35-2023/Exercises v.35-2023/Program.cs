Ex18();

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
    if(splitRandomSequence.Length > 1 ) 
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

        }else
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

    for(int i = 0; i < dividedUserInput.Length; i++)
    {
        stringsLength.Add(dividedUserInput[i].Length);

    }
         
    foreach(int i in stringsLength) 
    {
        sum += i;
    }

    Console.WriteLine("Average number of characters in this sentence is: " + Math.Round((double)sum/dividedUserInput.Length));
}

