//1-Задание
/*
Console.WriteLine("Введите x");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y");
int b = Convert.ToInt32(Console.ReadLine());
bool ab = true;
for (; ; )
{
    Console.WriteLine("1.Сложение \n2.Вычитание \n3.Умножение" +
    " \n4.Деление \n5.Остаток от деления \n6.Квадрат, если ab=true");
    int op = Convert.ToInt32(Console.ReadLine());
    switch (op)
    {

        case 1:
            Console.WriteLine(a + b);
            break;
        case 2:
            Console.WriteLine(a - b);
            break;
        case 3:
            Console.WriteLine(a * b);
            break;
        case 4:
            Console.WriteLine(a / b);
            break;
        case 5:
            Console.WriteLine(a % b);
            break;
        case 6:
            if (ab == true) {
                int z = a < b ? b : a;
                Console.WriteLine($"{z*z} - Квадрат большего числа");
            }
            break;
        default:
            if (a < b) {
                Console.WriteLine("x - меньшее");
            }
            else
                Console.WriteLine("y - меньшее");
            break;

    }
}
*/
//2-Задание
/*int a, b; 
a = Convert.ToInt32(Console.ReadLine());
b = a;
for ( ; ; ) 
{
    a = Convert.ToInt32(Console.ReadLine());
    b += a;
    if (a == 0)
    {
        Console.WriteLine(b);
        break;
    }
}*/
//3-Задание
//int[] mas = new int[4];
//Console.WriteLine("Введите 4 числа");
//for (int i = 0; i < 4; i++) 
//{ 
//    mas[i] = Convert.ToInt32(Console.ReadLine());
//}
//for (int i = 0; i < 4; i++)
//{
//    for (int j = i + 1; j < 4; j++)
//    {
//        if (mas[i] > mas[j])
//        {
//            int a = mas[i];
//            mas[i] = mas[j];
//            mas[j] = a;
//        }
//    }
//}
//for (int i = 0; i < 4; i++) 
//{
//    Console.WriteLine(mas[i]);
//}

//int sum = Convert.ToInt32(Console.ReadLine());
//int n = 0, l = 3;
//while (n!=l) 
//{ 
//    if (mas[n] + mas[l] == sum)
//    {
//        Console.WriteLine("Успех");
//        Console.WriteLine($"Первый элемент: {mas[n]}");
//        Console.WriteLine($"Второй элемент: {mas[l]}");
//        break;
//    }
//    else if (mas[n] + mas[l] > sum)
//    {
//        l--;
//    }
//    else if (mas[n] + mas[l] < sum)
//    {
//        n++;
//    }
//}
//4-Задание
int[][] mas = new int[10][];
Random rnd = new Random();
for (int i = 0; i < 10; i++)
{
    mas[i] = new int[i + 1];
}
for (int i = 0; i < mas.Length; i++)
{
    for (int j = 0; j < mas[i].Length; j++)
    {
        mas[i][j] = rnd.Next(1, 9);
        Console.Write($"{mas[i][j]} \t");
    }
    Console.WriteLine();
}

for (int i = 0; i < mas.Length; i++)
{
    if (i == 0 || i % 2 == 0)
    {
        for (int k = 0; k < mas[i].Length; k++)
        {
            for (int m = k + 1; m < mas[i].Length; m++)
            {
                if (mas[i][k] > mas[i][m])
                {
                    int a = mas[i][k];
                    mas[i][k] = mas[i][m];
                    mas[i][m] = a;
                }
            }
        }
    }
    else
    {
        for (int k = 0; k < mas[i].Length; k++)
        {
            for (int m = k + 1; m < mas[i].Length; m++)
            {
                if (mas[i][k] < mas[i][m])
                {
                    int a = mas[i][m];
                    mas[i][m] = mas[i][k];
                    mas[i][k] = a;
                }
            }
        }
    }
}
Console.WriteLine("**********************************************");
for (int i = 0; i < mas.Length; i++)
{
    for (int j = 0; j < mas[i].Length; j++)
    {
        Console.Write($"{mas[i][j]} \t");
    }
    Console.WriteLine();
}