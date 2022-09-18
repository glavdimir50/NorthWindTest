using System;
using System.Collections.Generic;
using System.Text;

namespace NorthWindTest.DataAccess.Interfaces
{
    public interface IGenericRepository<TEntity>
    {
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="entity"></param>
        void Create(TEntity entity);

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="predicate"></param>
        /// <param name="entity"></param>
        void Update(TEntity entity);

        /// <summary>
        /// 刪除
        /// </summary>
        /// <param name="entity"></param>
        void Delete(TEntity entity);

        /// <summary>
        /// 全部查詢
        /// </summary>
        /// <returns></returns>
        IEnumerable<TEntity> Filter();

        /// <summary>
        /// 條件查詢
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        IEnumerable<TEntity> Filter(Func<TEntity, bool> predicate);
    }
}
