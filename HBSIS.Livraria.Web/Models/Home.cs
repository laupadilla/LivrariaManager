using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HBSIS.Livraria.Service.Util;

namespace HBSIS.Livraria.Web.Models
{
    public class Home
    {
        public object Save(Repository.Livro item)
        {
            var errors = this.Validate(item);

            if (errors.Count <= 0)
            {
                item.AtualizacaoFormatado = item.Atualizacao.ToString("dd/MM/yyyy");
                item.DataPublicacaoFormatado = item.DataPublicacao.ToString("dd/MM/yyyy");

                if (item.Id <= 0)
                {
                    item.Criacao = LocalDate.Now;
                    item.Atualizacao = item.Criacao;
                    item.CriacaoFormatado = item.Criacao.ToString("dd/MM/yyyy");

                    item.Add();
                }
                else
                {
                    item.Criacao = Convert.ToDateTime(item.CriacaoFormatado);
                    item.Atualizacao = LocalDate.Now;

                    item.Edit();
                }
                                
            }

            return new
            {
                data = item,
                errors
            };
        }

        public static void Delete(int Id)
        {
            Repository.Livro.Delete(Id);
        }

        private List<string> Validate(Repository.Livro item)
        {
            List<string> errors = new List<string>();

            if (string.IsNullOrWhiteSpace(item.Titulo))
                errors.Add("O Título do Livro é obrigatório");

            if (string.IsNullOrWhiteSpace(item.Autor))
                errors.Add("O Autor do Livro é obrigatório");

            if (string.IsNullOrWhiteSpace(item.Editora))
                errors.Add("A Editora do Livro é obrigatório");

            if (item.DataPublicacao < new DateTime(1900, 01, 01) || item.DataPublicacao > new DateTime(9999, 01, 01))
                errors.Add("A Data de Publicação está inválida");

            return errors;
        }
    }
}