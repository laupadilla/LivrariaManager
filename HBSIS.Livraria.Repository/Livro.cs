using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace HBSIS.Livraria.Repository
{
    public class Livro
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Valor { get; set; }
        public DateTime DataPublicacao { get; set; }
        public int AutorId { get; set; }
        public int EditoraId { get; set; }
        public DateTime Criacao { get; set; }
        public DateTime Atualizacao { get; set; }
        public string DataPublicacaoFormatado { get; set; }
        public string CriacaoFormatado { get; set; }
        public string AtualizacaoFormatado { get; set; }

        public static List<Livro> List()
        {
            string sql = @"
            Select
                [Id],
                [Titulo],
                [Valor],
                Convert(Varchar,[DataPublicacao],103) as [DataPublicacaoFormatado],
                [AutorId],
                [EditoraId],
                Convert(Varchar,[Criacao],103) as [CriacaoFormatado],
                Convert(Varchar,[Atualizacao],103) as [AtualizacaoFormatado]
            From
	            Livro;";
            using (var db = new Context())
                return db.Connection.Query<Livro>(sql).ToList();
        }
    }
}
