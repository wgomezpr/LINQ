using LINQ.ApplicationLayer.Services.SupplierService;
using LINQ.DomainLayer.DTO.Entities;
using LINQ.DomainLayer.DTO.Responses;
using Microsoft.AspNetCore.Mvc;

namespace LINQ.WebAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class SupplierController : ControllerBase
    {
        // Instantiate the Service
        private readonly ISupplierService _service;

        public SupplierController(ISupplierService service)
        {
            _service = service;
        }

        // GET: api/Supplier/Get/1
        [HttpGet("{SupplierID}")]
        public Response<SupplierEntity> Get(int SupplierID)
        {
            return _service.Get(SupplierID);
        }

        // GET: api/Supplier/GetAll
        [HttpGet]
        public Response<IList<SupplierEntity>> GetAll()
        {
            return _service.GetAll();
        }

        // POST api/Supplier/Insert
        [HttpPost]
        public Response<int> Insert([FromBody] SupplierEntity entity)
        {
            return _service.Insert(entity);
        }

        // PUT api/Supplier/Update
        [HttpPut]
        public Response<int> Update([FromBody] SupplierEntity entity)
        {
            return _service.Update(entity);
        }

        // DELETE api/Supplier/Delete/1
        [HttpDelete("{SupplierID}")]
        public Response<int> Delete(int SupplierID)
        {
            return _service.Delete(SupplierID);
        }
    }
}