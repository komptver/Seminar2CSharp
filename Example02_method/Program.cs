// Задача. Написать программу, которая случайного числа из отрезка от 10 до 99 включительно показывает наибольшую цифру в этом числе
// будет 1 аргумент int берем и int и возвращаем

int CutNumber(int num)
{
  int ed = num % 10; 
  int des = num / 10;
  int max = ed;
  if (max < des) max = des;

    return max;
}
  int randNum = new Random().Next(10, 100);
  int newNum = CutNumber(randNum);
  Console.WriteLine($"Из числа {randNum} большая цифра {newNum}");
  



