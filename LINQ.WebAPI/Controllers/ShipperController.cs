using LINQ.ApplicationLayer.Services.ShipperService;
using LINQ.DomainLayer.DTO.Entities;
using LINQ.DomainLayer.DTO.Responses;
using Microsoft.AspNetCore.Mvc;

namespace LINQ.WebAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ShipperController : ControllerBase
    {
        // Instantiate the Service
        private readonly IShipperService _service;

        public ShipperController(IShipperService service)
        {
            _service = service;
        }

        // GET: api/Shipper/Get/1
        [HttpGet("{ShipperID}")]
        public Response<ShipperEntity> Get(int ShipperID)
        {
            return _service.Get(ShipperID);
        }

        // GET: api/Shipper/GetAll
        [HttpGet]
        public Response<IList<ShipperEntity>> GetAll()
        {
            return _service.GetAll();
        }

        // POST api/Shipper/Insert
        [HttpPost]
        public Response<int> Insert([FromBody] ShipperEntity entity)
        {
            return _service.Insert(entity);
        }

        // PUT api/Shipper/Update
        [HttpPut]
        public Response<int> Update([FromBody] ShipperEntity entity)
        {
            return _service.Update(entity);
        }

        // DELETE api/Shipper/Delete/1
        [HttpDelete("{ShipperID}")]
        public Response<int> Delete(int ShipperID)
        {
            return _service.Delete(ShipperID);
        }
    }
}