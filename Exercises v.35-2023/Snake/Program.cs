//whiteboard
//snake mechanic
// fruits
// reading movement keys 

ConsoleKeyInfo keyInfo = new ConsoleKeyInfo();
keyInfo = Console.ReadKey(true);

string key = keyInfo.Key.ToString();

var enumKey = keyInfo.Key;

Console.WriteLine(key);

if (key == "DownArrow")
{
    Console.WriteLine("hej");
}
else if ((int)enumKey == 38)
{
    
    Console.WriteLine("Hej då!");
}

