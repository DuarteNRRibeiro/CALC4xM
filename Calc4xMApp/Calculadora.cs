using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc4xMApp
{
    public class Calculadora : ICalculadora
    {
        private double resultado = 0;

        public double Resultado { get { return resultado; } }

        public void Adicionar(double numero)
        {
            resultado += numero;
        }

        public void Subtrair(double numero)
        {
            resultado -= numero;
        }

        public void Multiplicar(double numero)
        {
            resultado *= numero;
        }

        public void Dividir(double numero)
        {
            if (numero == 0)
                throw new ExceptionOperacaoInvalida("Não é possível dividir por zero");
            resultado /= numero;
        }

        public void Reset()
        {
            resultado = 0;
        }

        public void Raiz(double numero)
        {
            resultado = Math.Sqrt(numero);
        }

        public void Inverso(double numero)
        {
            resultado = 1 / numero;
        }

        public void InverterSinal(double numero)
        {
            resultado = -1 * numero;
        }

        public void Quadrado(double numero)
        {
            resultado = numero * numero;
        }

        public void Percetagem(double numero)
        {
            resultado *= numero / 100;
        }

        public void AtualizarResultado(double numero)
        {
            resultado = numero;
        }
    }
}
