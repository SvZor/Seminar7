// Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// Указание
// Использовать рекурсию.
// Пример
// 123 => 6
// 63 => 9

// Console.WriteLine("Введите число");
// int num = int.Parse(Console.ReadLine());

// int GetSumNum(int number)
// {
//     if (number == 0)
//     {
//         return 0;
//     }

//     return number % 10 + GetSumNum(number / 10);
// }

// System.Console.WriteLine(GetSumNum(num));

// ВТОРОЕ РЕШЕНИЕ С ВОЙДОМ, но правильней верхнее решение

// Console.WriteLine("Введите число");
// int num = int.Parse(Console.ReadLine());

// int sum = 0;

// void GetSumNum(int number)
// {
//     if (number == 0)
//     {
//         return;
//     }
//     sum+=number%10;
//     GetSumNum(number / 10);
// }
// GetSumNum(num);
// System.Console.WriteLine(sum);

// Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N.
// Указание
// Использовать рекурсию. Не использовать цикл.
// Пример
// N=5 => 1 2 3 4 5


// Console.WriteLine("Введите число");
// int num = int.Parse(Console.ReadLine()); // получили число

// int firstNum = 1; // создалди переменную с кторой начинаем

// void PrintNumbers(int start, int number) // делаем вызов функции 
// в которую передаем начальное и последнее числа
// {
//     if (number < start) // делаем точку остановки //  если это  цикл перенсти вниз
//  на две строки то не дойдем до проверки и функция не остановится и зависнет
//     {
//         return;
//     }
//     System.Console.Write(start + " "); // до этого вызов переменной старт

//     PrintNumbers(start + 1, number); //прибавляем один к стартовому числу
// }

// PrintNumbers(firstNum, num);

// Считать строку с консоли, содержащую латинские буквы.
// Вывести на экран согласные буквы этой строки.
// Указание
// Использовать рекурсию. Не использовать цикл.
// Пример
// “hello” => h l l
// “World” => W r l d
// “Hello world!” => H l l w r l d


Console.WriteLine("Введите строку");
string userInput = Console.ReadLine();

string vowels= "aieuo";
string result ="";
int i=0;

void PrintUserInput(int countElement,string str)
{
if(str.Length==countElement)
{
return;
}

if(!vowels.Contains(str[countElement]))
{
result = result+str[countElement];
}

PrintUserInput(countElement+1,str);
}

PrintUserInput(i,userInput);

System.Console.WriteLine(result);



