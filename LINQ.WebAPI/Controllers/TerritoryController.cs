using LINQ.ApplicationLayer.Services.TerritoryServices;
using LINQ.DomainLayer.DTO.Entities;
using LINQ.DomainLayer.DTO.Responses;
using Microsoft.AspNetCore.Mvc;

namespace LINQ.WebAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TerritoryController : ControllerBase
    {
        // Instantiate the Service
        private readonly ITerritoryServices _service;

        public TerritoryController(ITerritoryServices service)
        {
            _service = service;
        }

        // GET: api/Territory/Get/1
        [HttpGet("{TerritoryID}")]
        public Response<TerritoryEntity> Get(int TerritoryID)
        {
            return _service.Get(TerritoryID);
        }

        // GET: api/Territory/GetAll
        [HttpGet]
        public Response<IList<TerritoryEntity>> GetAll()
        {
            return _service.GetAll();
        }

        // POST api/Territory/Insert
        [HttpPost]
        public Response<int> Insert([FromBody] TerritoryEntity entity)
        {
            return _service.Insert(entity);
        }

        // PUT api/Territory/Update
        [HttpPut]
        public Response<int> Update([FromBody] TerritoryEntity entity)
        {
            return _service.Update(entity);
        }

        // DELETE api/Territory/Delete/1
        [HttpDelete("{TerritoryID}")]
        public Response<int> Delete(int TerritoryID)
        {
            return _service.Delete(TerritoryID);
        }
    }
}