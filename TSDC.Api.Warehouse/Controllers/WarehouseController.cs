using Microsoft.AspNetCore.Mvc;
using TSDC.ApiHelper;
using TSDC.Service.Warehouse;

namespace TSDC.Api.Warehouse.Controllers
{
    [Route("warehouse")]
    [ApiController]
    public class WarehouseController : ControllerBase
    {
        #region Fields
        private readonly IWarehouseService _warehouseService;
        #endregion

        #region Ctor
        public WarehouseController(
            IWarehouseService warehouseService)
        {
            _warehouseService = warehouseService;
        }
        #endregion

        #region Methods
        [Route("create")]
        [HttpPost]
        public async Task<IActionResult> Create(Core.Domain.Warehouse.Warehouse entity)
        {
            if (await _warehouseService.ExistsAsync(entity.Code))
            {
                return Ok(new BaseResult<object>
                {
                    Status = false,
                    Message = "Kho đã tồn tại!"
                });
            }

            await _warehouseService.InsertAsync(entity);

            return Ok(new BaseResult<Core.Domain.Warehouse.Warehouse>
            {
                Status = true,
                Data = entity
            });
        }
        #endregion

        #region List

        #endregion
    }
}
