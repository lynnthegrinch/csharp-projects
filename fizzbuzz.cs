for (int i=1; i<101; i++)
{
    if (i % 3 == 0)
    {
        if (i % 5 == 0) Console.WriteLine(i + " fizzbuzz");
        else Console.WriteLine(i + " fizz");
    }
    else if (i % 5 == 0) Console.WriteLine(i + " buzz");
    else Console.WriteLine(i);
}
