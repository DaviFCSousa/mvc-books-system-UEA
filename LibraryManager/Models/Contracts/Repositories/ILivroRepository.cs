using LibraryManager.Models.Dtos;

namespace LibraryManager.Models.Contracts.Repositories
{
    public interface ILivroRepository
    {
        void Cadastrar(LivroDto livro);
        List<LivroDto> Listar();

        LivroDto PesquisarPorId(string id);

        void Atualizar(LivroDto livro);

        void Excluir(string id);
    }
}
