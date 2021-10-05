using fabiostefani.io.Business.Models;
using System;
using System.Threading.Tasks;

namespace fabiostefani.io.Business.Interfaces
{
    public interface IEnderecoRepository : IRepository<Endereco>
    {
        Task<Endereco> ObterEnderecoPorFornecedor(Guid fornecedorId);
    }
}
