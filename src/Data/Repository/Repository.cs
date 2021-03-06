using Business.Interfaces;
using Business.Models;
using Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity, new()
    {

        protected readonly MeuDbContext _db;
        protected readonly DbSet<TEntity> _dbSet;

        public Repository(MeuDbContext db)
        {
            _db = db;
            _dbSet = db.Set<TEntity>();
        }


        public async Task<IEnumerable<TEntity>> Buscar(Expression<Func<TEntity, bool>> predicate)
        {
            return await _dbSet.AsNoTracking().Where(predicate).ToListAsync();
        }

        public async Task<TEntity> ObterPorId(Guid id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task <IEnumerable<TEntity>> ObterTodos()
        {
            return await _dbSet.ToListAsync();
        }


        public async Task Adicionar(TEntity entity)
        {
             _dbSet.Add(entity);
            await SaveChanges();
        }

        public async Task Atualizar(TEntity entity)
        {
            _dbSet.Update(entity);
            await SaveChanges();
        }


        public async Task Remover(Guid id)
        {
            _dbSet.Remove(new TEntity { Id = id});
            await SaveChanges();
        }

        public void Dispose()
        {
            _db?.Dispose();
        }

        public async Task<int> SaveChanges()
        {
            return await _db.SaveChangesAsync();
        }

    }
}
