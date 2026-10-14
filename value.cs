using System.ComponentModel.Design;

namespace ConsoleApp1;

internal class Checked
{
    public int ReadInt(string promt)
    {
        Console.Write(promt);
        string? input = Console.ReadLine();
        int result = 0;
        while (true)
        {
            if (int.TryParse(input, out result))
            {
                return result;
            }
            else
            {
                Console.Write("\nОшибка ввода! Повторите: ");
                input = Console.ReadLine();
            }
        }
    }
}
