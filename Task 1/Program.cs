// Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B. Реализовать через функции.

int Input(string message)
{
    System.Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int numberA = Input("Введите значение А: ");
int numberB = Input("Введите значение B: ");
ToDegree(numberA, numberB);

void ToDegree(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    Console.WriteLine(result);
}




