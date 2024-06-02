using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc4xMApp
{
    class ModelCalc
    {
        private ICalculadora calculadora;
        private string operador = "";
        private string numeroAtual = "";
        private string numeroAnterior = "";
        private bool operadorSelecionado = false;
        private bool operadorIgual = false;
        private double num = 0;

        public delegate void NotificarAtualizacaoEstadoCalculadora();
        public event NotificarAtualizacaoEstadoCalculadora EstadoCalculadoraAlterado;

        //public delegate void NotificacaoOperacaoInvalida();
        //public event NotificacaoOperacaoInvalida NotificarOperacaoInvalida;

        public ModelCalc()
        {
            calculadora = new Calculadora();
        }

        public void AtualizarEstadoDaCalculadora(String textoBotao)
        {
            try
            {
                //verifica se a entrada é um número
                if (double.TryParse(textoBotao, out num))
                {
                    if (operadorSelecionado)
                    {
                        numeroAnterior = numeroAtual;
                        numeroAtual = textoBotao;
                        operadorSelecionado = false;
                        operadorIgual = false;
                    }
                    //limpar o visor da calculadora caso um numero
                    //seja selecionado depois do igual
                    else if (operadorIgual)
                    {
                        numeroAtual = textoBotao;
                        operadorIgual = false;
                    }
                    else
                    {
                        //Se for um número, adiciona ao visor da calculadora
                        if (numeroAtual.Length == 0 || numeroAtual == "0")
                        {
                            //Se não houver número atualmente substitui por num
                            numeroAtual = textoBotao;
                            //num = double.Parse(textoBotao);
                        }
                        else
                        {
                            //Se já houver um número, concatena o novo ao existente
                            numeroAtual = numeroAtual + textoBotao;
                        }
                    }

                }
                else if (textoBotao == ",")
                {
                    //Tratar a vírgula 
                    if (!numeroAtual.ToString().Contains(","))
                    {
                        numeroAtual = numeroAtual + textoBotao;
                    }
                }
                else if (textoBotao == "√")
                {
                    if (string.IsNullOrEmpty(numeroAtual) || double.Parse(numeroAtual) <= 0)
                        throw new ExceptionOperacaoInvalida();
                    calculadora.Raiz(double.Parse(numeroAtual));
                    numeroAtual = calculadora.Resultado.ToString();
                    operadorSelecionado = true;
                }
                else if (textoBotao == "%")
                {
                    //percetagem
                    if (string.IsNullOrEmpty(numeroAtual) || numeroAtual == "0" || string.IsNullOrEmpty(numeroAnterior))
                        throw new ExceptionOperacaoInvalida();
                    else
                    {
                        if (numeroAnterior != "0")
                        {
                            calculadora.Percetagem(double.Parse(numeroAtual));
                            numeroAtual = calculadora.Resultado.ToString();
                            calculadora.AtualizarResultado(double.Parse(numeroAnterior));
                        }
                        else numeroAtual = "0";
                    }
                }
                else if (textoBotao == "x²")
                {
                    //quadrado
                    if (string.IsNullOrEmpty(numeroAtual) || numeroAtual == "0")
                        throw new ExceptionOperacaoInvalida();
                    calculadora.Quadrado(double.Parse(numeroAtual));
                    numeroAtual = calculadora.Resultado.ToString();
                    operadorSelecionado = true;
                }
                else if (textoBotao == "1/x")
                {
                    //inverso
                    if (string.IsNullOrEmpty(numeroAtual) || numeroAtual == "0")
                        throw new ExceptionOperacaoInvalida();
                    calculadora.Inverso(double.Parse(numeroAtual));
                    numeroAtual = calculadora.Resultado.ToString();
                    operadorSelecionado = true;
                }
                else if (textoBotao == "C")
                {
                    //limpar tudo
                    calculadora.Reset();
                    numeroAtual = "0";
                    numeroAnterior = "";
                    operador = "";
                    operadorSelecionado = false;
                    operadorIgual = false;
                }
                else if (textoBotao == "CE")
                {
                    //limpar a entrada atual
                    numeroAtual = "0";

                }
                else if (textoBotao == "±")
                {
                    if (string.IsNullOrEmpty(numeroAtual) || numeroAtual == "0")
                        throw new ExceptionOperacaoInvalida();
                    calculadora.InverterSinal(double.Parse(numeroAtual));
                    numeroAtual = calculadora.Resultado.ToString();
                    operadorSelecionado = true;
                }
                else if (textoBotao == "⌫")
                {
                    // Apagar o último algarismo (delete)
                    if (numeroAtual.Length > 0)
                    {
                        numeroAtual = numeroAtual.Remove(numeroAtual.Length - 1);
                    }
                }
                else if (textoBotao == "=")
                {
                    //Se for "=", calcula o resultado final
                    CalcularResultado();
                    operador = "";
                    numeroAnterior = "";
                    //operadorSelecionado = false;
                    operadorIgual = true;
                }
                else
                {
                    if (operador != "")
                        CalcularResultado();
                    operador = textoBotao;
                    operadorSelecionado = true;
                    calculadora.AtualizarResultado(double.Parse(numeroAtual));
                    //numeroAtual = "0";
                }
            }
            catch (ExceptionOperacaoInvalida)
            {
                numeroAtual = "Operação Inválida!";
            }
            EstadoCalculadoraAlterado();
        }

        public string NovoEstadoCalculadora()
        {
            return numeroAtual;
        }

        private void CalcularResultado()
        {
            try
            {
                switch (operador)
                {
                    case "+":
                        calculadora.Adicionar(double.Parse(numeroAtual));
                        break;
                    case "-":
                        calculadora.Subtrair(double.Parse(numeroAtual));
                        break;
                    case "x":
                        calculadora.Multiplicar(double.Parse(numeroAtual));
                        break;
                    case "÷":
                        calculadora.Dividir(double.Parse(numeroAtual));
                        break;
                }
                // Atualiza o valor de numeroAtual com o resultado calculado
                numeroAtual = calculadora.Resultado.ToString();
                //operadorSelecionado = true;
            }
            catch (ExceptionOperacaoInvalida)
            {
                numeroAtual = "Não é possível dividir por 0!";
            }
        }
    }
}
