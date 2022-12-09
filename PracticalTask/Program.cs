// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int Threenumber(int num)
{
   int sot = num % 100; 
   int dec = num / 10; 
      
  int result = (num % 100)/10;
  return result;
}

int randNum = new Random().Next(100, 1000);    
int newNum = Threenumber(randNum);               
                                              
Console.WriteLine($"Outputting a thre-digit number {randNum} and show the second digit of this number {newNum}");



// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*
int NotThree(int num)
{


}
*/