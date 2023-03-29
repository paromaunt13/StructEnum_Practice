/*
Используя Visual Studio, создайте проект по шаблону Console Application.
Создайте перечисление, в котором будут содержаться должности сотрудников как имена
констант. Присвойте каждой константе значение, задающее количество часов, которые должен
отработать сотрудник за месяц. Создайте класс Accauntant с методом bool AskForBonus(Post
worker, int hours), отражающее давать или нет сотруднику премию. Если сотрудник отработал
больше положеных часов в месяц, то ему положена премия.
*/

bool result = Accauntant.AskForBonus(EmployeePosition.Developer, 201);

switch (result)
{
    case true:
        Console.WriteLine($"Сотруднику {EmployeePosition.Developer} полагается премия!");
        break;
    case false:
        Console.WriteLine($"Сотруднику {EmployeePosition.Developer} премия не положена");
        break;
}
Console.ReadKey();
enum EmployeePosition
{
    Developer = 200,
    SalesManager = 150,
    HR = 100,
}

static class Accauntant
{
    public static bool AskForBonus(EmployeePosition employeePosition, int hours)
    {
        if (hours > ((int)employeePosition))
            return true;
        return false;
    }
}