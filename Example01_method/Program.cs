// Задача. Написать программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

  int CutNumber(int num)    //название метода(заголовок)
{
  int ed = num % 10;  // описание реализации метода, перечень аргументов
  int sot = num / 100;

  int result = sot * 10 + ed;
  return result;
}

int randNum = new Random().Next(100, 1000);    // 100 самое маленькое 3-х значное число, new - определяет создание нового объекта.
int newNum = CutNumber(randNum);               // Random - создаем объект класса и вызываем метод Next. В математике есть такая запись
                                               // [100,1000) - идем от числа 100 до 1000, но 1000 не считаем. 
Console.WriteLine($"Выводим первое и третие числа {randNum} is {newNum}");
