using Entregas.Dominio.Core.Repository;
using Gerenciador.Entregas.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Entregas.Data.Repository
{
    public abstract class BaseRepository<T> : IRepository<T> where T : Entity
    {
        public BaseRepository()
        {

        }
        public Task Adicionar(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> Buscar(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Task Editar(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<T> ObterPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<T>> ObterTodos()
        {
            throw new NotImplementedException();
        }

        public Task Remover(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<int> Salvar()
        {
            throw new NotImplementedException();
        }
    }
}
