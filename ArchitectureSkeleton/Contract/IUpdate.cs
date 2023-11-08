namespace ArchitectureSkeleton.Contract
{
    public interface IUpdate<T> where T : class
    {
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
        /// 更新資料
        /// </summary>
        /// <param name="entity">預計更新資料</param>
        /// <returns>
        /// RepositoryActionResult.DataBefore=更新前資料
        /// RepositoryActionResult.After=更新後資料
        /// </returns>
        Task<RepositoryActionResult<T>> UpdateAsync(T entity);
    }
}
