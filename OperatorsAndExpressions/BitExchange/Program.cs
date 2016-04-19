using System;


class Program
{
    static void Main()
    {
        long number1 = 0;
        long number = int.Parse(Console.ReadLine());

        long mask3 = 1 << 3;
        long nAndMask3 = number & mask3;
        long bit3 = nAndMask3 >> 3;

        long mask4 = 1 << 4;
        long nAndMask4 = number & mask4;
        long bit4 = nAndMask3 >> 4;

        long mask5 = 1 << 5;
        long nAndMask5 = number & mask5;
        long bit5 = nAndMask3 >> 5;



        if (bit3 == 1)
        {
            int mask24 = ~(1 << 24);
            number = mask24 & number;
        }
        else
        {
            int mask24 = (1 << 24);
            number = mask24 | number;
        }
        Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
        if (bit4 == 1)
        {
            int mask25 = ~(1 << 25);
            number = mask25 & number;
        }
        else
        {
            int mask25 = (1 << 25);
            number = mask25 | number;
        }

        if (bit5 == 1)
        {
            int mask26 = ~(1 << 26);
            number = mask26 & number;
        }
        else
        {
            int mask26 = (1 << 26);
            number = mask26 | number;
        }
        Console.WriteLine(number);
        Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
    }

}
