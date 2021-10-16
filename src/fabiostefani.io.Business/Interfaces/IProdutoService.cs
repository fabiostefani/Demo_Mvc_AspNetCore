using fabiostefani.io.Business.Models;
using System;
using System.Threading.Tasks;

namespace fabiostefani.io.Business.Interfaces
{
    public interface IProdutoService : IDisposable
    {
        Task Adicionar(Produto produto);
        Task Atualizar(Produto produto);
        Task Remover(Guid id);
    }
}
