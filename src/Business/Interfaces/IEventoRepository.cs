using Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface IEventoRepository : IRepository<Evento>
    {

        Task<IEnumerable<Evento>> ObterEventosDoCliente(Guid idCliente);

        Task<IEnumerable<Evento>> ObterTodosEventosECliente();

        Task<Evento> ObterEvento(Guid idEvento);

        Task<Evento> ObterEventoEndereco(Guid idEvento);

        Task<Evento> ObterEventoEnderecoCliente(Guid idEvento);

    }
}
