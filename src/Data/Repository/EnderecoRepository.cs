using Business.Interfaces;
using Business.Models;
using Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class EnderecoRepository : Repository<Endereco>, IEnderecoRepository
    {

        public EnderecoRepository(MeuDbContext context) : base(context) { }

        public async Task<Endereco> ObterEnderecoPorCliente(Guid clienteId)
        {
            return await _dbSet.AsNoTracking()
                .FirstOrDefaultAsync(e => e.ClienteId == clienteId);
        }
    }
}
