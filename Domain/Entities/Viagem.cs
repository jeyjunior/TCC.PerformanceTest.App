using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Viagem
    {
        public int PK_Viagem { get; set; }
        public string Destino { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public string Observacoes { get; set; }
        public DateTime DataCadastro { get; set; } = DateTime.Now;
    }
}
