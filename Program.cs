﻿// Задача: Написать программу, которая из имеющегося массива строк формирует новый 
// массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// ["Hello", "2", "world", ":-)"] → [“2”, “:-)”]
// ["1234", "1567", "-2", "computer science"] → [“-2”]
// ["Russia", "Denmark", "Kazan"] → []

string[] Array = { "1234", "1567", "-2", "computer science" }; // задан первоначальный массив
int count = 0;
for (int i = 0; i < Array.Length; i++)
{
    if (Array[i].Length <= 3)
    {
        count++;
    }
}
string[] NewArray = new string[count];
int index = 0;
for (int i = 0; i < Array.Length; i++)
{
    if (Array[i].Length <= 3)
    {
        NewArray[index++] = Array[i];
    }
}
Console.Write("Исходный массив: ");
for (int i = 0; i < Array.Length; i++)
{
    Console.Write(Array[i] + " ");
}

Console.WriteLine();

Console.Write("Новый массив с учетом условия задачи: ");
for (int i = 0; i < NewArray.Length; i++)
{
    Console.Write(NewArray[i] + " ");
}
