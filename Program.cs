/*Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3*/
int getUserDate(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine(message);
    Console.ResetColor();
    int UserData = int.Parse(Console.ReadLine()!);
    return UserData;
}
void printArray(double[] array)
{
    string result = "[";
    for (int i = 0; i < array.Length; i++)
    {
        result = result + array[i] + " ";
    }
    result = result[..^1] + "]";
    Console.WriteLine(result);
}
double getUserDoubDate(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine(message);
    Console.ResetColor();
    double UserData = double.Parse(Console.ReadLine()!);
    return UserData;
}
int generateArray(int N)
{
    int count = 0;
    double[] mas = new double[N];
    for (int i = 0; i < N; i++)
    {
        mas[i] = getUserDoubDate("Введите число");
        if (mas[i] > 0)
            count = count + 1;
    }
    printArray(mas);
    return count;
}
int N = getUserDate("Введите число элементов массива");
int count = generateArray(N);

Console.WriteLine(count);