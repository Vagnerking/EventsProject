using Business.Interfaces;
using Business.Models;
using Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class EventoRepository : Repository<Evento>, IEventoRepository
    {

        public EventoRepository(MeuDbContext db) : base(db) { }

        public async Task<Evento> ObterEvento(Guid idEvento)
        {
            return await _dbSet.FirstOrDefaultAsync(x => x.Id == idEvento);
        }

        public async Task<Evento> ObterEventoEndereco(Guid idEvento)
        {
            return await _dbSet.Include(x => x.Endereco)
                .FirstOrDefaultAsync(x => x.Id == idEvento);
        }

        public async Task<Evento> ObterEventoEnderecoCliente(Guid idEvento)
        {
            return await _dbSet.Include(x => x.Endereco)
                         .Include(x => x.Cliente)
                         .FirstOrDefaultAsync(x => x.Id == idEvento);
        }

        public async Task<IEnumerable<Evento>> ObterEventosDoCliente(Guid idCliente)
        {
            return await _dbSet.Where(x => x.ClienteId == idCliente).ToListAsync();
        }

        public async Task<IEnumerable<Evento>> ObterTodosEventosECliente()
        {
            return await _dbSet.Include(x => x.Cliente).ToListAsync();
        }
    }
}
