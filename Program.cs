class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите элементы массива через пробел: ");
        string input = Console.ReadLine();
        string[] initialArray = input.Split(' ');

        int count = 0;
        for (int i = 0; i < initialArray.Length; i++)
        {
            if (initialArray[i].Length <= 3) count++;
        }

        string[] resultArray = new string[count];

        int index = 0;
        for (int i = 0; i < initialArray.Length; i++)
        {
            if (initialArray[i].Length <= 3)
            {
                resultArray[index] = initialArray[i];
                index++;
            }
        }

        Console.WriteLine("Результат: ");
        Console.WriteLine(string.Join(", ", resultArray));
    }
}