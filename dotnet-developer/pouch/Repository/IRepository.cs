

using Flowaccount.Data.Handlers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Flowaccount.Data
{

    public interface IRepository<T> where T : class, IEntity
    {
        AppDbContext Context();
        List<T> Get();
        List<T> Get(Expression<Func<T, bool>> predicate);
        List<T> Get(params Expression<Func<T, object>>[] navigationPropertyPaths);
        List<T> Get(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] navigationPropertyPaths);
        int Save(ActionModes actionMode, params T[] entities);
        int Remove(params T[] entities);
    }

}
