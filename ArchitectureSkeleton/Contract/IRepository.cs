﻿using System.Threading.Tasks;

namespace ArchitectureSkeleton.Contract
{
    public interface IRepository<T> where T : class
    {
        void BeginTransaction();

        void CommitTransaction();

        void RollbackTransaction();

        /// <summary>
        /// 取得全部資料
        /// </summary>
        /// <returns></returns>
        IEnumerable<T> GetAll();

        /// <summary>
        /// 取得單一資料
        /// </summary>
        /// <param name="id">資料表主鍵</param>
        /// <returns></returns>
        T Get(long id);

        /// <summary>
        /// 新增資料
        /// </summary>
        /// <param name="entity">預計新增資料</param>
        /// <returns>新增後資料</returns>
        T Insert(T entity);

        /// <summary>
        /// 更新資料
        /// </summary>
        /// <param name="entity">預計更新資料</param>
        /// <returns>
        /// RepositoryActionResult.DataBefore=更新前資料
        /// RepositoryActionResult.After=更新後資料
        /// </returns>
        RepositoryActionResult<T> Update(T entity);

        /// <summary>
        /// 刪除資料
        /// </summary>
        /// <param name="id">資料表主鍵</param>
        /// <returns>刪除前資料</returns>
        T Delete(long id);

        /// <summary>
        /// 取得全部資料
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<T>> GetAllAsync();

        /// <summary>
        /// 取得單一資料
        /// </summary>
        /// <param name="id">資料表主鍵</param>
        /// <returns></returns>
        Task<T> GetAsync(long id);

        /// <summary>
        /// 新增資料
        /// </summary>
        /// <param name="entity">預計新增資料</param>
        /// <returns>新增後資料</returns>
        Task<T> InsertAsync(T entity);

        /// <summary>
        /// 更新資料
        /// </summary>
        /// <param name="entity">預計更新資料</param>
        /// <returns>
        /// RepositoryActionResult.DataBefore=更新前資料
        /// RepositoryActionResult.After=更新後資料
        /// </returns>
        Task<RepositoryActionResult<T>> UpdateAsync(T entity);

        /// <summary>
        /// 刪除資料
        /// </summary>
        /// <param name="id">資料表主鍵</param>
        /// <returns>刪除前資料</returns>
        Task<T> DeleteAsync(long id);
    }

    public class RepositoryActionResult<T>
    {
        public required T DataBefore { get; set; }
        public required T DataAfter { get; set; }
    }
}