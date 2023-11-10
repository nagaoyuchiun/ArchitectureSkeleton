using ArchitectureSkeleton.Fluent.Contract.Cell;

namespace ArchitectureSkeleton.Fluent.Contract
{
    public interface ISqlDelete<MainTable> : IConditional<MainTable>, IAlias<MainTable>
    {
        ISqlDelete<MainTable> Target(string arg);
    }
}
