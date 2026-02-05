//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Введите первое число: ");
//        int num1 = Convert.ToInt32(Console.ReadLine());
//        Console.Write("Введите второе число: ");
//        int num2 = Convert.ToInt32(Console.ReadLine());
//        Console.WriteLine("Сумма: " + (num1 + num2));
//    }
//}

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Введите число: ");
//        int num = Convert.ToInt32(Console.ReadLine());
//        Console.WriteLine(num % 2 == 0 ? "Четное" : "Нечетное");
//    }
//}

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Введите число: ");
//        int num = Convert.ToInt32(Console.ReadLine());
//        for (int i = 1; i <= 10; i++)
//        {
//            Console.WriteLine($"{num} x {i} = {num * i}");
//        }
//    }
//}

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Введите число: ");
//        int num = Convert.ToInt32(Console.ReadLine());
//        int factorial = 1;

//        for (int i = 1; i <= num; i++)
//        {
//            factorial *= i;
//        }
//        Console.WriteLine($"Факториал {num} = {factorial}");
//    }
//}

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Введите строку: ");
//        string input = Console.ReadLine();
//        char[] charArray = input.ToCharArray();
//        Array.Reverse(charArray);
//        Console.WriteLine("Обратная строка: " + new string(charArray));
//    }
//}

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Введите строку: ");
//        string input = Console.ReadLine();
//        char[] charArray = input.ToCharArray();
//        Array.Reverse(charArray);
//        Console.WriteLine("Обратная строка: " + new string(charArray));
//    }
//}

//using System;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Введите строку: ");
//        string input = Console.ReadLine();
//        int count = 0;

//        foreach (char c in input.ToLower())
//        {
//            if ("aeiou".Contains(c))
//            {
//                count++;
//            }
//        }
//        Console.WriteLine($"Количество гласных: {count}");
//    }
//}

//using System;

//class Program
//{
//    static void Main()
//    {
//        Random random = new Random();
//        int[] array = new int[10];

//        for (int i = 0; i < array.Length; i++)
//        {
//            array[i] = random.Next(1, 101); // от 1 до 100
//        }

//        Console.WriteLine("Сгенерированный массив: " + string.Join(", ", array));
//    }
//}



