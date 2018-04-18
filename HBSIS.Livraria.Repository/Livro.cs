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
        public DateTime DataPublicacao { get; set; }
        public string Autor { get; set; }
        public string Editora { get; set; }
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
                    [DataPublicacao],
                    Convert(Varchar,[DataPublicacao],103) as [DataPublicacaoFormatado],
                    [Autor],
                    [Editora],
                    [Criacao],
                    [Atualizacao],
                    Convert(Varchar,[Criacao],103) as [CriacaoFormatado],
                    Convert(Varchar,[Atualizacao],103) as [AtualizacaoFormatado]
                From
	                Livro
                Order By
                    [Titulo] Asc;";
            using (var db = new Context())
                return db.Connection.Query<Livro>(sql).ToList();
        }

        public void Add()
        {
            string sql = @"
                Insert Into Livro(                    
                    [Titulo],
                    [DataPublicacao],
                    [Autor],
                    [Editora],
                    [Criacao],    
                    [Atualizacao]) Output Inserted.Id
                Values(
                    @Titulo,
                    @DataPublicacao,
                    @Autor,
                    @Editora,
                    @Criacao,
                    @Atualizacao
                    )";
            using (var db = new Context())
                this.Id = db.Connection.Query<int>(sql, this).First();
        }

        public void Edit()
        {
            string sql = @"
                Update
                    Livro
                Set
                    Titulo = @Titulo,
                    DataPublicacao = @DataPublicacao,
                    Autor = @Autor,
                    Editora = @Editora,
                    Criacao = @Criacao, 
                    Atualizacao = @Atualizacao
                Where
                    Id = @Id;";
            using (var db = new Context())
                db.Connection.Execute(sql, this);
        }

        public static void Delete(int id)
        {
            string sql = @"
                Delete From
                    Livro
                Where Id = @Id;";
            using (var db = new Context())
                db.Connection.Execute(sql, new { Id = id });
        }
    }
}
