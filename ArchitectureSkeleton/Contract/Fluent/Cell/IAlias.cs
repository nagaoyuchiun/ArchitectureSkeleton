namespace ArchitectureSkeleton.Contract.Fluent.Cell
{
    public interface IAlias<MainTable>
    {
        IAlias<MainTable> Alias(string arg);
    }
}
