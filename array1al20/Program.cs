using System;

namespace array1al20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numero = new int[20];
            int i = 0;
            int contador = 0;
            for (i = 0; i < numero.Length; i++)
            {
                numero[i] = i * 5;
                Console.WriteLine($" numero: \n{numero[i]}");
                contador++;
            }
        }
    }
}
