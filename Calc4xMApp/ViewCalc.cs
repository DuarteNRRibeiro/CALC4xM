using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc4xMApp
{
    public class ViewCalc
    {
        private FormCalc janelaCalculadora;

        private string novoEstado = null;

        public event System.EventHandler<string> UtilizadorClicouNumBotaoDaCalculadora;

        public delegate string SolicitacaoAtualizarEstadoCalculadora();
        public event SolicitacaoAtualizarEstadoCalculadora SolicitarNovoEstadoCalculadora;

        public ViewCalc()
        {
            janelaCalculadora = new FormCalc();
        }

        public void AtivarViewCalc()
        {
            janelaCalculadora = new FormCalc();
            janelaCalculadora.ViewCalc = this;
            janelaCalculadora.ShowDialog();
        }

        public void CliqueNumBotaoDaCalculadora (string textoBotao)
        {
            UtilizadorClicouNumBotaoDaCalculadora(this, textoBotao);
        }

        public void AtualizarEstadoCalculadora()
        {
            Console.WriteLine("A atualizar estado da Calculadora");
            novoEstado = SolicitarNovoEstadoCalculadora();
            AtualizarVisorCalculadora(novoEstado);
        }

        public void AtualizarVisorCalculadora(String novoEstado)
        {
            janelaCalculadora.AtualizarVisor(novoEstado);
        }
    }
}
