
namespace Week7.Calcolatrice.WinForm
{
    partial class CalculatorForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btn1 = new System.Windows.Forms.Button();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnPoint = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnUguale = new System.Windows.Forms.Button();
            this.btnSomma = new System.Windows.Forms.Button();
            this.btnDiff = new System.Windows.Forms.Button();
            this.btnProd = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Value";
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(28, 249);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(64, 54);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click_1);
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(28, 43);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(249, 31);
            this.txtValue.TabIndex = 2;
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(122, 249);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(64, 54);
            this.btn2.TabIndex = 3;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(213, 249);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(64, 54);
            this.btn3.TabIndex = 4;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click_1);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(28, 177);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(64, 54);
            this.btn4.TabIndex = 5;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(122, 177);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(64, 54);
            this.btn5.TabIndex = 6;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(213, 177);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(64, 54);
            this.btn6.TabIndex = 7;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(28, 108);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(64, 54);
            this.btn7.TabIndex = 8;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(122, 108);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(64, 54);
            this.btn8.TabIndex = 9;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(213, 108);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(64, 54);
            this.btn9.TabIndex = 10;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btnC
            // 
            this.btnC.Location = new System.Drawing.Point(306, 20);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(64, 54);
            this.btnC.TabIndex = 11;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnPoint
            // 
            this.btnPoint.Location = new System.Drawing.Point(28, 320);
            this.btnPoint.Name = "btnPoint";
            this.btnPoint.Size = new System.Drawing.Size(64, 54);
            this.btnPoint.TabIndex = 12;
            this.btnPoint.Text = ".";
            this.btnPoint.UseVisualStyleBackColor = true;
            this.btnPoint.Click += new System.EventHandler(this.btnPoint_Click);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(122, 320);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(64, 54);
            this.btn0.TabIndex = 13;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btnUguale
            // 
            this.btnUguale.Location = new System.Drawing.Point(213, 320);
            this.btnUguale.Name = "btnUguale";
            this.btnUguale.Size = new System.Drawing.Size(64, 54);
            this.btnUguale.TabIndex = 14;
            this.btnUguale.Text = "=";
            this.btnUguale.UseVisualStyleBackColor = true;
            this.btnUguale.Click += new System.EventHandler(this.btnUguale_Click);
            // 
            // btnSomma
            // 
            this.btnSomma.Location = new System.Drawing.Point(306, 108);
            this.btnSomma.Name = "btnSomma";
            this.btnSomma.Size = new System.Drawing.Size(64, 54);
            this.btnSomma.TabIndex = 15;
            this.btnSomma.Tag = "somma";
            this.btnSomma.Text = "+";
            this.btnSomma.UseVisualStyleBackColor = true;
            this.btnSomma.Click += new System.EventHandler(this.btnSomma_Click);
            // 
            // btnDiff
            // 
            this.btnDiff.Location = new System.Drawing.Point(306, 177);
            this.btnDiff.Name = "btnDiff";
            this.btnDiff.Size = new System.Drawing.Size(64, 54);
            this.btnDiff.TabIndex = 16;
            this.btnDiff.Tag = "sottrai";
            this.btnDiff.Text = "-";
            this.btnDiff.UseVisualStyleBackColor = true;
            this.btnDiff.Click += new System.EventHandler(this.btnDiff_Click);
            // 
            // btnProd
            // 
            this.btnProd.Location = new System.Drawing.Point(306, 249);
            this.btnProd.Name = "btnProd";
            this.btnProd.Size = new System.Drawing.Size(64, 54);
            this.btnProd.TabIndex = 17;
            this.btnProd.Text = "*";
            this.btnProd.Tag = "moltiplica";
            this.btnProd.UseVisualStyleBackColor = true;
            this.btnProd.Click += new System.EventHandler(this.btnProd_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.Location = new System.Drawing.Point(306, 320);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(64, 54);
            this.btnDiv.TabIndex = 18;
            this.btnDiv.Tag = "dividi";
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 425);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnProd);
            this.Controls.Add(this.btnDiff);
            this.Controls.Add(this.btnSomma);
            this.Controls.Add(this.btnUguale);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnPoint);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.label1);
            this.Name = "CalculatorForm";
            this.Text = "MyCalculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnPoint;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnUguale;
        private System.Windows.Forms.Button btnSomma;
        private System.Windows.Forms.Button btnDiff;
        private System.Windows.Forms.Button btnProd;
        private System.Windows.Forms.Button btnDiv;
    }
}

