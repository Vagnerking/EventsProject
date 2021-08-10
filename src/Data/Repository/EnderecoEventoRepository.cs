using Business.Interfaces;
using Business.Models;
using Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class EnderecoEventoRepository : Repository<EnderecoEvento>, IEnderecoEventoRepository
    {

        public EnderecoEventoRepository(MeuDbContext context) : base(context) { }

        public async Task<EnderecoEvento> ObterEnderecoPorEvento(Guid eventoId)
        {
            return await _dbSet.AsNoTracking()
                .FirstOrDefaultAsync(e => e.EventoId == eventoId);
        }
    }
}
