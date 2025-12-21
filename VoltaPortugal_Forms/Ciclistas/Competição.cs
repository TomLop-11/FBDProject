using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoltaPortugal_Forms.Ciclistas
{
    public class Competição
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string organizador { get; set; }
        public int num_etapas { get; set; } // número de etapas
        public DateTime? datainicio { get; set; }
        public DateTime? datafim { get; set; }
    }
}
