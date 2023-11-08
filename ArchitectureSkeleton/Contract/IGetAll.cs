namespace ArchitectureSkeleton.Contract
{
    public interface IGetAll<T> where T : class
    {
        /// <summary>
        /// 取得全部資料
        /// </summary>
        /// <returns></returns>
        IEnumerable<T> GetAll();

        /// <summary>
        /// 取得全部資料
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<T>> GetAllAsync();
    }
}
