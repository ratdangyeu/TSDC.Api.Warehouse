using Microsoft.EntityFrameworkCore;
using PagedList.Core;
using TSDC.Core.Domain.Warehouse;

namespace TSDC.Service.Warehouse
{
    public class WarehouseService : IWarehouseService
    {
        #region Fields
        private readonly WarehouseContext _warehouseContext;
        #endregion

        #region Ctor
        public WarehouseService(
            WarehouseContext warehouseContext)
        {
            _warehouseContext = warehouseContext;
        }
        #endregion

        #region Methods
        public async Task InsertAsync(Core.Domain.Warehouse.Warehouse entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }

            await _warehouseContext.Warehouse.AddAsync(entity);
            _warehouseContext.SaveChanges();
        }

        public Task UpdateAsync(Core.Domain.Warehouse.Warehouse entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Core.Domain.Warehouse.Warehouse entity)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> ExistsAsync(string code)
        {
            if (string.IsNullOrEmpty(code))
            {
                throw new ArgumentNullException(nameof(code));
            }

            return await _warehouseContext.Warehouse.AnyAsync(
                x => x.Code != null &&
                     x.Code.Equals(code));
        }

        public async Task<Core.Domain.Warehouse.Warehouse> GetByIdAsync(int id)
        {
            if (id == 0)
            {
                throw new ArgumentNullException(nameof(id));
            }

            var result = await _warehouseContext.Warehouse.FirstOrDefaultAsync(x => x.Id == id);

            return result;
        }
        #endregion

        #region List
        public IPagedList<Core.Domain.Warehouse.Warehouse> Get(WarehouseSearchContext ctx)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
