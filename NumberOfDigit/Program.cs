int GetNumberOfDigit(int number)
{
    int numberOfDigits = 0;
    while (number > 0)
    {
        number /= 10;
        numberOfDigits++;
        Console.WriteLine(number);
    }
    return numberOfDigits;
}

while(true)
{
    Console.WriteLine("Введите число");
    int number = Convert.ToInt32(Console.ReadLine());
    int numberOfDigits = GetNumberOfDigit(number);
    Console.WriteLine($"количество цифр {numberOfDigits}");
}
