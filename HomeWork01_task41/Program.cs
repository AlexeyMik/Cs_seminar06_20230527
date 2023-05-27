// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

void task41()
{
    int nOfNumbers = ReadInt("Сколько чисел будете вводить?: ");
    int CountPositive = 0;
    for (int i = 0; i < nOfNumbers; i++)
    {
        if (ReadInt("Задайте следующее число: ") > 0)
        {
            CountPositive++;
        };
    }
    Console.WriteLine($"Введено {CountPositive} положительных чисел");
}
int ReadInt(string text) // запрашивает число для ввода с консоли и возвращает его после проглатывания с консоли
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
task41();
