using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_ADSI_2067791_794
{
    public partial class Frmcalculadora : Form
    {
        // ------ Invocar o llama la clase creada 

        ClsOperacionesMat Operador = new ClsOperacionesMat();

        // Valores Iniciales 
        double Primero;
        double Segundo;
        string Operando;
        public Frmcalculadora()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            Txtmostrar.Text = Txtmostrar.Text + "0";
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            Txtmostrar.Text = Txtmostrar.Text + "3";
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            Txtmostrar.Text = Txtmostrar.Text + "1";
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            Txtmostrar.Text = Txtmostrar.Text + "2";
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            Txtmostrar.Text = Txtmostrar.Text + "4";
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            Txtmostrar.Text = Txtmostrar.Text + "5";
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            Txtmostrar.Text = Txtmostrar.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            Txtmostrar.Text = Txtmostrar.Text + "7";
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            Txtmostrar.Text = Txtmostrar.Text + "8";
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            Txtmostrar.Text = Txtmostrar.Text + "9";
        }

        private void Btnsuma_Click(object sender, EventArgs e)
        {
            Operando = "+";
            Primero = double.Parse(Txtmostrar.Text);
            Txtmostrar.Clear();
        }

        private void Btnresta_Click(object sender, EventArgs e)
        {
            Operando = "-";
            Primero = double.Parse(Txtmostrar.Text);
            Txtmostrar.Clear();
        }

        private void Btndivision_Click(object sender, EventArgs e)
        {
            Operando = "/";
            Primero = double.Parse(Txtmostrar.Text);
            Txtmostrar.Clear();
        }

        private void Btnmultiplicar_Click(object sender, EventArgs e)
        {
            Operando = "*";
            Primero = double.Parse(Txtmostrar.Text);
            Txtmostrar.Clear();
        }

        private void Btnigual_Click(object sender, EventArgs e)
        {
            Segundo = double.Parse(Txtmostrar.Text);

            double Suma;
            double Resta;
            double Division;
            double Multiplicacion;


            switch (Operando)
            {
                case "+":
                    {
                        Suma = Operador.Sumar((Primero), (Segundo));
                        Txtmostrar.Text = Suma.ToString();
                    }
                    break;
                case "-":
                    {
                        Resta = Operador.Restar((Primero), (Segundo));
                        Txtmostrar.Text = Resta.ToString();
                    }
                    break;
                case "/":
                    {
                        Division = Operador.Dividir((Primero), (Segundo));
                        Txtmostrar.Text = Division.ToString();
                    }
                    break;
                case "*":
                    {
                        Multiplicacion = Operador.Multiplicar((Primero), (Segundo));
                        Txtmostrar.Text = Multiplicacion.ToString();
                    }
                    break;

            }
        }

        private void Btnclear_Click(object sender, EventArgs e)
        {
            Txtmostrar.Clear();
        }

        private void Btncoma_Click(object sender, EventArgs e)
        {
            Txtmostrar.Text = Txtmostrar.Text + ",";
        }
    }
}
