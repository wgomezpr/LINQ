using LINQ.ApplicationLayer.Services.OrderService;
using LINQ.DomainLayer.DTO.Entities;
using LINQ.DomainLayer.DTO.Responses;
using Microsoft.AspNetCore.Mvc;

namespace LINQ.WebAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        // Instantiate the Service
        private readonly IOrderService _service;

        public OrderController(IOrderService service)
        {
            _service = service;
        }

        // GET: api/Order/Get/1
        [HttpGet("{OrderID}")]
        public Response<OrderEntity> Get(int OrderID)
        {
            return _service.Get(OrderID);
        }

        // GET: api/Order/GetAll
        [HttpGet]
        public Response<IList<OrderEntity>> GetAll()
        {
            return _service.GetAll();
        }

        // POST api/Order/Insert
        [HttpPost]
        public Response<int> Insert([FromBody] OrderEntity entity)
        {
            return _service.Insert(entity);
        }

        // PUT api/Order/Update
        [HttpPut]
        public Response<int> Update([FromBody] OrderEntity entity)
        {
            return _service.Update(entity);
        }

        // DELETE api/Order/Delete/1
        [HttpDelete("{OrderID}")]
        public Response<int> Delete(int OrderID)
        {
            return _service.Delete(OrderID);
        }
    }
}