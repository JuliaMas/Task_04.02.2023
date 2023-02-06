// Написать программу масштабирования фигуры

Console.Write("Введите координаты вершин фигуры: ");
string coords = Console.ReadLine()
                .Replace("(", "")
                .Replace(")", "")
                ;
Console.WriteLine(coords);
Console.Write("Введите коэф: ");
var k = double.Parse(Console.ReadLine()!);

var data = coords.Split(" ")
                .Select(item => item.Split(','))
                .Select(e => (x: int.Parse(e[0]), y: int.Parse(e[1])))
                .Select(point => (point.x * k, point.y * k))
                .ToArray();

for(int i = 0; i < data.Length; i++)
{
   Console.WriteLine(data[i]);
   Console.WriteLine();
}                
