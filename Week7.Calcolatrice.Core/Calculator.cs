using System;

namespace Week7.Calcolatrice.Core
{
    public class Calculator { 
       public double RisolviAddizione(double a, double b)
       {
            double risultato;
            risultato = a + b;

            return risultato;

       }

        public double RisolviSottrazione(double a, double b)
        {
            double risultato;
            risultato = a - b;

            return risultato;


        }

        public double RisolviMoltiplicazione(double a, double b)
        {
            double risultato;
            risultato = a * b;

            return risultato;

        }


        /// <summary>
        /// Questo metodo fa la divisione fra a e b, se b è 0 restituisce null
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>



        public double? RisolviDivisione(double a, double b)
        {
            double risultato;
            if (b != 0)
            {
                risultato = a / b;

                return risultato;
            }
            else
            {
                return null;
            }


        }

        public bool VerificaSeAMaggioreDiB(double a, double b)
        {
            if (a >= b)
            {
                return true;
            }
            return false;
        }
    }
}

