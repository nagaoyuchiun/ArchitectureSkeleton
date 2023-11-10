using Dapper;

namespace ArchitectureSkeleton.SqlBulid.Contract.Cell
{
    public interface IParam
    {
        void Parameters(DynamicParameters dynamicParameters);

    }
}
