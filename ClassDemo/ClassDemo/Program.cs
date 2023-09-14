using ClassDemo;
using System.ComponentModel.Design;

CounterClass counterClass = new CounterClass();
CounterClass counterClass2 = new CounterClass();

if(counterClass.Equals(counterClass2))
{
    Console.WriteLine("De är samma!");
}
else
{
    Console.WriteLine("De ar inte samma!");
}
CounterRecord record = new CounterRecord();
CounterRecord record2 = new CounterRecord();
Console.WriteLine(record);

if (record.Equals(record2))
{
    Console.WriteLine("De är samma!");
}
else
{
    Console.WriteLine("De ar inte samma!");
}
CounterStruct counterStruct = new CounterStruct();
CounterStruct counterStruct2 = new CounterStruct();

if (record.Equals(record2))
{
    Console.WriteLine("De är samma!");
}
else
{
    Console.WriteLine("De ar inte samma!");
}
