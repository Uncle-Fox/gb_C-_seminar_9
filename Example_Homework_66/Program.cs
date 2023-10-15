/* Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в 
промежутке от M до N. Выполнить с помощью рекурсии.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

Console.WriteLine("Введите два числа, а программа покажет какие числа находятся в их диапазоне.");
Console.Write("Введите первое натуральное число:\nM = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе натуральное число:\nN = ");
int n = Convert.ToInt32(Console.ReadLine());

if (n < 1 || m < 1)
{
    Console.WriteLine("Ошибка ввода");
    return;
}

Console.WriteLine($"M = {m}; N = {n} -> {SumRecursive(m, n)}");

/// <summary>
/// Метод ищет сумму натуральных чисел в диапазон от m до n 
/// </summary>
/// <param name="m">начало диапазона</param>
/// <param name="n">конец диапазона</param>
/// <returns></returns>
int SumRecursive(int m, int n) // 4 и 8
{
    if (n == m) return m; //
    return m + SumRecursive(m + 1, n); // 
}






