/*
 Задача 64:
 Задайте значение N. Напишите программу, которая выведет все натуральные числа
 в промежутке от N до 1. Выполнить с помощью рекурсии.
 N = 5 -> "5, 4, 3, 2, 1"
 N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
 */

 int GetNumber(string msg)
 {
     Console.Write(msg);
     int userNumber = Convert.ToInt32(Console.ReadLine());;
     return userNumber;
 }

 string StringRecursion(int number)
 {
    if (number == 1) return number.ToString();

    return number + " " + StringRecursion(number - 1);
 }

 int userNumber = GetNumber("Введите число: ");
 Console.WriteLine();
 Console.Write(StringRecursion(number: userNumber));
