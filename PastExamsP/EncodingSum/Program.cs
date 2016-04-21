using System;

class Program
{
    static void Main()
    {
        int module = int.Parse(Console.ReadLine());
        string text = Console.ReadLine();
        int result = 0;
        text = text.ToLower();
        for (int i = 0; i < text.Length; i++)
        {
            char ch = text[i];
            if (ch == '@')
            {
                break;
            }
            else if (ch >= '0' && ch <= '9')
            {
                result *= ch - '0';
            }
            else if (ch >= 'a' && ch <= 'z')
            {
                result += ch - 'a';
            }
            else
            {
                result %= module;
            }

        }
        Console.WriteLine(result);
    }
}

