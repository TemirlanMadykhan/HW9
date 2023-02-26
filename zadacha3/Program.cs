/*
 Задача 68:
 Напишите программу вычисления функции Аккермана с помощью рекурсии.
 Даны два неотрицательных числа m и n.
 m = 2, n = 3 -> A(m,n) = 9
 m = 3, n = 2 -> A(m,n) = 29
 */

 int GetNumber(string msg)
 {
     Console.Write(msg);
     while(true)
     {
         if(int.TryParse(Console.ReadLine(), out var userNumber))
         if(userNumber >= 0)
         return userNumber;
         else
         Console.WriteLine("Введенное значение не удовлетворяет требованиям задачи\n");
     }
 }

 static int S(int n, int m)
 {
   if ((n == 1) && (m == 1))
     return 1;
   else
     if (n > 1)
       return S(n - 1, m) + m;
     else
       return S(n, m - 1) + 1;
 }

 int userNumberM = GetNumber("Введите число M: ");
 int userNumberN = GetNumber("Введите число N: ");
 Console.WriteLine();
 int result = S(m: userNumberM, n: userNumberN);
 Console.Write($"Функция Аккермана для {userNumberM} и {userNumberN} = {result}");
