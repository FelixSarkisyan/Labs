using System.Globalization;

namespace Labs;

internal class Laba5_1
{
    public static void Run()
    {
        /*
         Пользователь вводит число. Если это целочисленное число (int.TryParse(...)), то вывести 
        на экран символ соответствующий этому числу. Если это число с плавающей запятой,
        то сравнить это число с предыдущим введенным (float.NaN). Если эти числа равны, 
        прекратить ввод, иначе повторить ввод. Также выполнение программы прекращается,
        если ввести символ q.
         */
        float last = float.NaN;
        while (true)
        {
            Console.WriteLine("Введите ваше число");
            string input = Console.ReadLine()!;

            if (int.TryParse(input, out int @int))
            {
                Console.WriteLine((char)@int);
                continue;


            }
            if (float.TryParse(input, NumberStyles.Number, CultureInfo.InvariantCulture, out float @float))
            {
                if (@float == last) break;
                last = @float;
                continue;

            }
            if (input == "q") break;
        }


    }
}
