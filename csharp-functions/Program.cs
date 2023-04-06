using System;

namespace csharp_functions
{
    internal class Program
    {

        static void Main(string[] args)
        {

            int[] numeri = { 2, 6, 7, 5, 3, 9 };

            ////Stampa Array

            //StampaArray(numeri);


            ////Numeri al quadrato

            //Console.WriteLine("Scrivi un numero e questo verrà elevato al quadrato!");
            //int numero = 0;
            //while (!int.TryParse(Console.ReadLine(), out numero))
            //{
            //    Console.WriteLine("ci hai provato! Inserisci un numero >:(");
            //}
            //int numeroAlQuadrato = Quadrato(numero);
            //Console.WriteLine($"Il quadrato di {numero} è {numeroAlQuadrato}");


            //Eleva Array

            //int[] ArrAlQuadrato = ElevaArrayAlQuadrato(numeri);
            //Console.WriteLine("Il nuovo array al quadrato è: ");
            //StampaArray(ArrAlQuadrato);
            //Console.WriteLine("La somma degli elementi dell'array al quadrato è: ");
            //Console.Writeline(sommaElementiArray(ArrAlQuadrato));
            //Console.WriteLine("L'array originale è: ");
            //StampaArray(numeri);
            



            ////Somma Array

            //int somma = sommaElementiArray(numeri);
            //Console.WriteLine("la somma degli elementi dell'array è: " + somma);


            //BONUS - array di dimensioni e contenuto scelto dall'utente

            Console.WriteLine("Scrivi la quantità di spazi che vuoi all'interno dell'array");
            int dimensione = 0;
            while (!int.TryParse(Console.ReadLine(), out dimensione))
            {
                Console.WriteLine("ci hai provato! Inserisci un numero >:(");
            }
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

        //Funzione per stampare contenuto array

        static void StampaArray(int[] array)
        {
            Console.WriteLine("----------STAMPA ARRAY----------");

            //ciclo per stampare elementi dell'array
            Console.Write("[");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
                if (i < array.Length - 1)
                    Console.Write(", ");
            }
            Console.WriteLine("]");
        }


        //Funzione per elevare al quadrato il numero dato e stamparlo

        static int Quadrato(int numero)
        {
            Console.WriteLine("----------NUMERI AL QUADRATO----------");

            //prende il numero dato e lo moltiplica per lo stesso numero
            int numeroAlQuadrato = numero * numero;
            return numeroAlQuadrato;
        }


        //Funzione per elevare al quadrato l'intero array dato e stamparlo

        static int[] ElevaArrayAlQuadrato(int[] array)
        {
            Console.WriteLine("----------ARRAY AL QUADRATO----------");

            //cicla attraverso l'array sovrascrivendo le celle con i valori al quadrato

            int[] AlQuadrato = (int[])array.Clone(); ;
            for (int i = 0; i < array.Length; i++)
            {
                AlQuadrato[i] *= AlQuadrato[i];
            }
            return AlQuadrato;

        }


        //Somma di tutti gli elementi dell'array

        static int sommaElementiArray(int[] array)
        {
            Console.WriteLine("----------SOMMA DELL'ARRAY----------");

            int somma = 0;

            //ciclo per prendere gli elementi dell'array e sommarli uno a uno per poi mettere il risultato in una variabile "somma"
            for (int i = 0; i < array.Length; i++)
            {
                int number = array[i];
                somma = somma + number;

            }
            return somma;

        }


        //Array personalizzato

        static int[] ArrayPersonalizzato(int dimensione)
        {
            Console.WriteLine("----------DIMENSIONE ARRAY----------");

            //Crea un array nuovo di dimensioni variabili in base al numero dato dall'utente
            int[] ArrayPersonalizzato = new int[dimensione];
            Console.WriteLine("La dimensione scelta per l'array è di " + dimensione + " spazi");
            Console.WriteLine("Adesso scegli gli elementi che vuoi avere all'interno del tuo array");
            //fa un ciclo per chiedere all'utente cosa mettere all'interno dell'array in base a quanti spazi ha scelto all'inizio
            for (int i = 0; i < dimensione; i++)
            {
                Console.Write("Scegli un valore per il " + (i + 1) + "o posto: ");
                int numeroArray = 0;
                while (!int.TryParse(Console.ReadLine(), out numeroArray))
                {
                    Console.Write("ci hai provato! Inserisci un numero >:( --> ");
                }
                ArrayPersonalizzato[i] = numeroArray;
            }
            return ArrayPersonalizzato;
        }

    }
}