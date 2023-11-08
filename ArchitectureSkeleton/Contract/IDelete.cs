namespace ArchitectureSkeleton.Contract
{
    public interface IDelete<T> where T : class
    {
        /// <summary>
        /// 刪除資料
        /// </summary>
        /// <param name="id">資料表主鍵</param>
        /// <returns>刪除前資料</returns>
        T Delete(long id);

        /// <summary>
        /// 刪除資料
        /// </summary>
        /// <param name="id">資料表主鍵</param>
        /// <returns>刪除前資料</returns>
        Task<T> DeleteAsync(long id);
    }
}
