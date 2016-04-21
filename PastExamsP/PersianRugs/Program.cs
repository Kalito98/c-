using System;

class Program
{
    static void Main()
    {
        int sizeBig =  int.Parse(Console.ReadLine());
        int sizeSmall = int.Parse(Console.ReadLine());
        int workSpace = sizeBig * 2 + 1;
        int mid = sizeBig + 1;
        char sideLeft = '/';
        char sideRight = '\\';
        char colorBig = '#';
        char colorSmall = '.';
        char space = ' ';

        for (int row = 0; row < workSpace; row++)
        {
            for (int col = 0; col < workSpace; col++)
            {
                if (
                    col == sizeBig && row == sizeBig
                    )
                {
                    Console.Write('X');
                }
                else if 
                    (
                    col - row == 0 ||
                    col - row == sizeSmall + 1 && row < 2 ||
                    col - row == sizeSmall - sizeBig && row > workSpace - 3
                    )
                {
                    Console.Write(sideRight);
                }
                else if
                    (
                    col + row == workSpace - 1 || 
                    col + row == workSpace - 1 - sizeSmall - 1 && row < 2 ||
                    col + row == workSpace + sizeSmall && row > workSpace - 3
                    )
                {
                    Console.Write(sideLeft);
                }
                else if 
                    (
                    col > sizeBig && col < sizeBig ||
                    col - row <= 0 && col + row <= workSpace - 1 ||
                    col - row >= 0 && col + row >= workSpace - 1
                    )
                {
                    Console.Write(colorBig);
                }
               else if 
                   (
                   row == 0 && col > row + sizeSmall && col < row + sizeSmall + sizeBig ||
                   row == 1 && col == sizeBig ||
                   row == workSpace - 1 && col > row - sizeBig - sizeSmall && col < row - sizeSmall ||
                   row == workSpace - 2 && col == sizeBig
                   )
               {
                   Console.Write(colorSmall);
               }
                else
                {
                    Console.Write(space);
                }
            }
            Console.WriteLine();
        }
        Console.WriteLine();
           
    }
}

