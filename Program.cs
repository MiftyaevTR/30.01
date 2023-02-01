// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
/*
void ShowNums (int num)
{
    if (num>1) ShowNums(num-1);
    Console.Write(num + " ");
}

ShowNums(10);
*/
// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
/*
int GetSumofDigits (int num)
{
    if (num!=0) return GetSumofDigits(num/10) + num % 10;
    else return 0;
}

Console.WriteLine(GetSumofDigits(1234564));
*/
// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
/*
void ShowNums2digit (int num1, int num2)
{
    if (num1>num2) 
        {
            Console.Write(num1 + " ");
            ShowNums2digit(num1-1, num2); 
        }
    else if (num1<num2) 
    {
        ShowNums2digit(num1, num2-1);
        Console.Write(num2 + " ");
    }
    else Console.Write(num1 + " ");
}

ShowNums2digit(20,10);
*/
// Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B.
/*
double GetStepen (double a, double b)
{
    if (b>0) return a*GetStepen(a,b-1);
    else if (b<0) return 1/a*GetStepen(a,b+1);
    else return 1;
}

Console.WriteLine(GetStepen(2,-3));
*/
// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
/*
void ShowNumsto1 (int num)
{
    Console.Write(num + " ");
    if (num>1) ShowNumsto1(num-1); 
}

Console.WriteLine("Pls enter a number: ");
int num =Convert.ToInt32(Console.ReadLine());
ShowNumsto1(num);
*/
// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
/*
int GetSummBetween2Digit (int num1, int num2)
{
    if (num1>num2) return GetSummBetween2Digit (num1-1,num2) + num1;
    else if (num1<num2) return num2+GetSummBetween2Digit(num1,num2-1);
    else return 0;
}

Console.WriteLine("Pls enter the first number: ");
int M =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Pls enter the second number: ");
int N =Convert.ToInt32(Console.ReadLine());
int result = GetSummBetween2Digit(M,N);
Console.WriteLine(result);
*/











