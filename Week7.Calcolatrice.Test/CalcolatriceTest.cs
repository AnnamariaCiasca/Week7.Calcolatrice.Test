using System;
using Week7.Calcolatrice.Core;
using Xunit;

namespace Week7.Calcolatrice.Test
{
    public class CalcolatriceTest
    {
        [Fact]
        public void Test1()
        {
            //Arrange: predisposizione del test
            Calculator calcolatrice = new Calculator();

            //ACT: chiata alla funzionalità da testare
            double risultato = calcolatrice.RisolviAddizione(1, 2);

            //Assert: verifica del risultato
            
            Assert.Equal(3, risultato);// alternativa Assert.True(risultato[0] == 1);
        }

        [Fact]
        public void Test2()
        {
            //Arrange: predisposizione del test
            Calculator calcolatrice = new Calculator();

            //ACT: chiata alla funzionalità da testare
            double risultato = calcolatrice.RisolviSottrazione(5, 8);

            //Assert: verifica del risultato

            Assert.Equal(-3, risultato);// alternativa Assert.True(risultato[0] == 1);
        }

        [Fact]
        public void Test3()
        {
            //Arrange: predisposizione del test
            Calculator calcolatrice = new Calculator();

            //ACT: chiata alla funzionalità da testare
            double risultato = calcolatrice.RisolviMoltiplicazione(2, 4);

            //Assert: verifica del risultato

            Assert.Equal(8, risultato);// alternativa Assert.True(risultato[0] == 1);
        }

        [Fact]
        public void Test4()
        {
            //Arrange: predisposizione del test
            Calculator calcolatrice = new Calculator();

            //ACT: chiata alla funzionalità da testare
            double? risultato = calcolatrice.RisolviDivisione(9, 3);

            //Assert: verifica del risultato

            Assert.Equal(3, risultato);// alternativa Assert.True(risultato[0] == 1);
        }

        [Fact]
        public void Test5()
        {
            //Arrange: predisposizione del test
            Calculator calcolatrice = new Calculator();

            //ACT: chiata alla funzionalità da testare
            double? risultato = calcolatrice.RisolviDivisione(3, 0);

            //Assert: verifica del risultato

            Assert.True(risultato == null);// alternativa Assert.True(risultato[0] == 1);
        }

        [Fact]
        public void TestVerificaSeAMaggioreDiB()
        {
            //ARRANGE: predisposizione del test
            Calculator calcolatrice = new Calculator(); 

           //ACT: chiamata alla funzionalità da testare
            bool risultato = calcolatrice.VerificaSeAMaggioreDiB(3, 1);
            //ASSERT: valutazione del risultato atteso vs restituito
            Assert.True(risultato == true);
        }
    }
}
