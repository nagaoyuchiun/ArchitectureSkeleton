using ArchitectureSkeleton.Contract.Fluent.Cell;

namespace ArchitectureSkeleton.Contract.Fluent
{
    public interface ISqlUpdate<MainTable> : IConditional<MainTable>, IAlias<MainTable>
    {
        ISqlUpdate<MainTable> Set(string arg);
    }
}
