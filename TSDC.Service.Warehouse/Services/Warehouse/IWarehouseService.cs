using PagedList.Core;

namespace TSDC.Service.Warehouse
{
    public interface IWarehouseService
    {
        Task InsertAsync(Core.Domain.Warehouse.Warehouse entity);

        Task UpdateAsync(Core.Domain.Warehouse.Warehouse entity);

        Task DeleteAsync(Core.Domain.Warehouse.Warehouse entity);

        Task<bool> ExistsAsync(string code);

        Task<Core.Domain.Warehouse.Warehouse> GetByIdAsync(int id);

        IPagedList<Core.Domain.Warehouse.Warehouse> Get(WarehouseSearchContext ctx);        
    }
}
