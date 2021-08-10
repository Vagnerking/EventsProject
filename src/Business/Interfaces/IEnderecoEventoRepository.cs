using Business.Models;
using System;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface IEnderecoEventoRepository : IRepository<EnderecoEvento>
    {

        Task<EnderecoEvento> ObterEnderecoPorEvento(Guid eventoId);

    }
}
