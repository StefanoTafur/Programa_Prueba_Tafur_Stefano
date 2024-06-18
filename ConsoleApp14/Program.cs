using System;

class program
{
    static void Main ()
    {
        Console.WriteLine("Cuantos numeros desea ingresar->");
        int cantidad = int.Parse (Console.ReadLine());

        int[] numeros = new int[cantidad];

        Console.WriteLine("ingrese los numeros->");
        for (int i = 0; i < cantidad; i++)
        {
            numeros[i] = int.Parse (Console.ReadLine());
        }
        Array.Sort (numeros);

        Console.WriteLine("numeros ordenados:");
        foreach (int numero in numeros)
        {
            Console.WriteLine(numero);
        }
    }
}