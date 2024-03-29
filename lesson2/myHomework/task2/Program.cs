﻿// Задача 2: Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 
// и выдаёт номер координатной четверти плоскости, в которой находится эта точка.

Console.WriteLine("Введите координаты точки по оси Х: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки по оси У: ");
int y = int.Parse(Console.ReadLine());

if(x == 0 || y == 0){
    Console.WriteLine("Координаты должны быть больше нуля. Попробуйте ещё раз.");
}else if(x > 0 &&  y > 0){
    Console.WriteLine("Точка находится в первой координатной четверти (I).");
}else if(x < 0 && y > 0){
    Console.WriteLine("Точка находится во второй координатной четверти (II).");
}else if(x < 0 && y < 0){
    Console.WriteLine("Точка находится в третьей координатной четверти (III).");
}else{
    Console.WriteLine("Точка находится в четвертой координатной четверти (IV).");
}