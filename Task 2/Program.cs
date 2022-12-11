// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. 
// Реализовать через функции.

int Input(string message)
{
    System.Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int number = Input("Введите число: ");


int Sum(int number)
{
    int result = 0;
    result += number % 10;
    number /= 10;
    if (number > 0)
    {
        result += Sum(number);
    }
    return result;
}
System.Console.WriteLine($"{Sum(number)}");