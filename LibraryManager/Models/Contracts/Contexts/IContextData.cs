using LibraryManager.Models.Dtos;

namespace LibraryManager.Models.Contracts.Contexts
{
    public interface IContextData
    {

        void CadastrarLivro(LivroDto livro);
        List<LivroDto> ListarLivro();

        LivroDto PesquisarLivroPorId(string id);

        void AtualizarLivro(LivroDto livro);

        void ExcluirLivro(string id);

    }
}
