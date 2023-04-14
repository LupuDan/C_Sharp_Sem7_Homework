/*
    Задача 50. Напишите программу,
    которая на вход принимает позиции элемента в двумерном массиве,
    и возвращает значение этого элемента или же указание,
    что такого элемента нет.
    Например, задан массив:
    1 4 7 2
    5 9 2 3
    8 4 2 4
    17 -> такого числа в массиве нет
*/

using System;

class Program {
    static void Main(string[] args) {
        int[,] array = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        Console.Write("Введите номер строки: ");
        int row = int.Parse(Console.ReadLine());

        Console.Write("Введите номер столбца: ");
        int column = int.Parse(Console.ReadLine());

        if (row < 0  row >= array.GetLength(0)  column < 0 || column >= array.GetLength(1)) {
            Console.WriteLine("Указанный элемент не существует");
        } else {
            Console.WriteLine($"Значение элемента: {array[row, column]}");
        }
    }
}