// Задача 4
// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

int Max = 0;
Console.WriteLine("Введите первое число");
int number1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число");
int number2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите третье число");
int number3 = int.Parse(Console.ReadLine()!);
if (number1 > Max ) 
{ 
    Max = number1;
};
if (number2 > Max ) 
{ 
    Max = number2;
};
    if (number3 > Max ) 
{ 
    Max = number3;
};
Console.WriteLine("max = " + Max);