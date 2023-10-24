// 1-100 arası asal sayılar


for (int i = 1; i <= 100; i++)
{
    int result = 0;
    for (int j = 2; j < i; j++)
    {
        if (i % j == 0)
        {
            result = 1;
            break;
        }
    }
    if (result == 0)
    {
        Console.WriteLine(i);
    }
}