using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volta.Ciclistas
{
    public class DiretorDesportivo
    {
        public int UciId { get; set; }
        public string Nome { get; set; }
        public string Nacionalidade { get; set; }
        public DateTime? DataNascimento { get; set; }
    }
}
