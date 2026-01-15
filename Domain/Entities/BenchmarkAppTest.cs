using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class BenchmarkAppTest
    {
        public long PK_BenchmarkAppTest { get; set; }
        public string Metodo { get; set; }
        public string Ambiente { get; set; }
        public int QtdRegistros { get; set; }
        public long QtdRegistrosInseridos { get; set; }
        public double TempoMedio_MS { get; set; }
        public double DesvioPadrao_MS { get; set; }
        public long? BytesPorOperacao { get; set; }
        public long BytesTotais { get; set; }
        public string MemoriaKB { get; set; }
        public int GCPassCount { get; set; }
    }
}
