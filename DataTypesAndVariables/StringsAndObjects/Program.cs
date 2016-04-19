using System;



class Program
{
    static void Main()
    {
        string hello = "Hello";
        string world = "World";
        object mazalo = hello + " " + world;
        string mazalo1 = Convert.ToString(mazalo);
        Console.WriteLine(mazalo1);
    }
}

