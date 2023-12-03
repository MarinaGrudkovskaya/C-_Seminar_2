// 14. Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да_
// Console.WriteLine("Введите число: ");
// int number = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
MultiplesNumber(num);
void MultiplesNumber(int number) //ВНИМАНИЕ переменная в скобочках должна фигурировать и в теле функметодаБ тут "number"
  {
    
      if(number%7==0 && number%23==0)
      {
           Console.WriteLine(number + " кратно 7 и 23 одновременно");
       }
       else
       {
          Console.WriteLine("нет, нет и нет не кратно 7 и 23 " + number);
      }
   }

