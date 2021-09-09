using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Week7.Calcolatrice.Core;

namespace Week7.Calcolatrice.WinForm
{
    public partial class CalculatorForm : Form
    {
        private double valueA;
        private double valueB;
        private string operation;
        
        private Calculator calculator = new Calculator();

        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtValue.Text += btn8.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtValue.Text += btn2.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtValue.Text += btn9.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtValue.Text += btn5.Text;
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtValue.Clear();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtValue.Text += btn4.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtValue.Text += btn6.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtValue.Text += btn7.Text;
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            txtValue.Text += btnPoint.Text;
        }

        private void btnUguale_Click(object sender, EventArgs e)
        {
            valueB = (string.IsNullOrEmpty(txtValue.Text)) ? 0 : double.Parse(txtValue.Text);  //operatore ternario: se è vuoto prendi 0, altrimenti prendi il valore
            switch (operation)
            {
                case "somma":
                    txtValue.Text = calculator.RisolviAddizione(valueA, valueB).ToString();
                    break;
                case "sottrai":
                    txtValue.Text = calculator.RisolviSottrazione(valueA, valueB).ToString();
                    break;
                case "moltiplica":
                    txtValue.Text = calculator.RisolviMoltiplicazione(valueA, valueB).ToString();
                    break;
                case "dividi":
                    var risultato = calculator.RisolviDivisione(valueA, valueB);
                    txtValue.Text = (risultato == null) ? "Error" : risultato.ToString();
                    break;
            }
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            SetOperation(txtValue.Text, btnDiv.Tag.ToString());
        }

        private void btnProd_Click(object sender, EventArgs e)
        {
            SetOperation(txtValue.Text, btnProd.Tag.ToString());
        }

        private void btnDiff_Click(object sender, EventArgs e)
        {
            SetOperation(txtValue.Text, btnDiff.Tag.ToString());
        }

     

        private void btn1_Click_1(object sender, EventArgs e)
        {
            txtValue.Text += btn1.Text;
        }

        private void btn3_Click_1(object sender, EventArgs e)
        {
            txtValue.Text += btn3.Text;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtValue.Text += btn0.Text;
        }

        private void SetOperation(string contentValue, string operationToDo)
        {
            valueA = double.Parse(contentValue);
            operation = operationToDo;
            txtValue.Clear();
        }

        private void btnSomma_Click(object sender, EventArgs e)
        {
            SetOperation(txtValue.Text, btnSomma.Tag.ToString());
          
        }
    }
}
