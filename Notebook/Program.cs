/*
Используя Visual Studio, создайте проект по шаблону Console Application.
Создайте программу, в которой создайте структуру с именем – Notebook (Блокнот), структура
должна содержать следующие поля: модель, производитель, цена. В структуре реализуйте
конструктор для инициализации полей и метод для вывода содержимого полей на экран.
*/

Notebook notebook = new("Записная книжка", "Stationery Company", 10);
notebook.ShowNotebookInfo();

Console.ReadKey();
struct Notebook
{
    public string Model { get; set; }
    public string Producer { get; set; }
    public int Price { get; set; }
    public Notebook(string model, string producer, int price)
    {
        Model = model;
        Producer = producer;
        Price = price;
    }
    public void ShowNotebookInfo()
    {
        Console.WriteLine($"Вид блокнота: {Model}");
        Console.WriteLine($"Производитель: {Producer}");
        Console.WriteLine($"Цена: {Price}");
    }
}