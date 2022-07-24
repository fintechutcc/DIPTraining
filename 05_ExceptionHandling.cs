using System;
using static System.Console;

WriteLine("Without checked statement:");
int x = int.MaxValue - 1;
WriteLine($"Initial value: {x}");
x++;
WriteLine($"After incrementing: {x}");
x++;
WriteLine($"After incrementing: {x}");
x++;
WriteLine($"After incrementing: {x}");

checked
{
    try
    {
        WriteLine("\n\nWith checked statement:");
        x = int.MaxValue - 1;
        WriteLine($"Initial value: {x}");
        x++;
        WriteLine($"After incrementing: {x}");
        x++;
        WriteLine($"After incrementing: {x}");
        x++;
        WriteLine($"After incrementing: {x}");
    }
    catch (OverflowException)
    {
        WriteLine("The code overflowed but we can catch the exception.");
    }
}
