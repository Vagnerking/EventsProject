using Business.Interfaces;
using Business.Models;
using Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class ClienteRepository : Repository<Cliente>, IClienteRepository
    {

        public ClienteRepository(MeuDbContext db) : base(db) { }

        public async Task<Cliente> ObterClienteEventos(Guid id)
        {
            return await _dbSet
                .Include(x => x.Eventos)
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Cliente> ObterClienteEndereco(Guid id)
        {
            return await _dbSet
                .Include(x => x.Endereco)
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Cliente> ObterClienteCompleto(Guid id)
        {
            return await _dbSet
                .Include(x => x.Eventos)
                .Include(x => x.Endereco)
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<IEnumerable<Cliente>> ObterClientesAtivos()
        {
            return await _dbSet
                .Where(x => x.Ativo == true)
                .ToListAsync();
        }

        public async Task<IEnumerable<Cliente>> ObterClientesDesativados()
        {
            return await _dbSet
                .Where(x => x.Ativo == false)
                .ToListAsync();
        }

        public async Task<IEnumerable<Cliente>> ObterClientesEventos()
        {
            return await _dbSet
                .Include(x => x.Eventos)
                .ToListAsync();
        }

        public async Task<IEnumerable<Cliente>> ObterClientesCompletos()
        {
            return await _dbSet
                .Include(x => x.Eventos)
                .Include(x => x.Endereco)
                .ToListAsync();
        }
    }
}
