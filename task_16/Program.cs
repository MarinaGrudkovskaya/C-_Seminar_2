// 16. Напишите программу, которая принимает на
// вход два числа и проверяет, является ли одно
// число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

int GetNumber()  // ВНИМАНИЕ - после функции не ставится ";"
 {
    Console.WriteLine("Введите числo: ");
    int number = int.Parse(Console.ReadLine()!);
    return number;
 }


void SquareNumbers(int number1, int number2)
 {
    if(number2%number1 ==0 | number1%number2 ==0)
    {
        Console.Write(number1 + ","+ number2 + " -> Да");
    }
    else
    {
        Console.Write(number1 + ","+ number2 +  " -> Нет");
    }
 }

int number1 = GetNumber();
int number2 = GetNumber();
SquareNumbers(number1, number2);
