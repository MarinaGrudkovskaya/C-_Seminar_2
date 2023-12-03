// Задача 10: Напишите программу, которая принимает на
// вход трёхзначное число и на выходе показывает вторую
// цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int number = GetNumber();
SecondNumber(number);
int GetNumber() //если выдает ошибку :  Имя Console не существует в текущем контексте,
                   // следует периписать слово, вззможно был не тот алфавит нак С!
 {
   Console.WriteLine("Введите число: ");
   int number = int.Parse(Console.ReadLine()!);
   return number;
 }
void SecondNumber(int number)
   {
     int number1 = number%100;
     int number2 = number%10;
     Console.WriteLine((number1-number2)/10);
   }


