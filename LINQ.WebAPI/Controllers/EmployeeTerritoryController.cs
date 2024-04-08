using LINQ.ApplicationLayer.Services.EmployeeTerritoryService;
using LINQ.DomainLayer.DTO.Entities;
using LINQ.DomainLayer.DTO.Responses;
using Microsoft.AspNetCore.Mvc;

namespace LINQ.WebAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class EmployeeTerritoryController : ControllerBase
    {
        // Instantiate the Service
        private readonly IEmployeeTerritoryService _service;

        public EmployeeTerritoryController(IEmployeeTerritoryService service)
        {
            _service = service;
        }

        // GET: api/EmployeeTerritory/Get/1
        [HttpGet("{EmployeeID}")]
        public Response<EmployeeTerritoryEntity> Get(int EmployeeID)
        {
            return _service.Get(EmployeeID);
        }

        // GET: api/EmployeeTerritory/GetAll
        [HttpGet]
        public Response<IList<EmployeeTerritoryEntity>> GetAll()
        {
            return _service.GetAll();
        }

        // POST api/EmployeeTerritory/Insert
        [HttpPost]
        public Response<int> Insert([FromBody] EmployeeTerritoryEntity entity)
        {
            return _service.Insert(entity);
        }

        // PUT api/EmployeeTerritory/Update
        [HttpPut]
        public Response<int> Update([FromBody] EmployeeTerritoryEntity entity)
        {
            return _service.Update(entity);
        }

        // DELETE api/EmployeeTerritory/Delete/1
        [HttpDelete("{EmployeeID}")]
        public Response<int> Delete(int EmployeeID)
        {
            return _service.Delete(EmployeeID);
        }
    }
}