using Gerenciador.Entregas.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Entregas.Dominio.Core.Repository
{
    public interface IRepository<T> : IDisposable where T : Entity
    {
        Task Adicionar(T entity);
        Task Editar(T entity);
        Task Remover(Guid id);
        Task<List<T>> ObterTodos();
        Task<T> ObterPorId(Guid id);
        Task<IEnumerable<T>> Buscar(Expression<Func<T, bool>> predicate);
        Task<int> Salvar();
    }
}
