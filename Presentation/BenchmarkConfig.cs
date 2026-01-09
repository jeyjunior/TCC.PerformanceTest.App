using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation
{
    public static class BenchmarkConfig
    {
        public static string ConnectionStringAtual;
        public static int QuantidadeRegistros;
        public static eTipoAmbiente TipoAmbiente; 
    }

    public enum eTipoAmbiente
    {
        OnPremise = 1,
        Cloud = 2,
    }
}
