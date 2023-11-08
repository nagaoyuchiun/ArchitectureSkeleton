namespace ArchitectureSkeleton.Contract
{
    public interface IGet<T> where T : class
    {
        /// <summary>
        /// 取得單一資料
        /// </summary>
        /// <param name="id">資料表主鍵</param>
        /// <returns></returns>
        T Get(long id);
        /// 取得單一資料
        /// </summary>
        /// <param name="id">資料表主鍵</param>
        /// <returns></returns>
        Task<T> GetAsync(long id);
    }
}
