using System.Globalization;

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
            Console.WriteLine("4 - Ломаная.");
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
                
                case 4:
                    Console.WriteLine("\nЛоманая:");
                    Point polygonalOne = new Point(1, 5);
                    Point polygonalTwo = new Point(2, 8);
                    Point polygonalThree = new Point(5, 3);
                    Point[] arrayOne = new Point[] { polygonalOne, polygonalTwo, polygonalThree };
                    Polygonal lineOne = new Polygonal(arrayOne);
                    Point polygonalMiddle = new Point(2, -5);
                    Point polygonalTwoMiddle = new Point(4, -8);
                    Point[] arrayTwo = new Point[] { polygonalOne, polygonalMiddle, polygonalTwoMiddle,  polygonalThree };
                    Polygonal lineTwo = new Polygonal(arrayTwo);
                    Console.WriteLine($"Первая ломаная: {lineOne}");
                    Console.WriteLine($"Вторая ломаная: {lineTwo}");
                    polygonalOne.CoordinateX = -2;
                    polygonalOne.CoordinateY = 0;
                    Console.WriteLine($"Первая ломаная после сдвига: {lineOne}");
                    Console.WriteLine($"Вторая ломаная после сдвига: {lineTwo}");
                    break;
                
                default:
                    Console.WriteLine("\nТакого пункта в меню нет. Попробуйте еще раз.");
                    break;
            }
        }
    }
}
