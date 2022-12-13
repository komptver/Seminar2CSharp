// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
int Threenumber(int num)
{
   int sot = num % 100; 
   int result = sot/10;
  return result;
}

int randNum = new Random().Next(100, 1000);    
int newNum = Threenumber(randNum);               
                                              
Console.WriteLine($"Outputting a thre-digit number {randNum} and show the second digit of this number {newNum}");

*/


// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

/*
Console.WriteLine("Enter the number");
int num = Convert.ToInt32(Console.ReadLine());

int Threenumber(int num)
  {      
            int result = -1;
            if (num >= 100)
            {
                while (num > 999)
                {
                    num = num / 10;
                }
                result = num % 10;
            }
          return result;
  }
if (Threenumber(num) == -1)
Console.WriteLine("no third number");
else
Console.WriteLine($"last digit {Threenumber(num)}");

*/