// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
ing System;
ing System.Collections.Generic;
mespace rreglos

public static class Extensions
{

    public static int findIndex<T>(this T[] array, T item)
    {
        return Array.FindIndex(array, val => val.Equals(item));
    }
}
internal class Program
{
    static void Main(string[] args)
    {
        char[] alfabeto = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'ñ', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', ' ', '.' }
        int[,] clave = { { 1, 2, 1 }, { 0, −1, 3 }, { 2, 1, 0 } };

        int[,] matriz = new int[3, 3];

        int index = alfabeto.findIndex('.');
        matriz[0, 1] = index;
        for (int j = 0; j < 3; j++)
        {
            for(int j = 0; j < 3; j++)
            {
                Console.Write(clave[i, j] + " ");
            }
            Console.WriteLine(' ');
        }
    }
} 

internal class Program
   