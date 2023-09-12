using System.Collections.Generic;

List<string> sequenceCollection = new List<string>(); // collects found sequences for later sum calculation.
string separator = "---------------------------------------------------------------------------------";
Console.WriteLine("Inför sekvens: ");
string userInput = Console.ReadLine(); //"29535123p48723487597645723645" 
Console.WriteLine(separator);

for (int i = 0; i < userInput.Length; i++)
{
    string sequenceCollector = ""; //
    int sequenceMatchPointLocation = LookingForMatchingPointLocation(i, userInput); 
    if (sequenceMatchPointLocation == i) 
    {
        // if LookingForMatchingPointLocation didnt find a matching point it returned i value == checkpoint value
    }
    else // sequence was found 
    {
        for (int j = 0; j < i; j++)
        {
            Console.Write(userInput[j]);
        }

        for (int k = i; k <= sequenceMatchPointLocation; k++)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(userInput[k]);
            sequenceCollector += userInput[k]; // collect a sequence into a string variable 
        }
        sequenceCollection.Add(sequenceCollector); // collects value
        Console.ResetColor();

        for (int l = sequenceMatchPointLocation + 1; l < userInput.Length; l++)
        {

            Console.Write(userInput[l]);
        }
        Console.WriteLine();


    }

}

Console.WriteLine(separator);
Console.WriteLine(separator);
Console.WriteLine(separator);

int counter = 0;
long sum = 0;
foreach (string s in sequenceCollection)
{
    counter++;
    sum += long.Parse(s);
    Console.WriteLine("{0}. {1}", counter, s);
}
Console.WriteLine(separator);
Console.WriteLine("Summan ar:" + sum);
Console.WriteLine(separator);

int LookingForMatchingPointLocation(int checkpiontLocation, string userInput) 
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


