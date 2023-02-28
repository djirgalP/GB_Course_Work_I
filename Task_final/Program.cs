using System;
using static System.Console;

Clear();
WriteLine("Введите значения элементов массива через пробел -> ");
string[] array = ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
//Определяем сколько элементов массива <=3
int counter = 0;
for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) 
            counter += 1;
    }
//Если таковые есть, то создаем новый массив из элементов длиной <=3 и выводим на печать
if (counter > 0)
{       
    string[] array_new = new string[counter];
    counter = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) 
        {
            array_new[counter] = array[i];
            counter += 1;
        }
    }
    Console.Write("[");
    Console.Write(String.Join(", ", array_new));
    Console.Write("]");
} else 
    Console.WriteLine("[]");
