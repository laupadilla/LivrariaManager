using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HBSIS.Livraria.Repository
{
    public class Estado
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Iniciais { get; set; }
        public DateTime Criacao { get; set; }
        public DateTime Atualizacao { get; set; }
    }
}
