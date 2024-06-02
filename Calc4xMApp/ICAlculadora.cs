using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc4xMApp
{
    public interface ICalculadora
    {
        void Adicionar(double numero);
        void Subtrair(double numero);
        void Multiplicar(double numero);
        void Dividir(double numero);
        void Raiz(double numero);
        void Inverso(double numero);
        void InverterSinal(double numero);
        void Quadrado(double numero);
        void Percetagem(double numero);
        double Resultado { get; }
        void Reset();
        void AtualizarResultado(double numero);
    }
}
