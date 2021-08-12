using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TesteSoftplan.Data
{
    public class Juros
    {
        public decimal valorJuros { get => 0.01M; }
        public decimal valorInicial { get; set; }
        public int Meses { get; set; }
    }
}
