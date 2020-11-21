using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenRetailGo.Repository.Api
{
    abstract class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity: class
    {
        public abstract int Delete(TEntity obj);
        public abstract IList<TEntity> GetAll();
        public abstract int Save(TEntity obj);
        public abstract int Update(TEntity obj);
    }
}
