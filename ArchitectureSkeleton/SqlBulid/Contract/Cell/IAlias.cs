namespace ArchitectureSkeleton.SqlBulid.Contract.Cell
{
    public interface IAlias<MainTable>
    {
        IAlias<MainTable> Alias(string arg);
    }
}
