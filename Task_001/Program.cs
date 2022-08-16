// Программа, которая принимает на вход координаты точки (X, Y), причем X!=0, Y!=0
// и выдает номер четверти плоскости, в которой находится эта точка.

int FindQuarter(int x, int y)
{
    if (x > 0 && y > 0)
        return 1;
    else if (x < 0 && y > 0)
        return 2;
    else if (x < 0 && y < 0)
        return 3;
    else if (x > 0 && y < 0)
        return 4;
    return 0;
}

Console.WriteLine(FindQuarter(4, 7));
Console.WriteLine(FindQuarter(-4, 7));
Console.WriteLine(FindQuarter(-4, -7));
Console.WriteLine(FindQuarter(4, -7));
Console.WriteLine(FindQuarter(4, 0));

