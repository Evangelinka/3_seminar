// Программа, которая принимает на вход число (N) и выдает таблицу квадратов чисел от 1 до N

void Squares(int N)
{
    int i = 1;
    while(i < N)
    {
        Console.Write($"{Math.Pow(i,2)}, ");
        i++;
    }
    Console.Write($"{Math.Pow(i,2)}. ");
}
Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
Squares(number);