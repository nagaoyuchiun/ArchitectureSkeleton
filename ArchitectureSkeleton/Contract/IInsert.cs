namespace ArchitectureSkeleton.Contract
{
    public interface IInsert<T> where T : class
    {
        /// <summary>
        /// 新增資料
        /// </summary>
        /// <param name="entity">預計新增資料</param>
        /// <returns>新增後資料</returns>
        T Insert(T entity);

        /// <summary>
        /// 新增資料
        /// </summary>
        /// <param name="entity">預計新增資料</param>
        /// <returns>新增後資料</returns>
        Task<T> InsertAsync(T entity);
    }
}
