int counter = 0;
for (int i = 0; i < args.Length; i++)
{
    counter++;
    Console.WriteLine($"{counter}. {args[i]}");
}