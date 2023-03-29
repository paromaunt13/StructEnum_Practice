﻿/*
Используя Visual Studio, создайте проект по шаблону Console Application.
Создайте класс MyClass и структуру MyStruct, которые содержат в себе поля public string change.
В классе Program создайте два метода:
- static void ClassTaker(MyClass myClass), который присваивает полю change экземпляра myClass
значение «изменено».
- static void StruktTaker(MyStruct myStruct), который присваивает полю change экземпляра
myStruct значение «изменено».
Продемонстрируйте разницу в использовании классов и структур, создав в методе Main()
экземпляры структуры и класса. Измените, значения полей экземпляров на «не изменено», а
затем вызовите методы ClassTaker и StruktTaker. Выведите на экран значения полей экземпляров.
Проанализируйте полученные результаты.
*/
static void ClassTaker(MyClass myClass)
{
    myClass.Change = "изменено";
}
static void StruktTaker(MyStruct myStruct)
{
    myStruct.Change = "изменено";
}

MyClass myClass = new();
MyStruct myStruct = new();

myClass.Change = "не изменено";
myStruct.Change = "не изменено";

ClassTaker(myClass);
StruktTaker(myStruct);

Console.WriteLine(myClass.Change);
Console.WriteLine(myStruct.Change);
class MyClass
{
    public string Change { get; set; }
}
struct MyStruct
{
    public string Change { get; set; }
}