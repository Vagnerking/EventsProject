using Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface IClienteRepository : IRepository<Cliente>
    {

        Task<Cliente> ObterClienteEventos(Guid id);
        Task<Cliente> ObterClienteEndereco(Guid id);
        Task<Cliente> ObterClienteCompleto(Guid id);
        Task<IEnumerable<Cliente>> ObterClientesAtivos();
        Task<IEnumerable<Cliente>> ObterClientesDesativados();
        Task<IEnumerable<Cliente>> ObterClientesEventos();
        Task<IEnumerable<Cliente>> ObterClientesCompletos();
    }
}
