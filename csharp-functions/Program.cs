using System;

namespace csharp_functions
{
    internal class Program
    {

        ////Funzione per stampare contenuto array
        static void StampaArray(int[] array)
        {
            Console.WriteLine("----------STAMPA ARRAY----------");

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("elemento n." + i + ": " + array[i]);
            }
        }


        ////Funzione per elevare al quadrato il numero dato e stamparlo
        //static int Quadrato(int numero)
        //{
        //    Console.WriteLine("----------NUMERI AL QUADRATO----------");

        //    int numeroAlQuadrato = numero * numero;
        //    return numeroAlQuadrato;
        //}


        ////Funzione per elevare al quadrato l'intero array dato e stamparlo

        //static int[] ElevaArrayAlQuadrato(int[] array)
        //{
        //    int[] alQuadrato = Array.Empty<int>(); 

        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        int number = array[i];
        //        int numberAlQuadrato = number * number;
        //        Array.Resize(ref alQuadrato, alQuadrato.Length + 1);
        //        alQuadrato[alQuadrato.Length - 1] = numberAlQuadrato;

        //    }
        //    return alQuadrato;

        //}










        static void Main(string[] args)
        {

            int[] numeri = { 1, 2, 3, 4, 5 };

            ////Stampa Array

            //StampaArray(numeri);


            ////Numeri al quadrato

            //Console.WriteLine("Scrivi un numero e questo verrà elevato al quadrato!");
            //int numero = Int32.Parse(Console.ReadLine());
            //int numeroAlQuadrato = Quadrato(numero);
            //Console.WriteLine($"Il quadrato di {numero} è {numeroAlQuadrato}");


            ////Eleva Array
            //int[] ArralQuadrato = Array.Empty<int>();
            //int[] ArrAlQuadrato = ElevaArrayAlQuadrato(numeri);
            //StampaArray(ArrAlQuadrato);


        }
    }
}