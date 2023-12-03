// 9. Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8
int GetRandomNumber() // 1 метод генерирующий рандомное число. Пустые скобки, можно не указывать в скобках ничего
{
    int number = new Random().Next(10, 100);
    // Console.WriteLine(number);
    return number;
}

int number = GetRandomNumber(); // Вызываем метод, который описали выше, 
                                //причем переменная number внутри метода не то же самое, что и в этой строке

int GetFirstDigital(int number1)   // 2 методдля извлечения 1-го числа
{
    // number1 = number1/10;
    return number1/10;  //в данной строку мы записали два действия: преобразование числа и возврат уже преобразованного
}          

int num1 = GetFirstDigital(number); // вызываем вышеописанный метод, 
// причем в качестве аргумента(обрабатываемого числа) берем из строки 14, тоесть наше рандомное число

int GetSecondDigital(int number2) // 3 метод извлечения второго числа
{
    number2 = number2 % 10;
    return number2;   
}
int num2 = GetSecondDigital(number);

int MaxNumber(int number1, int number2)// 4 метод нахождения максимального числа 
{
    int max = number1;
    if(number2>number1) max = number2;
    return max;
}
int maxnum = MaxNumber(num1,num2); //вызываю вышеописанный метод

void PrintNumber(int nam) //5 метод который печатает, ничего не сохраняет, поэтому Void
{
    Console.WriteLine(nam);
}
PrintNumber(number); //вызываем вышеописанный метод, просто по имени и в скобках та переменная с которой хотим работать
PrintNumber(num1);
PrintNumber(num2);
PrintNumber(maxnum); 

