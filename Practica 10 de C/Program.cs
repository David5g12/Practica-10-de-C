using System;

class Program
{
    static int SumaIterativa(int n)
    {
        int suma = 0;
        while (n > 9)
        {
            suma += n % 10;
            n /= 10;
        }
        suma += n;
        return suma;
    }

    static int SumaRecursiva(int n)
    {
        if (n <= 9)
        {
            return n;
        }
        else
        {
            return SumaRecursiva(n / 10) + n % 10;
        }
    }

    static void Main()
    {
        int n;
        Console.WriteLine("Ingresa la cantidad de números para la suma  recursiva y iterativa:");
        n = int.Parse(Console.ReadLine());

        int sumaTotalIterativa = 0;
        int sumaTotalRecursiva = 0;

        Console.WriteLine("Ingresa los números que deseas sumar,:");
        for (int i = 0; i < n; i++)
        {
            Console.Write("Número --> ");
            int numero = int.Parse(Console.ReadLine());

            sumaTotalIterativa += SumaIterativa(numero);
            sumaTotalRecursiva += SumaRecursiva(numero);
        }

        Console.WriteLine("Suma Total Iterativa: " + sumaTotalIterativa);
        Console.WriteLine("Suma Total Recursiva: " + sumaTotalRecursiva);

        Console.ReadKey();
    }
}
