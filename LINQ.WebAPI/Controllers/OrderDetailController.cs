using LINQ.ApplicationLayer.Services.OrderDetailService;
using LINQ.DomainLayer.DTO.Entities;
using LINQ.DomainLayer.DTO.Responses;
using Microsoft.AspNetCore.Mvc;

namespace LINQ.WebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class OrderDetailController : ControllerBase
    {
        // Instantiate the Service
        private readonly IOrderDetailService _service;

        public OrderDetailController(IOrderDetailService service)
        {
            _service = service;
        }

        // GET: api/OrderDetail/Get/1
        [HttpGet("{OrderID}")]
        public Response<OrderDetailEntity> Get(int OrderID)
        {
            return _service.Get(OrderID);
        }

        // GET: api/OrderDetail/GetAll
        [HttpGet]
        public Response<IList<OrderDetailEntity>> GetAll()
        {
            return _service.GetAll();
        }

        // POST api/OrderDetail/Insert
        [HttpPost]
        public Response<int> Insert([FromBody] OrderDetailEntity entity)
        {
            return _service.Insert(entity);
        }

        // PUT api/OrderDetail/Update
        [HttpPut]
        public Response<int> Update([FromBody] OrderDetailEntity entity)
        {
            return _service.Update(entity);
        }

        // DELETE api/OrderDetail/Delete/1
        [HttpDelete("{OrderID}")]
        public Response<int> Delete(int OrderID)
        {
            return _service.Delete(OrderID);
        }
    }
}