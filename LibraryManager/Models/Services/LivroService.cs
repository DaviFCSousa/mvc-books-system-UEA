﻿using LibraryManager.Models.Contracts.Repositories;
using LibraryManager.Models.Contracts.Services;
using LibraryManager.Models.Dtos;

namespace LibraryManager.Models.Contracts.Services
{
    public class LivroService : ILivroService
    {
        private  readonly ILivroRepository _livroRepository;

        public LivroService (ILivroRepository livroRepository)
        {
            _livroRepository  = livroRepository;
        }

        public void Atualizar(LivroDto livro)
        {
            try
            {
                _livroRepository.Atualizar(livro);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Cadastrar(LivroDto livro)
        {
            try
            {
                _livroRepository.Cadastrar(livro);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Excluir(string id)
        {
            try
            {
                _livroRepository.Excluir(id);
            }
            catch (Exception ex) 
            {
                throw ex;

            }
        }

        public List<LivroDto> Listar()
        {
            try
            {
                return _livroRepository.Listar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
           
        }

        public LivroDto PesquisarPorId(string id)
        {
            try
            {
                return _livroRepository.PesquisarPorId(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
