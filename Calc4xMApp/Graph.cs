using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc4xMApp
{
    internal class Graph : IGraph
    {
        //converte o dados de string para um array
        public double[][] ConverterString(string leitura)
        {
            if (leitura == null)
            {
                return null;
            }

            double[] x = new double[0];
            double[] y1 = new double[0];
            double[][] conjunto = new double[2][];
            double num1, num2;
            string[] coordenadas = new string[3];

            string[] pairs = leitura.Split(';');

            foreach (string pair in pairs)
            {
                Array.Resize(ref x, x.Length + 1);
                Array.Resize(ref y1, y1.Length + 1);

                coordenadas = pair.Split(',');
                if (coordenadas.Length != 0)
                {
                    double.TryParse(coordenadas[0], out num1);
                    double.TryParse(coordenadas[1], out num2);

                    x[x.Length - 1] = num1;
                    y1[y1.Length - 1] = num2;
                }
                else
                {
                    Console.WriteLine("Não existem ponto");
                }
            }
            conjunto[0] = x;
            conjunto[1] = y1;

            return conjunto;
        }
    }
}
