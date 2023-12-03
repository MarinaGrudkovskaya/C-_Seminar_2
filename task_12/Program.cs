// 12. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли второе число
// кратным первому. Если число 2 не кратно числу 1, то
// программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

// Console.Write("Введите числа: ");
// int number1 = int.Parse(Console.ReadLine()!);
// int number2 = int.Parse(Console.ReadLine()!);
// int number = number1%number2;

// if (number == 0)
// {
//     Console.WriteLine(number1 +" -> кратно " + number2);
// }
// else
// {
//     Console.WriteLine(number1 +" -> не кратно " + number2 + " остаток "+ number);
// }

int GetNumber()  // 1) метод работы с пользователем !! ВНИМАНИЕ тут пустые скобки, нет аргумента у метода
{
   Console.Write("Введите число: "); 
   int num = int.Parse(Console.ReadLine()!);
   return num;
}
void PrintNumber(int number) // 2) метод печатает числа, он здесь не нужен, просто для проверки
{
    Console.WriteLine(number);
}

void MultiplesNumber(int num1, int num2)  // 3) метод для нахождения кратности, void-вый
{
 int number = num1%num2; // эта важная строка, здесь мы находим остаток
if (number == 0)
{
    Console.WriteLine(num1 +" -> кратно " + num2);
}
else
{
    Console.WriteLine(num1 +" -> не кратно " + num2 + " остаток "+ number);
}
}

int number1 = GetNumber();  //вызываем метод 1
int number2 = GetNumber();
PrintNumber(number1);  //вызываю метод 2
PrintNumber(number2);
MultiplesNumber(number1, number2);   // вызываю метод 3
