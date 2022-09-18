using NorthWindTest.DataAccess.Interfaces;
using NorthWindTest.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NorthWindTest.DataAccess.Classes
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity>, IDisposable
        where TEntity : class
    {
        private readonly NorthwindContext _context;
        public GenericRepository(NorthwindContext context) => _context = context;

        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="entity"></param>
        public void Create(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
            _context.SaveChanges();
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="entity"></param>
        public void Update(TEntity entity)
        {
            _context.Update(entity);
            _context.SaveChanges();
        }

        /// <summary>
        /// 刪除
        /// </summary>
        /// <param name="entity"></param>
        public void Delete(TEntity entity)
        {
            _context.Set<TEntity>().Remove(entity);
            _context.SaveChanges();
        }

        /// <summary>
        /// 全部查詢
        /// </summary>
        /// <returns></returns>
        public IEnumerable<TEntity> Filter()
        {
            return _context.Set<TEntity>();
        }

        /// <summary>
        /// 條件查詢
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public IEnumerable<TEntity> Filter(Func<TEntity, bool> predicate)
        {
            return _context.Set<TEntity>().Where(predicate);
        }

        public void Dispose()
        {
            if (_context != null)
            {
                _context.Dispose();
            }
        }
    }
}
