using ArchitectureSkeleton.Contract.Fluent.Cell;

namespace ArchitectureSkeleton.Contract.Fluent
{
    public interface IUpdate<MainTable> : IConditional<MainTable>
    {
        IUpdate<MainTable> Set(string arg);
    }
}
