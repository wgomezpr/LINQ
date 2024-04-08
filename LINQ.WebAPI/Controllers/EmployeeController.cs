using LINQ.ApplicationLayer.Services.EmployeeService;
using LINQ.DomainLayer.DTO.Entities;
using LINQ.DomainLayer.DTO.Responses;
using Microsoft.AspNetCore.Mvc;

namespace LINQ.WebAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        // Instantiate the Service
        private readonly IEmployeeService _service;

        public EmployeeController(IEmployeeService service)
        {
            _service = service;
        }

        // GET: api/Employee/Get/1
        [HttpGet("{EmployeeID}")]
        public Response<EmployeeEntity> Get(int EmployeeID)
        {
            return _service.Get(EmployeeID);
        }

        // GET: api/Employee/GetAll
        [HttpGet]
        public Response<IList<EmployeeEntity>> GetAll()
        {
            return _service.GetAll();
        }

        // POST api/Employee/Insert
        [HttpPost]
        public Response<int> Insert([FromBody] EmployeeEntity entity)
        {
            return _service.Insert(entity);
        }

        // PUT api/Employee/Update
        [HttpPut]
        public Response<int> Update([FromBody] EmployeeEntity entity)
        {
            return _service.Update(entity);
        }

        // DELETE api/Employee/Delete/1
        [HttpDelete("{EmployeeID}")]
        public Response<int> Delete(int EmployeeID)
        {
            return _service.Delete(EmployeeID);
        }
    }
}