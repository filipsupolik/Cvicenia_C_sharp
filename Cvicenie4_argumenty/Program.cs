// See https://aka.ms/new-console-template for more information
using System.Text;

Array.Sort(args);

StringBuilder sb = new StringBuilder();

int counter = 0;
foreach (var argumnets in args)
{
    counter++;
    Console.Write($"{argumnets.Length} ");
    Console.WriteLine(argumnets);
    sb.Append(argumnets);

    
}
Console.WriteLine(sb);
