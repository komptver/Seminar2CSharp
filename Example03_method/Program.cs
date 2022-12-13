// // Задача. Написать программу, которая принимает на вход число и проверяет кратно ли оно одновременно a и b(задаются пользователем)
// будет 3 аргумента (само число вводит пользователь и два числа, которых будет осущ проверка тоже запросить )

Console.WriteLine("Запросить число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Кратно первому: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Кратно второму: ");
int b = Convert.ToInt32(Console.ReadLine());

void Rand (int num, int a, int b)
{
    if(num % a == 0 && num % b ==0)
    {
        Console.WriteLine("Число кратно двум");
    }
    else
        Console.WriteLine("Не кратно");
}
Rand(num,a,b);