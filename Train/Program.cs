/*
Используя Visual Studio, создайте проект по шаблону Console Application.
Создайте программу, в которой создайте структуру именем Train (Поезд) ), структура должна
содержать следующие поля: название пункта назначения, номер поезда, время отправления.
В программе необходимо реализовать следующую логику: Пользователь должен с клавиатуры
вводить данные с клавиатуры в массив, который содержит упорядоченные номера поездов,
количество поездов сделать равным 5 шт. После чего пользователь должен иметь возможность
вывести информацию о поезде по номеру поезда.
*/

Train[] trains = new Train[5];

for (int i = 0; i < trains.Length; i++)
{
    Console.WriteLine("Введите номер поезда:");
    trains[i].TrainNumber = int.Parse(Console.ReadLine());   
    Console.WriteLine("Введите пункт назначения:");
    trains[i].Destination = Console.ReadLine();
    Console.WriteLine("Введите время отправления:");
    trains[i].DepartureTime = Console.ReadLine();   
}

Console.WriteLine("Введите порядковый номер поезда (1-5): ");
int trainNumber = int.Parse(Console.ReadLine());

ShowTrainInfo(trainNumber);

Console.ReadKey();
void ShowTrainInfo(int trainNumber)
{
    Console.WriteLine($"Номер поезда - {trains[trainNumber - 1].TrainNumber}");
    Console.WriteLine($"Пункт назначения - {trains[trainNumber - 1].Destination}");
    Console.WriteLine($"Время отправления - {trains[trainNumber - 1].DepartureTime}");
}
public struct Train
{
    public string Destination { get; set; }
    public int TrainNumber { get; set; }
    public string DepartureTime { get; set; }
}