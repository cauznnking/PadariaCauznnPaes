using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadariaCauznnPaes.Classes
{
    public class OrdemComanda
    {
        public int Id { get; set; }

        public int IdFicha { get; set; }

        public int IdProduto { get; set; }

        public int Quantidade { get; set; }

        public int IdResp { get; set; }

        public DateTime DataAdlc { get; set; }

        public int Situacao { get; set; }
    }
}
