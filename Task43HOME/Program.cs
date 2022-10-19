/*Напишите программу, которая найдёт точку 
пересечения двух прямых, заданных уравнениями
 y = k1 * x + b1, y = k2 * x + b2;
  значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/

(double, double) Point(double b1, double k1, double b2, double k2)
{
    double tempX = -(b1 - b2) / (k1 - k2);
    double tempY = (k1 * tempX) + b1;
    return (tempX, tempY);
}
int GetNumberConsole(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}

double b1 = GetNumberConsole("Введите первое число b1");
double k1 = GetNumberConsole("Введите первое число k1");
double b2 = GetNumberConsole("Введите первое число b2");
double k2 = GetNumberConsole("Введите первое число k2");
(double tempX, double tempY) = Point(b1, k1, b2, k2);

Console.WriteLine($"Точка пересечения двух прямых ({Math.Round (tempX, 2)} ; {Math.Round (tempY, 2)})");
