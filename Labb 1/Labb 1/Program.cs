using System.Collections.Generic;
string userInput = "p"; // how to get it thru args[]

List<string> sequenseSellection = new List<string>();

for (int i = 0; i < userInput.Length; i++)
{
    string sequenceCollector = "";
    int sequenceMatchPosition = FoundSequenceMatchPosition(i, userInput); //if no math returns 'i' value
    if (sequenceMatchPosition == i)
    {
        //Console.WriteLine(i + " " + sequenceMatchPosition);
        //continue; 
    }
    else
    {
        for (int j = 0; j < i; j++)
        {
            Console.Write(userInput[j]);
        }

        for (int k = i; k <= sequenceMatchPosition; k++)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(userInput[k]);
            sequenceCollector += userInput[k];
            // ++++ collect a sequence into a string variable  ==> then when its ready Add to the List<>
        }
        sequenseSellection.Add(sequenceCollector); // collects value
        Console.ResetColor();

        for (int l = sequenceMatchPosition + 1; l < userInput.Length; l++)
        {

            Console.Write(userInput[l]);
        }
        Console.WriteLine();


    }

}
Console.WriteLine("---------------------------------------------------------------------------------");
Console.WriteLine("---------------------------------------------------------------------------------");
Console.WriteLine("---------------------------------------------------------------------------------");

int counter = 0;
long sum = 0;
foreach (string s in sequenseSellection)
{
    counter++;
    sum += long.Parse(s);
    Console.WriteLine("{0}. {1}", counter, s);
}
Console.WriteLine("---------------------------------------------------------------------------------");
Console.WriteLine("Summan ar:" + sum);
Console.WriteLine("---------------------------------------------------------------------------------");
static int FoundSequenceMatchPosition(int checkpiontLocation, string userInput)
{
    char checkpointValue = userInput[checkpiontLocation];
    if (!char.IsDigit(checkpointValue)) // if needed separate into else ifs  
    {
        //Console.WriteLine("x");
        return checkpiontLocation;

    }
    else
    {
        for (int i = checkpiontLocation + 2; i < userInput.Length; i++)  // check if its going to be easier with  just adding two instead of one (in case of exception of upper if-sats ) 
        {
            if (!char.IsDigit(userInput[i - 1]))
            {
                break;
            }
            else if (!char.IsDigit(userInput[i]))
            {
                //Console.WriteLine("Not a numeric character!!!!!");
                break;
            }
            else if (char.IsDigit(userInput[i]) && checkpointValue == userInput[i])
            {
                checkpiontLocation = i;
                break;
            }
        }

        return checkpiontLocation;
    }

}


