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
        public double Somar(double resolucao)
        {
            return resolucao + resolucao;
        }//Fim do Somar
        public double Subtrair(double resolucao)
        {
            return resolucao - resolucao;
        }//Fim do Subtrair
        
        public double Multiplicar(double resolucao) 
        {
            return resolucao * resolucao;
        }//Fim do Multiplicar

        public double Dividir(double resolucao)
            {
            if (resolucao == 0)
            {
                return -1;
            }
            else
            {
                return resolucao / resolucao;
            }
        }//Fim do Dividir

    }//Fim da Classe
}//Fim do Projeto
