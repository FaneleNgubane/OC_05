using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
    public static void Main(string[] args)
    {
        char character;
        Console.Write("Enter an alphabet: ");
        character = Char.Parse(Console.ReadLine());

        if ((character >= 'A' && character <= 'Z') || character >= 'a' && character <= 'z')
        {
            if (character == 'a' || character == 'A' || character == 'e' || character == 'E' || character == 'i'
                || character == 'I' || character == 'o' || character == 'O' || character == 'u' || character == 'U')
            {
                Console.WriteLine(character + " is a vowel");
                Main(null);
            }
            else
            {
                Console.WriteLine(character + " is a consonant");
                Main(null);
            }
        }
        else
        {
            Console.WriteLine(character + " is not an alphabet");
            Main(null);
        }

    }
}