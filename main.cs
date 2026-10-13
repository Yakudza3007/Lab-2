namespace ConsoleApp1;

internal class Program
{
    private static void Main(string[] args)
    {
        Checked c = new Checked();

        while (true)
        {
            Console.WriteLine("\n0 - Выход из программы.");
            Console.WriteLine("1 - Имена.");
            Console.WriteLine("2 - Люди с именами.");
            Console.WriteLine("3 - Люди с родителем.");
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
                
                case 2:
                    Console.WriteLine("\nЛюди с именем:");
                    Name personOne = new Name("Клеопатра");
                    People personOneFull = new People(personOne, 152);
                    Name personTwo = new Name("Пушкин", "Александр", "Сергеевич");
                    People personTwoFull = new People(personTwo, 167);
                    Name personThree = new Name("Маяковский", "Владимир");
                    People personThreeFull = new People(personThree, 189);
                    Console.WriteLine(personOneFull);
                    Console.WriteLine(personTwoFull);
                    Console.WriteLine(personThreeFull);
                    break;
                
                case 3:
                    Console.WriteLine("\nЛюди с родителем:");
                    Name parentOne = new Name("Чудов", "Иван");
                    Name parentTwo = new Name("Чудов", "Петр");
                    Name parentThree = new Name("Борис");
                    People parentOneFull = new People(parentOne, 181);
                    People parentTwoFull = new People(parentTwo, 182, parentOneFull);
                    People parentThreeFull = new People(parentThree, 183, parentTwoFull);
                    Console.WriteLine(parentOneFull);
                    Console.WriteLine(parentTwoFull);
                    Console.WriteLine(parentThreeFull);
                    break;
                
                default:
                    Console.WriteLine("\nТакого пункта в меню нет. Попробуйте еще раз.");
                    break;
            }
        }
    }
}
