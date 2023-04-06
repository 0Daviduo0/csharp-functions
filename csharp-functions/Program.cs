using System;

namespace csharp_functions
{
    internal class Program
    {

        //Funzione per stampare contenuto array

        static void StampaArray(int[] array)
        {
            Console.WriteLine("----------STAMPA ARRAY----------");

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("elemento n." + i + ": " + array[i]);
            }
        }


        //Funzione per elevare al quadrato il numero dato e stamparlo

        static int Quadrato(int numero)
        {
            Console.WriteLine("----------NUMERI AL QUADRATO----------");

            int numeroAlQuadrato = numero * numero;
            return numeroAlQuadrato;
        }


        //Funzione per elevare al quadrato l'intero array dato e stamparlo

        static int[] ElevaArrayAlQuadrato(int[] array)
        {
            Console.WriteLine("----------ARRAY AL QUADRATO----------");


            int[] alQuadrato = Array.Empty<int>();

            for (int i = 0; i < array.Length; i++)
            {
                int number = array[i];
                int numberAlQuadrato = number * number;
                Array.Resize(ref alQuadrato, alQuadrato.Length + 1);
                alQuadrato[alQuadrato.Length - 1] = numberAlQuadrato;

            }
            return alQuadrato;

        }


        //Somma di tutti gli elementi dell'array

        static int sommaElementiArray(int[] array)
        {
            Console.WriteLine("----------SOMMA DELL'ARRAY----------");

            int[] ArrNumeri = Array.Empty<int>();
            int somma = 0;

            for (int i = 0; i < array.Length; i++)
            {
                int number = array[i];
                somma = somma + number;
                Array.Resize(ref ArrNumeri, ArrNumeri.Length + 1);
                ArrNumeri[ArrNumeri.Length - 1] = somma;

            }
            return somma;

        }


        //Array personalizzato

        static int[] ArrayPersonalizzato(int dimensione)
        {
            Console.WriteLine("----------DIMENSIONE ARRAY----------");

            int[] ArrayPersonalizzato = new int[dimensione];
            Console.WriteLine("La dimensione scelta per l'array è di " + dimensione + " spazi");
            Console.WriteLine("Adesso scegli gli elementi che vuoi avere all'interno del tuo array");
            for (int i = 0; i < dimensione; i++)
            {
                int numeroArray = Int32.Parse(Console.ReadLine());
                ArrayPersonalizzato[i] = numeroArray;
            }
            return ArrayPersonalizzato;
        }










        static void Main(string[] args)
        {

            int[] numeri = { 2, 6, 7, 5, 3, 9 };

            ////Stampa Array

            //StampaArray(numeri);


            ////Numeri al quadrato

            //Console.WriteLine("Scrivi un numero e questo verrà elevato al quadrato!");
            //int numero = Int32.Parse(Console.ReadLine());
            //int numeroAlQuadrato = Quadrato(numero);
            //Console.WriteLine($"Il quadrato di {numero} è {numeroAlQuadrato}");


            ////Eleva Array

            //int[] ArrAlQuadrato = ElevaArrayAlQuadrato(numeri);
            //Console.WriteLine("Il nuovo array al quadrato è: ");
            //StampaArray(ArrAlQuadrato);


            ////Somma Array

            //int somma = sommaElementiArray(numeri);
            //Console.WriteLine("la somma degli elementi dell'array è: " + somma);


            //BONUS - array di dimensioni e contenuto scelto dall'utente

            Console.WriteLine("Scrivi la quantità di spazi che vuoi all'interno dell'array");
            int dimensione = Int32.Parse(Console.ReadLine());
            int[] Array = ArrayPersonalizzato(dimensione);
            Console.WriteLine("Ecco l'array da te creato:");
            StampaArray(Array);
            Console.WriteLine("------------------------Eseguo le altre funzioni------------------------");

            //AL QUADRATO
            int[] ArrPersonaleAlQuadrato = ElevaArrayAlQuadrato(Array);
            Console.WriteLine("Il nuovo array al quadrato è: ");
            StampaArray(ArrPersonaleAlQuadrato);

            //SOMMA DEGLI ELEMENTI
            int sommaPersonale = sommaElementiArray(Array);
            Console.WriteLine("la somma degli elementi dell'array è: " + sommaPersonale);

        }
    }
}