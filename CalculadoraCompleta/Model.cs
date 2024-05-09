using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraCompleta
{
    class Model
    {
        public Model()
        {

        }//Fim do Construtor
        public int Somar(int num1, int num2)
        {
            return num1 + num2;
        }//Fim do Somar
        public int Subtrair(int num1, int num2)
        {
            return num1 - num2;
        }//Fim do Subtrair
        
        public int Multiplicar(int num1, int num2) 
        {
            return num1 * num2;
        }//Fim do Multiplicar

        public double Dividir(int num1, int num2)
            {
            if (num2 == 0)
            {
                return -1;
            }
            else
            {
                return num1 / num2;
            }
        }//Fim do Dividir

    }//Fim da Classe
}//Fim do Projeto
