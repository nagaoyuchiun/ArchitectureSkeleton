namespace ArchitectureSkeleton.Fluent.Contract.Cell
{
    public interface IAlias<MainTable>
    {
        IAlias<MainTable> Alias(string arg);
    }
}
