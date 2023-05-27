﻿// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
//
// репетируем использованипе типа double, методов/ функций
void task43()
{
    double k1 = ReadDouble("Задайте коэф наклона 1-й прямой: ");
    double k2 = ReadDouble("Задайте коэф наклона 2-й прямой: ");
    if (k1 == k2)
    {
        Console.WriteLine($"Прямые параллельны: k1={k1} == k2={k2}");
        return;
    }
    double b1 = ReadDouble($"Задайте b1 (y при пересечении 1-й прямой вертикальной оси): ");
    double b2 = ReadDouble($"Задайте b2 (y при пересечении 2-й прямой вертикальной оси): ");
    // находим х в точке пересечения прямых
    double x = -(b2 - b1) / (k2 - k1);
    double y = k1 * x + b1;
    Console.WriteLine($"Координаты точки пересечения: х={Math.Round(x,3)}, y={Math.Round(y,3)}");

}

double ReadDouble(string text) // запрашивает действительное число с консоли и возвращает его после проглатывания с консоли
{
    System.Console.Write(text);
    return Convert.ToDouble(Console.ReadLine());
}
task43();
