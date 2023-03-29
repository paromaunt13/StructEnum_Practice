/*
Используя Visual Studio, создайте проект по шаблону Console Application.
Создайте статический класс с методом void Print (string stroka, int color), который выводит на
экран строку заданным цветом. Используя перечисление, создайте набор цветов, доступных
пользователю. Ввод строки и выбор цвета предоставьте пользователю.
*/

Console.WriteLine("Введите текст:");
string str = Console.ReadLine();

Console.WriteLine("Введите желаемый цвет текста:");
Console.WriteLine("1. Синий");
Console.WriteLine("2. Зелёны");
Console.WriteLine("3. Жёлтый");
Console.WriteLine("4. Красный");
Console.WriteLine("5. Фиолетовый");
int color = int.Parse(Console.ReadLine()); 

PrintString.Print(str, color);
Console.ReadKey();
static class PrintString
{
    public static void Print(string str, int color)
    {
        switch (color)
        {
            case 1:
                Console.ForegroundColor = (ConsoleColor)Colors.Blue;
                break; 
            case 2:
                Console.ForegroundColor = (ConsoleColor)Colors.Green;
                break;
            case 3:
                Console.ForegroundColor = (ConsoleColor)Colors.Yellow;
                break;
            case 4:
                Console.ForegroundColor = (ConsoleColor)Colors.Red;
                break;
            case 5:
                Console.ForegroundColor = (ConsoleColor)Colors.Violet;
                break;
            default: Console.WriteLine("Цвет не определен");
                break;
        }
        Console.WriteLine(str);
        Console.ResetColor();
    }
    
}
enum Colors
{
    Blue = 1,
    Green = 2,
    Yellow = 3,
    Red = 4,
    Violet = 5
}

