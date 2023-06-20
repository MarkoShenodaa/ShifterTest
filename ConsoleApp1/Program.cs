using Encryption.CaesarCipher;

namespace ConsoleApp1;

public class Program
{
    public static void Main(string[] args)
    {
        var shefter = new Shefter();

        Console.Write("Input: ");
        
        Console.WriteLine("Output: " + shefter.SheftedValue(Console.ReadLine()));
    }
}