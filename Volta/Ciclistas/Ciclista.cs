using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volta.Ciclistas
{
    public class Ciclista
    {
        public int UciId { get; set; }
        public int NumDorsal { get; set; }
        public string Nome { get; set; }
        public string Nacionalidade { get; set; }
        public DateTime? DataNascimento { get; set; }
        public string nome_equipa { get; set; }
        public string Categoria { get; set; }
        public string Camisola { get; set; }

    }
}
