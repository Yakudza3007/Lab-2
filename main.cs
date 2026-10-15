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
            Console.WriteLine("5 - Ломаная без параметров.");
            Console.WriteLine("6 - Ломаная: добавление точек и длина.");

            int choice = ReadIntInRange(c, "Введите номер задания: ", 0, 6);

            switch (choice)
            {
                case 0:
                    Console.WriteLine("\nРабота завершена.");
                    return;
                case 1: Task1(c); break;
                case 2: Task2(c); break;
                case 3: Task3(c); break;
                case 4: Task4(c); break;
                case 5: Task5(c); break;
                case 6: Task6(c); break;
            }
        }
    }

    private static int ReadIntInRange(Checked c, string prompt, int min, int max)
    {
        while (true)
        {
            int value = c.ReadInt(prompt);
            if (value >= min && value <= max)
            {
                return value;
            }

            Console.WriteLine($"Ошибка: число должно быть от {min} до {max}. Повторите ввод.");
        }
    }

    private static int ReadPositiveInt(Checked c, string prompt)
    {
        return ReadIntInRange(c, prompt, 1, int.MaxValue);
    }

    private static int ReadNonNegativeInt(Checked c, string prompt)
    {
        return ReadIntInRange(c, prompt, 0, int.MaxValue);
    }

    private static string? ReadOptionalString(string prompt)
    {
        Console.Write(prompt);
        string? input = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(input))
        {
            return null;
        }

        return input.Trim();
    }

    private static string ReadRequiredString(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            string? input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input))
            {
                return input.Trim();
            }

            Console.WriteLine("Ошибка: поле не может быть пустым. Повторите ввод.");
        }
    }

    private static Name ReadName()
    {
        string? surname = ReadOptionalString("Фамилия (Enter — пропустить): ");
        string firstName = ReadRequiredString("Имя: ");
        string? patronymic = ReadOptionalString("Отчество (Enter — пропустить): ");

        if (patronymic != null)
        {
            return new Name(surname ?? "", firstName, patronymic);
        }

        if (surname != null)
        {
            return new Name(surname, firstName);
        }

        return new Name(firstName);
    }

    private static Point ReadPoint(Checked c, string label)
    {
        Console.WriteLine($"Точка {label}:");
        int x = c.ReadInt("  X = ");
        int y = c.ReadInt("  Y = ");
        return new Point(x, y);
    }

    private static void Task1(Checked c)
    {
        Console.WriteLine("\n=== Задание 1: Имена ===");
        int count = ReadPositiveInt(c, "Сколько имён создать? ");
        Name[] names = new Name[count];

        for (int i = 0; i < count; i++)
        {
            Console.WriteLine($"\nИмя #{i + 1}:");
            names[i] = ReadName();
        }

        Console.WriteLine("\nСозданные имена:");
        foreach (Name n in names)
            Console.WriteLine(n);
    }

    private static void Task2(Checked c)
    {
        Console.WriteLine("\n=== Задание 2: Люди с именем ===");
        int count = ReadPositiveInt(c, "Сколько людей создать? ");
        People[] people = new People[count];

        for (int i = 0; i < count; i++)
        {
            Console.WriteLine($"\nЧеловек #{i + 1}:");
            Name name = ReadName();
            int height = ReadPositiveInt(c, "Рост (см): ");
            people[i] = new People(name, height);
        }

        Console.WriteLine("\nСозданные люди:");
        foreach (People p in people)
            Console.WriteLine(p);
    }

    private static void Task3(Checked c)
    {
        Console.WriteLine("\n=== Задание 3: Люди с родителем ===");
        int count = ReadPositiveInt(c, "Сколько поколений ввести? ");
        People[] chain = new People[count];
        People? previous = null;

        for (int i = 0; i < count; i++)
        {
            if (previous == null)
            {
                Console.WriteLine($"\nПоколение #{i + 1} (без отца):");
            }
            else
            {
                Console.WriteLine($"\nПоколение #{i + 1} (отец — {previous.Name}):");
            }

            Name name = ReadName();
            int height = ReadPositiveInt(c, "Рост (см): ");

            if (previous == null)
            {
                chain[i] = new People(name, height);
            }
            else
            {
                chain[i] = new People(name, height, previous);
            }

            previous = chain[i];
        }

        Console.WriteLine("\nСозданная цепочка:");
        foreach (People p in chain)
            Console.WriteLine(p);
    }

    private static void Task4(Checked c)
    {
        Console.WriteLine("\n=== Задание 4: Ломаная ===");

        Console.WriteLine("\nПервая ломаная:");
        Point start = ReadPoint(c, "начала");
        Point mid = ReadPoint(c, "середины первой ломаной");
        Point end = ReadPoint(c, "конца");

        Polygonal lineOne = new Polygonal(new Point[] { start, mid, end });

        Console.WriteLine("\nВторая ломаная (начало и конец — общие с первой):");
        int extraCount = ReadNonNegativeInt(c, "Сколько серединных точек? ");
        Point[] arrayTwo = new Point[extraCount + 2];
        arrayTwo[0] = start;
        for (int i = 0; i < extraCount; i++)
            arrayTwo[i + 1] = ReadPoint(c, $"середины #{i + 1}");
        arrayTwo[extraCount + 1] = end;

        Polygonal lineTwo = new Polygonal(arrayTwo);

        Console.WriteLine("\nДо сдвига:");
        Console.WriteLine($"Первая ломаная: {lineOne}");
        Console.WriteLine($"Вторая ломаная: {lineTwo}");

        Console.WriteLine("\nСдвигаем начало первой ломаной.");
        start.CoordinateX = c.ReadInt("Новый X начала: ");
        start.CoordinateY = c.ReadInt("Новый Y начала: ");

        Console.WriteLine("\nПосле сдвига:");
        Console.WriteLine($"Первая ломаная: {lineOne}");
        Console.WriteLine($"Вторая ломаная: {lineTwo}");
    }

    private static void Task5(Checked c)
    {
        Console.WriteLine("\n=== Задание 5: Ломаная без параметров ===");
        Polygonal empty = new Polygonal();
        Console.WriteLine($"Пустая ломаная: {empty}");

        Console.WriteLine("\nСоздадим ломаную с точками.");
        int count = ReadPositiveInt(c, "Сколько точек? ");
        Point[] points = new Point[count];
        for (int i = 0; i < count; i++)
            points[i] = ReadPoint(c, $"#{i + 1}");

        Polygonal line = new Polygonal(points);
        Console.WriteLine($"Ломаная: {line}");
    }

    private static void Task6(Checked c)
    {
        Console.WriteLine("\n=== Задание 6: Добавление точек и длина ===");
        int count = ReadPositiveInt(c, "Сколько точек у ломаной изначально? ");
        Point[] points = new Point[count];
        for (int i = 0; i < count; i++)
            points[i] = ReadPoint(c, $"#{i + 1}");

        Polygonal line = new Polygonal(points);
        Console.WriteLine($"\nЛоманая: {line}");
        Console.WriteLine($"Длина: {line.Length():F2}");

        int addCount = ReadPositiveInt(c, "\nСколько точек добавить? ");
        Point[] newPoints = new Point[addCount];
        for (int i = 0; i < addCount; i++)
            newPoints[i] = ReadPoint(c, $"новая #{i + 1}");

        line.Add(newPoints);
        Console.WriteLine($"\nЛоманая: {line}");
        Console.WriteLine($"Длина после добавления: {line.Length():F2}");
    }
}