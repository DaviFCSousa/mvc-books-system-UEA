using LibraryManager.Models.Contracts.Contexts;
using LibraryManager.Models.Dtos;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace LibraryManager.Models.Contexts
{
    public class ContextDataFake : IContextData
    {
        private static List<LivroDto> livros;

        public ContextDataFake()
        {
            //livros = new List<LivroDto>();
            InitializeData();
        }

        private void InitializeData()
        {
            var livro = new LivroDto("Livro C#", "Douglas Pontes", "Editora Qualquer");
            livros.Add(livro);

            livro = new LivroDto("Livro C++", "Gabigol", "Editora Qualquer");
            livros.Add(livro);

            livro = new LivroDto("Livro JavaScript", "Lionel Messi", "Editora Qualquer");
            livros.Add(livro);


            livro = new LivroDto("Livro Python", "Cristiano Ronaldo", "Editora Qualquer");
            livros.Add(livro);
        }

        public void AtualizarLivro(LivroDto livro)
        {
            try
            {
                var objPesquisa = PesquisarLivroPorId(livro.Id);
                livros.Remove(objPesquisa);

                objPesquisa.Nome = livro.Nome;
                objPesquisa.Editora = livro.Editora;
                objPesquisa.Autor = livro.Autor;

                CadastrarLivro(objPesquisa);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void CadastrarLivro(LivroDto livro)
        {
            try
            {
                livros.Add(livro);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void ExcluirLivro(string id)
        {
            try
            {
                var objPesquisa = PesquisarLivroPorId(id);
                livros.Remove(objPesquisa);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public List<LivroDto> ListarLivro()
        {
            try
            {
                return livros.OrderBy(p => p.Nome).ToList();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public LivroDto PesquisarLivroPorId(string id)
        {
            try
            {
                return livros.FirstOrDefault(p => p.Id == id);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
