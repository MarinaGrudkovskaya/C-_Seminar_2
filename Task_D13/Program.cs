// Задача 13: Напишите программу, которая выводит
// третью цифру заданного числа или сообщает, что третьей
// цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int GetNumber()
  {
    Console.WriteLine("Введите Число: ");
    int number = int.Parse(Console.ReadLine()!);
    return number;
  }

void GetThreeNumber(int number)

 {
 if (number < 100)
 {
    Console.WriteLine(number + " -> третьей цифры нет ");
 }
 else
 {
    Console.Write(number);
    while (number>= 1000)
    { 
        number = number/10;
    }
   int num = number%10;
   Console.WriteLine(" -> " + num);
 }
 }
int number = GetNumber();
GetThreeNumber(number);