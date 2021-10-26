using Entregas.Data.Context;
using Entregas.Dominio.Core.Repository;
using Gerenciador.Entregas.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Entregas.Data.Repository
{
    public abstract class BaseRepository<T> : IRepository<T> where T : Entity, new()
    {
        protected readonly EntregasContext Db;
        protected readonly DbSet<T> DbSet;

        public BaseRepository(EntregasContext db)
        {
            Db = db;
            DbSet = db.Set<T>();
        }

        public virtual async Task<T> ObterPorId(Guid id)
        {
            return await DbSet.FindAsync(id);
        }

        public virtual async Task<List<T>> ObterTodos()
        {
            return await DbSet.ToListAsync();
        }

        public virtual async Task Adicionar(T entity)
        {
            DbSet.Add(entity);
            await Salvar();
        }

        public virtual async Task<IEnumerable<T>> Buscar(Expression<Func<T, bool>> predicate)
        {
            return await DbSet.AsNoTracking().Where(predicate).ToListAsync();
        }

        public virtual async Task Editar(T entity)
        {
            DbSet.Add(entity);
            await Salvar();
        }

        public virtual async Task Remover(Guid id)
        {
            DbSet.Remove(new T { Id = id });
            await Salvar();
        }

        public async Task<int> Salvar()
        {
            return await Db.SaveChangesAsync();
        }

        public void Dispose()
        {
            Db?.Dispose();
        }
    }
}
