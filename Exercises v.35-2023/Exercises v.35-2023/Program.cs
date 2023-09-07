Ex15();

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
        numbers[lenghtOfArray -i -1] = number;
        
    }

    foreach (int num in numbers)
    {
        Console.WriteLine(num);
    }
}
void  Ex15()
{

    string palindrom = Console.ReadLine();

    if(palindrom.Length % 2 == 1)
    {
        for(int i = 0; i < palindrom.Length; i++)
        {
            if (palindrom[i] != palindrom[palindrom.Length -1 -i])
            { 
                Console.WriteLine("This is not a palindrom.");
                break;
            }

        }
    }
     

}

