using LINQ.ApplicationLayer.Services.CustomerService;
using LINQ.DomainLayer.DTO.Entities;
using LINQ.DomainLayer.DTO.Responses;
using Microsoft.AspNetCore.Mvc;

namespace LINQ.WebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        // Instantiate the Service
        private readonly ICustomerService _service;

        public CustomerController(ICustomerService service)
        {
            _service = service;
        }

        // GET: api/Customer/Get/1
        [HttpGet("{CustomerID}")]
        public Response<CustomerEntity> Get(int CustomerID)
        {
            return _service.Get(CustomerID);
        }

        // GET: api/Customer/GetAll
        [HttpGet]
        public Response<IList<CustomerEntity>> GetAll()
        {
            return _service.GetAll();
        }

        // POST api/Customer/Insert
        [HttpPost]
        public Response<int> Insert([FromBody] CustomerEntity entity)
        {
            return _service.Insert(entity);
        }

        // PUT api/Customer/Update
        [HttpPut]
        public Response<int> Update([FromBody] CustomerEntity entity)
        {
            return _service.Update(entity);
        }

        // DELETE api/Customer/Delete/1
        [HttpDelete("{CustomerID}")]
        public Response<int> Delete(int CustomerID)
        {
            return _service.Delete(CustomerID);
        }
    }
}