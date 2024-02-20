using LibraryManager.Models.Contracts.Contexts;
using LibraryManager.Models.Contracts.Repositories;
using LibraryManager.Models.Contracts.Services;
using LibraryManager.Models.Dtos;

namespace LibraryManager.Models.Repositories
{
    public class LivroRepository : ILivroRepository
    {
        private readonly IContextData _contextData;

        public LivroRepository(IContextData contextData)
        {
            _contextData = contextData;
        }

        public void Atualizar(LivroDto livro)
        {
           
            _contextData.AtualizarLivro(livro);
        }

        public void Cadastrar(LivroDto livro)
        {
            _contextData.CadastrarLivro(livro);
        }

        public void Excluir(string id)
        {
            _contextData.ExcluirLivro(id);
        }

        public List<LivroDto> Listar()
        {
         return _contextData.ListarLivro();
        }

        public LivroDto PesquisarPorId(string id)
        {
          return _contextData.PesquisarLivroPorId(id);
        }
    }
}
