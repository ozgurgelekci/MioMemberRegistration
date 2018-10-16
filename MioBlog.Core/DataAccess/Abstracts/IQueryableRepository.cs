using System.Linq;
using MioBlog.Core.Entities;

namespace MioBlog.Core.DataAccess.Abstracts
{
    public interface IQueryableRepository<TEntity> where TEntity : class, IEntity, new()
    {
        IQueryable<TEntity> Table { get; set; }
    }
}
