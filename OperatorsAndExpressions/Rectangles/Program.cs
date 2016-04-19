using System;



class Program
{
    static void Main()
    {
        double width = double.Parse(Console.ReadLine());
        double hight = double.Parse(Console.ReadLine());
        double area = width * hight;
        double perimeter = (width * 2) + (hight * 2);
        Console.Write("{0:F2} ", area);
        Console.WriteLine("{0:F2}", perimeter);
    }
}

