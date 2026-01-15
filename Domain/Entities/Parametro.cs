using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Parametro
    {
        public int PK_Parametro { get; set; }
        public int FK_Ambiente { get; set; }
        public string Descricao { get; set; }
        public string StringConexao { get; set; }
    }
}
