﻿// Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

Console.Write("Введи цифру, обозначающую день недели: ");
int number = Convert.ToInt32(Console.ReadLine());

  if (number == 6 || number == 7) 
  /*Условный логический оператор || OR также вычисляет логический ИЛИ операндов, 
  но не вычисляет правый операнд, если левый операнд имеет true значение .*/
  {
    Console.WriteLine(" Выходной ");
  }
  
  else 
  Console.WriteLine(" Рабочий ");

