using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;


namespace Flowaccount.Data.Handlers
{

    public interface IEntity
    {
        DateTime CreatedOn { get; set; }
        DateTime ModifiedOn { get; set; }
        bool IsDelete { get; set; }
    }

    public enum ActionModes
    {
        Create,
        Update,
        Delete
    }
    public class DbRepository<T> : IRepository<T> where T : class, IEntity
    {
        protected AppDbContext _context;
        public AppDbContext Context() { return _context; }

        public DbRepository(AppDbContext context)
        {
            _context = context;
        }

        public List<T> Get()
        {
            return _get(predicate: null);
        }

        public List<T> Get(Expression<Func<T, bool>> predicate)
        {
            return _get(predicate: predicate);
        }

        public List<T> Get(params Expression<Func<T, object>>[] navigationPropertyPaths)
        {
            return _get(predicate: null, navigationPropertyPaths: navigationPropertyPaths);
        }

        public List<T> Get(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] navigationPropertyPaths)
        {
            return _get(predicate: predicate, navigationPropertyPaths: navigationPropertyPaths);
        }

        public int Remove(params T[] entities)
        {
            _context.RemoveRange(entities);
            int rowAffected = _context.SaveChanges();
            return rowAffected;
        }
        public int Save(ActionModes actionMode, params T[] entities)
        {
            int rowAffected = 0;
            using (var trans = ((DbContext)_context).Database.BeginTransaction())
            {
                foreach (T _item in entities)
                {
                    switch (actionMode)
                    {
                        case ActionModes.Create:

                            if (_item is IEntity)
                            {
                                ((IEntity)_item).CreatedOn = DateTime.Now;
                                ((IEntity)_item).ModifiedOn = DateTime.Now;
                                ((IEntity)_item).IsDelete = false;
                            }

                            ((DbContext)_context).Set<T>().Add(_item);
                            break;
                        case ActionModes.Update:
                            if (_item is IEntity)
                            {
                                ((IEntity)_item).ModifiedOn = DateTime.Now;
                            }
                            ((DbContext)_context).Entry(_item);
                            ((DbContext)_context).Entry(_item).State = EntityState.Modified;
                            break;
                        case ActionModes.Delete:
                            if (_item is IEntity)
                            {
                                ((IEntity)_item).ModifiedOn = DateTime.Now;
                                ((IEntity)_item).IsDelete = true;
                            }
                            ((DbContext)_context).Entry(_item);
                            ((DbContext)_context).Entry(_item).State = EntityState.Modified;
                            break;
                    }
                }
                try
                {

                    rowAffected = ((DbContext)_context).SaveChanges();
                    trans.Commit();
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    throw ex;
                }
            }
            return rowAffected;
        }


        private List<T> _get(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] navigationPropertyPaths)
        {
            IQueryable<T> _dbset = ((DbContext)_context).Set<T>();
            foreach (Expression<Func<T, object>> navigationProperty in navigationPropertyPaths)
            {
                _dbset = _dbset.Include(navigationProperty);
            }

            if (predicate == null)
                return _dbset.AsNoTracking().ToList();
            else
                return _dbset.AsNoTracking().Where(predicate).ToList();
        }

      
    }

}
