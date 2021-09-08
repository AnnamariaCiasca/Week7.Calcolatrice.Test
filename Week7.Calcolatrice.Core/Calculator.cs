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

        public double RisolviDivisione(double a, double b)
        {
            double risultato;
            if (b != 0)
            {
                risultato = a / b;

                return risultato;
            }
            else
            {
                return double.PositiveInfinity;
            }


        }
    }
}

