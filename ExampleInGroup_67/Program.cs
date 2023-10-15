﻿/* Задача 67: Напишите программу, которая будет принимать 
на вход число и возвращать сумму его цифр.
453 -> 12
45 -> 9 */

int Factorial(int n)
{
	if (n == 0) return 0;
	return n % 10 + Factorial(n / 10);
}

Console.WriteLine(Factorial(453)); // 120