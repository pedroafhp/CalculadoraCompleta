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
                    double resolucao = Convert.ToDouble(Console.ReadLine());
                    Resultado.Text = "" + modelo.Somar(resolucao);
                }
            }
        }//Fim do Somar

        private void button1_Click(object sender, EventArgs e)
        {
            Resultado.Text += "1";
        }

        private void NumeroDois_Click(object sender, EventArgs e)
        {
            Resultado.Text += "2";
        }

        private void NumeroTres_Click(object sender, EventArgs e)
        {
            Resultado.Text += "3";
        }

        private void NumeroQuatro_Click(object sender, EventArgs e)
        {
            Resultado.Text += "4";
        }

        private void NumeroCinco_Click(object sender, EventArgs e)
        {
            Resultado.Text += "5";
        }

        private void NumeroSeis_Click(object sender, EventArgs e)
        {
            Resultado.Text += "6";
        }

        private void NumeroSete_Click(object sender, EventArgs e)
        {
            Resultado.Text += "7";
        }

        private void NumeroOito_Click(object sender, EventArgs e)
        {
            Resultado.Text += "8";
        }

        private void NumeroNove_Click(object sender, EventArgs e)
        {
            Resultado.Text += "9";
        }

        private void NumeroZero_Click(object sender, EventArgs e)
        {
            Resultado.Text += "0";
        }

        private void Subtrair_Click(object sender, EventArgs e)
        {
            if (NumeroUm.Text == "" || NumeroDois.Text == "")
            {
                Resultado.Text = "Preencha os Campos Numéricos";
            }
            else
            {
                double resolucao = Convert.ToDouble(Console.ReadLine());
                Resultado.Text = "" + modelo.Subtrair(resolucao);
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
                double resolucao = Convert.ToDouble(Console.ReadLine());
                Resultado.Text = "" + modelo.Multiplicar(resolucao);
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
                    double resolucao = Convert.ToDouble(Console.ReadLine());
                    if (modelo.Dividir(resolucao) == -1)
                    {
                        Resultado.Text = "Impossível Dividir";
                    }
                    else
                    {
                        Resultado.Text = "" + modelo.Dividir(resolucao);
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
                NumeroUm.Text += "";
                NumeroDois.Text += "";
                Resultado.Text = "";
            }
        }//Fim do Cancelar

    }//Fim da Classe
}//Fim do Projeto
