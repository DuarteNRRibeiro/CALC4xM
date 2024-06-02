using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Calc4xMApp
{
    public class ExceptionOperacaoInvalida : Exception
    {
        public ExceptionOperacaoInvalida() : base("Operação Inválida!") { }
        public ExceptionOperacaoInvalida(string message) : base(message) { }
        public ExceptionOperacaoInvalida(string message, Exception innerException) : base(message, innerException) { }

        protected ExceptionOperacaoInvalida(SerializationInfo info, StreamingContext context) : base(info, context) { }

    }
}
