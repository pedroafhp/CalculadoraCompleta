using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraCompleta
{
    public partial class CalculadoraCompleta : Form
    {
        Model modelo;
        public CalculadoraCompleta()
        {
            modelo = new Model();
            InitializeComponent();
        }
        private void button11_Click(object sender, EventArgs e)
        {
            {
                if (NumeroUm.Text == "" || NumeroDois.Text == "")
                {
                    Resultado.Text = "Preencha os Campos Numéricos";
                }
                else
                {
                    int num1 = Convert.ToInt32(NumeroUm.Text);
                    int num2 = Convert.ToInt32(NumeroDois.Text);
                    Resultado.Text = "" + modelo.Somar(num1, num2);
                }
            }
        }//Fim do Somar

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void NumeroDois_Click(object sender, EventArgs e)
        {

        }

        private void NumeroTres_Click(object sender, EventArgs e)
        {

        }

        private void NumeroQuatro_Click(object sender, EventArgs e)
        {

        }

        private void NumeroCinco_Click(object sender, EventArgs e)
        {

        }

        private void NumeroSeis_Click(object sender, EventArgs e)
        {

        }

        private void NumeroSete_Click(object sender, EventArgs e)
        {

        }

        private void NumeroOito_Click(object sender, EventArgs e)
        {

        }

        private void NumeroNove_Click(object sender, EventArgs e)
        {

        }

        private void NumeroZero_Click(object sender, EventArgs e)
        {

        }

        private void Subtrair_Click(object sender, EventArgs e)
        {
            if (NumeroUm.Text == "" || NumeroDois.Text == "")
            {
                Resultado.Text = "Preencha os Campos Numéricos";
            }
            else
            {
                int num1 = Convert.ToInt32(NumeroUm.Text);
                int num2 = Convert.ToInt32(NumeroDois.Text);
                Resultado.Text = "" + modelo.Subtrair(num1, num2);
            }
        }//Fim do Subtrair

        private void Multiplicar_Click(object sender, EventArgs e)
        {
            if (NumeroUm.Text == "" || NumeroDois.Text == "")
            {
                Resultado.Text = "Preencha os Campos Numéricos";
            }
            else
            {
                int num1 = Convert.ToInt32(NumeroUm.Text);
                int num2 = Convert.ToInt32(NumeroDois.Text);
                Resultado.Text = "" + modelo.Multiplicar(num1, num2);
            }
        }//Fim do Multiplicar

        private void Dividir_Click(object sender, EventArgs e)
        {
            {
                if (NumeroUm.Text == "" || NumeroDois.Text == "")
                {
                    Resultado.Text = "Preencha os Campos Numéricos";
                }
                else
                {
                    int num1 = Convert.ToInt32(NumeroUm.Text);
                    int num2 = Convert.ToInt32(NumeroDois.Text);
                    if (modelo.Dividir(num1, num2) == -1)
                    {
                        Resultado.Text = "Impossível Dividir";
                    }
                    else
                    {
                        Resultado.Text = "" + modelo.Dividir(num1, num2);
                    }
                }
            }
        }//Fim do Dividir

        private void Resultado_Click(object sender, EventArgs e)
        {
            
        }//Fim do Resultado

        private void Cancelar_Click(object sender, EventArgs e)
        {
            if (NumeroUm.Text == "" || NumeroDois.Text == "")
            {
                Resultado.Text = "Preencha os Campos Numéricos";
            }
            else
            {
                NumeroUm.Text = "";
                NumeroDois.Text = "";
                Resultado.Text = "";
            }
        }//Fim do Cancelar

    }//Fim da Classe
}//Fim do Projeto
