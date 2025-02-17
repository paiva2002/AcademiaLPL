using AcademiaLPL.Domain.Base;
using AcademiaLPL.Repository.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace AcademiaLPL.Repository.Repository
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : BaseEntity<int>
    {
        protected readonly MySqlContext _mySqlcontext;

        public BaseRepository(MySqlContext mySqlcontext)
        {
            _mySqlcontext = mySqlcontext;
        }

        public void AtachObjetct(object obj)
        {
            _mySqlcontext.Attach(obj);
        }

        public void ClearChangeTracker()
        {
            _mySqlcontext.ChangeTracker.Clear();
        }

        public void Insert(TEntity entity)
        {
            _mySqlcontext.Set<TEntity>().Add(entity);
            _mySqlcontext.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            _mySqlcontext.Entry(entity).State = EntityState.Modified;
            _mySqlcontext.SaveChanges();
        }

        public void Delete(object id)
        {
            _mySqlcontext.Set<TEntity>().Remove(Select(id));
            _mySqlcontext.SaveChanges();
        }

        // Método Select ajustado para aceitar IList<string>
        public IList<TEntity> Select(bool tracking = true, IList<string>? includes = null)
        {
            IQueryable<TEntity> dbContext;
            if (tracking)
            {
                dbContext = _mySqlcontext.Set<TEntity>().AsQueryable();
            }
            else
            {
                dbContext = _mySqlcontext.Set<TEntity>().AsNoTracking().AsQueryable();
            }

            if (includes != null)
            {
                foreach (var include in includes)
                {
                    // Inclui as propriedades de navegação usando Include
                    dbContext = dbContext.Include(include);
                }
            }

            return dbContext.ToList();
        }

        // Método Select por id ajustado para aceitar IList<string>
        public TEntity Select(object id, bool tracking = true, IList<string>? includes = null)
        {
            IQueryable<TEntity> dbContext;
            if (tracking)
            {
                dbContext = _mySqlcontext.Set<TEntity>().AsQueryable();
            }
            else
            {
                dbContext = _mySqlcontext.Set<TEntity>().AsNoTracking().AsQueryable();
            }

            if (includes != null)
            {
                foreach (var include in includes)
                {
                    dbContext = dbContext.Include(include);
                }
            }

            return dbContext.FirstOrDefault(x => x.Id == (int)id);
        }
    }
}


