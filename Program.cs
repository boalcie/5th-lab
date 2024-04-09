void first_var() // Варіант 2 Перше Завдання
{
    int a = 9;
    int b = 9;
    if (a > b)
    {
        Console.WriteLine("a більше ніж b");
    }
    if (b > a)
    {
        Console.WriteLine("b більше ніж a");
    }
    if (a == b)
    {
        Console.WriteLine("Числа однакові");
    }
}

void second_var() // Варіант 2 Друге Завдання
{
    int a = 4;
    int c = 1;
    for(int i = 2;i <= a; i++)
    {
        c *= i;
    }
    Console.WriteLine(c);
    
}

second_var();