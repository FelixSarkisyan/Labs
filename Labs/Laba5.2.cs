namespace Labs;

internal class Laba5_2
{
    public static void Run()
    {
        Console.WriteLine("Введите ваше число");
        string input = Console.ReadLine()!;
        if (IsNumber(input))
        {
            Console.WriteLine(SumDigits(input));
        }
        else
        {
            Console.WriteLine("Введите именно число");
        }






    }
    public static bool IsNumber(string input)
    {
        for (int i = 0; i < input.Length; i++)
        {
            char current = input[i];
            if (char.IsDigit(current) is false &&
                i != 0 && current != '-')
                return false;
        }
        return true;
    }
    public static int SumDigits(string input)
    {
        int sum = 0;
        foreach (char current in input)
        {
            if (char.IsDigit(current))
            {



                sum = sum + current - '0';
            }


        }
        return sum;

    }
}

/*
Пользователь вводит целочисленное число (оно может быть как положительным, так и отрицательным). 
Нужно проверить, что число корректно без использования любого стороннего преобразования строки в число, 
т.е. нельзя использовать int.Parse(), int.TryParse(), Convert.ToInt() и т.д.. 
Если нет, то вывести сообщение и завершить программу. 
Если корретно, то опять же без вызова сторонних методов и без конвертирования строки в число
найти сумму цифр введенного числа.
*/