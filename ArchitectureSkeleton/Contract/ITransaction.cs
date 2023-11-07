namespace ArchitectureSkeleton.Contract
{
    public interface ITransaction
    {
        void BeginTransaction();

        void CommitTransaction();

        void RollbackTransaction();
    }
}
