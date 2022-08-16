// Программа, которая принимает на вход координаты точки (X, Y), причем X!=0, Y!=0
// и выдает номер четверти плоскости, в которой находится эта точка.

void FindRange(int number)
{
    if (number == 1)
        Console.WriteLine("x > 0, y > 0");
    else if (number == 2)
        Console.WriteLine("x < 0, y > 0");
    else if (number == 3)
        Console.WriteLine("x < 0, y < 0");
    else if (number == 4)
        Console.WriteLine("x > 0, y < 0");
    else
        Console.WriteLine("Номер четверти указан неверно");
}

FindRange(1);
FindRange(2);
FindRange(3);
FindRange(4);
FindRange(0);