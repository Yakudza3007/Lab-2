namespace ConsoleApp1;

internal class Program
{
    private static void Main(string[] args)
    {
        Checked c = new Checked();

        while (true)
        {
            Console.WriteLine("\n0 - Выход из программы");
            Console.WriteLine("1 - Имена");
            int choice = c.ReadInt("Введите номер задания: ");
            switch (choice)
            {
                case 0:
                    Console.WriteLine("\nРабота завершена.");
                    return;
                    
                case 1:
                    Console.WriteLine("\nИмена:");
                    Name peopleOne = new Name("Клеопатра");
                    Name peopleTwo = new Name("Пушкин", "Александр", "Сергеевич");
                    Name peopleThree = new Name("Маяковский", "Владимир");
                    Console.WriteLine(peopleOne);
                    Console.WriteLine(peopleTwo);
                    Console.WriteLine(peopleThree);
                    break;
            }
        }
    }
}