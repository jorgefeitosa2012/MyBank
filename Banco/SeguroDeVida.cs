using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    class SeguroDeVida : ITributavel
    {

        private const double VALOR_SEGURO = 42;

        public double CalculaTributos()
        {
            return VALOR_SEGURO;
        }
    }
}
