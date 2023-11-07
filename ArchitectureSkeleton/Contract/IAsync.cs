namespace ArchitectureSkeleton.Contract
{
    public interface IAsync<T> where T : class
    {
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
}
