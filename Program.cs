//----------------Используемые методы----------------

int PosIntNumber()     //ввод целочисленного значения
{
    int n = Math.Abs(Convert.ToInt32(Console.ReadLine()));
    return n;
}

//----------------Решаемые задачи--------------------
// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int AllNumsN1(int num)
{
    if (num == 1)
    {
        Console.Write($"{num}");
        return num;
    }
    if (num > 0)
    {
        Console.Write($"{num}, ");
        AllNumsN1(num - 1);
    }
    return num;
}

void task1()
{
    Console.Clear();
    Console.WriteLine("Задача 64: Задайте значение N. Напишите программу, которая");
    Console.WriteLine("выведет все натуральные числа в промежутке от N до 1.");
    Console.WriteLine("Введите значение N: ");
    int n = PosIntNumber();

    AllNumsN1(n);
    Console.ReadKey();
}

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
int SumFromMtoN(int num1, int num2)      //сумма элементов от M до N
{
    int sum = 0;
    if (num1 == num2)
    {
        Console.WriteLine($"Сумма элементов в промежутке равна {num1}");
        return num1;
    }

    if (num1 < num2)
    {
        while (num1 <= num2 - 1)
        {
            Console.Write($"{num1}, ");
            sum = sum + num1;
            num1++;
        }
        if (num1 == num2)
        {
            Console.WriteLine($"{num1}");
            sum = sum + num1;
        }
    }

    if (num2 < num1)
    {
        while (num2 <= num1 - 1)
        {
            Console.Write($"{num2}, ");
            num2++;
            sum = sum + num2;
        }
        if (num2 == num1)
        {
            Console.WriteLine($"{num2}");
            sum = sum + num2;
        }
    }
    return sum;
}

void task2()
{
    Console.Clear();
    Console.WriteLine("Задача 66: Задайте значения M и N. Напишите программу, которая найдёт");
    Console.WriteLine("сумму натуральных элементов в промежутке от M до N.");
    Console.Write("Введите M: ");
    int m = PosIntNumber();
    Console.Write("Введите N: ");
    int n = PosIntNumber();
    int sum = SumFromMtoN(m, n);
    Console.WriteLine($"Сумма элементов равна {sum}");
    Console.ReadKey();
}

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
int Akker(int num1, int num2)
{
    if (num1 == 0)
        return num2 + 1;
    else
      if ((num1 != 0) && (num2 == 0))
        return Akker(num1 - 1, 1);
    else
        return Akker(num1 - 1, Akker(num1, num2 - 1));
}

void task3()
{
    Console.Clear();
    Console.WriteLine("Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.");
    Console.WriteLine("Даны два неотрицательных числа m и n.");
    Console.Write("Введите M: ");
    int m = PosIntNumber();
    Console.Write("Введите N: ");
    int n = PosIntNumber();
    int result = Akker(m, n);
    Console.WriteLine($"A({m},{n}) = {result}");
    Console.ReadKey();
}

//----------------Выполнение программы----------------
void Main()
{
    Console.Clear();
    Console.WriteLine("**************************************** \n Выберите задачу, которую хотите решить:\n\t1 - Задача 64 \n\t2 - Задача 66 \n\t3 - Задача 68 \n\t4 - Выход");
    int num = Convert.ToInt32(Console.ReadLine());
    switch (num)
    {
        case 1:
            task1();
            Main();
            break;
        case 2:
            task2();
            Main();
            break;
        case 3:
            task3();
            Main();
            break;
        case 4:
            Console.WriteLine("Пока!");
            Console.ReadKey();
            break;
    }
}
Main();