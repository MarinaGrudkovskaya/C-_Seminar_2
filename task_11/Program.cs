// 11. Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int GetRandonNamberThree()  // 1 метод, который генерирует и потом печатает рандомное трехзначное число
{
   int number = new Random().Next(100, 999); 
   Console.Write(number + " -> ");
   return number;
}

int GetFirst(int num1) // 2 метод нахождения числа первого и умножение на 
{
    num1 = (num1/100)*10;  // ВНИМАНИЕ я уже объявила тип данных переменной в скобках метода, в теле метода не объявлять!
    return num1;
}
int GetThree(int num3) // 4 метод нахождение 3 числа
{
    return num3 % 10;
}

void PrintNumber(int number) // 3 метод печатающий число
{
    Console.WriteLine(number);
}

int number = GetRandonNamberThree();   //вызываем метод 1
int number1 = GetFirst(number);   //вызываем метод 2
int number3 = GetThree(number);  // вызываем метод 4
PrintNumber(number1+number3); // вызываем метод 3
// int num1 = (number/100)*10;
// int num2 = C
// Console.WriteLine(num1+num2);