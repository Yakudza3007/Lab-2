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
    
    public int NaturalReadInt(string promt)
    {
        Console.WriteLine(promt);
        string? input = Console.ReadLine();
        int result = 0;
        while (true)
        {
            if (int.TryParse(input, out result) && result > 0)
            {
                return result;
            }
            else
            {
                Console.WriteLine("Ошибка ввода! Повторите: ");
                input = Console.ReadLine();
            }
        }
    }
    // проверка на double
    // проверка на bool
    // проверка на string
}