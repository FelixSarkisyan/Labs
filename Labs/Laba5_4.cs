using System.Globalization;

namespace Labs;

internal class Laba5_4
{
    public static void Run()
    {
        string[] input = ReadNumbers();
        int[] output = ProcessNumbers(input);
        foreach (string current in input)
        {
            Console.Write(current + " ");
        }
        Console.WriteLine();
        foreach (int current in output)
        {
            Console.Write($"{current} ");
        }
    }
    public static string[] ReadNumbers()
    {
        Console.WriteLine("Введите размер массива");
        int size = int.Parse(Console.ReadLine()!);
        string[] numbers = new string[size];
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine("Введите число");
            numbers[i] = Console.ReadLine()!;

        }
        return numbers;
    }
    public static int[] ProcessNumbers(string[] numbers)
    {
        List<int> result = new List<int>();
        for (int i = 0; i < numbers.Length; i++)
        {
            string current = numbers[i].TrimEnd('\n');
            if (int.TryParse(current, out int @int))
            {
                if (@int > 0)
                {
                    int factorial = Factorial(@int);
                    result.Add(factorial);

                }
                else
                {
                    result.Add(@int);
                }
                continue;
            }
            if (double.TryParse(current, NumberStyles.Float, CultureInfo.InvariantCulture, out double @double))
            {
                int processed = ProcessDouble(@double);
                result.Add(processed);


            }

        }
        return result.ToArray();
    }

    public static int Factorial(int number)
    {
        int result = 1;
        for (int i = 1; i <= number; i++)
        {
            result = result * i;
        }
        return result;
    }
    public static int ProcessDouble(double number)
    {

        double result = Math.Round(number, 2);
        result = result % 1;
        result = result * 100;
        return (int)result;
    }

}

/*



*/