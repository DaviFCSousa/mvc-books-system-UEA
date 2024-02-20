using LibraryManager.Models.Dtos;

namespace LibraryManager.Models.Contracts.Services
{
    public interface ILivroService
    {

        void Cadastrar(LivroDto livro);
        List<LivroDto> Listar();
        LivroDto PesquisarPorId(string id);

        void Atualizar(LivroDto livro);

        void Excluir(string id);

    }
}
