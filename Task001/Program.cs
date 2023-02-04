// Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 задан

Console.Write("Введите значение b1 = ");
var b1 = double.Parse(Console.ReadLine());
Console.Write("Введите значение k1 = ");
var k1 = double.Parse(Console.ReadLine());
Console.Write("Введите значение b2 = ");
var b2 = double.Parse(Console.ReadLine());
Console.Write("Введите значение k2 = ");
var k2 = double.Parse(Console.ReadLine());
if (k1 == k2 || b1 == b2)
{
    Console.WriteLine("Прямые не пересекаются");
}
else
{   var x = ((b2 - b1) / (k1 - k2));
    var y = k1 * x + b1;

Console.WriteLine($"Прямые пересекаются в точке ({x};{y})");
}