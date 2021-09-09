using System;
using Week7.Calcolatrice.Core;

namespace Week7.Calcolatrice
{
    public class Program
    {
        static Calculator c = new Calculator();
        static void Main(string[] args)
        {
            Console.WriteLine("Benvenuto nella calcolatrice");

            bool continuare = true;

            do
            {
                int scelta = 0;
                Console.WriteLine("\n");
                Console.WriteLine("Premi 1 per eseguire un'Addizione");
                Console.WriteLine("Premi 2 per eseguira una Sottrazione");
                Console.WriteLine("Premi 3 per eseguire una Moltiplicazione");
                Console.WriteLine("Premi 4 per eseguire una Divisione");
                Console.WriteLine("Premi 5 per verificare che un numero sia maggiore di un altro");
                Console.WriteLine("Premi 0 per uscire");
                Console.WriteLine();
                while (!int.TryParse(Console.ReadLine(), out scelta) || scelta < 0 || scelta > 5)
                {
                    Console.WriteLine("Inserire valore corretto!");
                }

                switch (scelta)
                {
                    case 1:

                        RisultatoAddizione();
                        break;
                    case 2:
                        RisultatoSottrazione();
                        break;
                    case 3:
                        RisultatoMoltiplicazione();
                        break;
                    case 4:
                        RisultatoDivisione();
                        break;
                    case 5:
                        VerificaMaggiore();
                        break;
                    case 0:
                        Console.WriteLine("Arrivederci!");
                        continuare = false;
                        break;
                    default:
                        Console.WriteLine("Scelta sbagliata riprova");
                        break;
                }
            } while (continuare);

        }

        private static void VerificaMaggiore()
        {
            throw new NotImplementedException();
        }

        private static void RisultatoDivisione()
        {
            double a, b;

            Calculator calcolatrice = new Calculator();

            Console.WriteLine("Inserisci il primo valore: ");
            while (!double.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Inserire valore corretto");
            }
            Console.WriteLine("Inserisci il secondo valore: ");
            while (!double.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine("Inserire valore corretto");
            }

            double? risultato = calcolatrice.RisolviDivisione(a, b);
            if (b != 0)
            {
                Console.WriteLine($"Il risultato della tua divisione è:\n {a} / {b} = {risultato}");
            }
            else
            {
                Console.WriteLine("Impossibile dividere un numero per 0");
            }
        }

        private static void RisultatoMoltiplicazione()
        {
            double a, b;

            Calculator calcolatrice = new Calculator();

            Console.WriteLine("Inserisci il primo valore: ");
            while (!double.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Inserire valore corretto");
            }
            Console.WriteLine("Inserisci il secondo valore: ");
            while (!double.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine("Inserire valore corretto");
            }

            double risultato = calcolatrice.RisolviMoltiplicazione(a, b);
            Console.WriteLine($"Il risultato della tua moltiplicazione è:\n{a} * {b} = {risultato}");
        }

        private static void RisultatoSottrazione()
        {
            double a, b;

            Calculator calcolatrice = new Calculator();

            Console.WriteLine("Inserisci il primo valore: ");
            while (!double.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Inserire valore corretto");
            }
            Console.WriteLine("Inserisci il secondo valore: ");
            while (!double.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine("Inserire valore corretto");
            }

            double risultato = calcolatrice.RisolviSottrazione(a, b);
            Console.WriteLine($"Il risultato della tua sottrazione è:\n {a} - {b} = {risultato}");
        }

        private static void RisultatoAddizione()
        {
            double a, b;

            Calculator calcolatrice = new Calculator();

            Console.WriteLine("Inserisci il primo valore: ");
            while (!double.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Inserire valore corretto");
            }
            Console.WriteLine("Inserisci il secondo valore: ");
            while (!double.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine("Inserire valore corretto");
            }

            double risultato = calcolatrice.RisolviAddizione(a, b);
            Console.WriteLine($"Il risultato della tua addizione è:\n{a} + {b} = {risultato}");
        }
    }

}
