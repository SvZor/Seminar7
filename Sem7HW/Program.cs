//Задача 2: Напишите программу вычисления функции Аккермана с 
// помощью рекурсии. Даны два неотрицательных числа m и n.


// Console.WriteLine("Введите неотрицательные числа m и n:");
// int m = Convert.ToInt32(Console.ReadLine());
// int n = Convert.ToInt32(Console.ReadLine());

// int result = Ackermann(m, n);

// Console.WriteLine($"Результат функции Аккермана для A({m}, {n}) = {result}");

// static int Ackermann(int m, int n)
// {
//     if (m == 0)
//     {
//         return n + 1;
//     }
//     else if (n == 0)
//     {
//         return Ackermann(m - 1, 1);
//     }
//     else
//     {
//         return Ackermann(m - 1, Ackermann(m, n - 1));
//     }
// }

//Задача 1: Задайте значения M и N. 
//Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
//Использовать рекурсию, не использовать циклы.

// //Задача 1: Задайте значения M и N. 
// // Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// // Использовать рекурсию, не использовать циклы.

// Console.WriteLine("Введите неотрицательные числа m и n:");
// int m = Convert.ToInt32(Console.ReadLine());
// int n = Convert.ToInt32(Console.ReadLine());

// void PrintNumbers(int m, int n) // делаем вызов функции 
//                                 // в которую передаем начальное и последнее числа
// {
//     if (m > n) // делаем точку остановки //  если это  цикл перенсти вниз
//                 //  на две строки то не дойдем до проверки и функция не остановится и зависнет
//     {
//         return;
//     }
//     Console.Write(m + " "); // до этого вызов переменной старт

//     PrintNumbers(m + 1, n); //прибавляем один к стартовому числу
// }

// PrintNumbers(m, n);

// Задача 3: Задайте произвольный массив. 
// Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.



int[] array = { 1, 2, 3, 4, 5 }; // Произвольный массив
PrintArrayReverse(array, array.Length - 1);


static void PrintArrayReverse(int[] array, int index)
{
    if (index < 0) // Условие выхода из рекурсии
    {
        return;
    }

    Console.WriteLine(array[index]); // Печать текущего элемента

    PrintArrayReverse(array, index - 1); // Рекурсивный вызов для следующего элемента
}
