using LINQ.ApplicationLayer.Services.RegionService;
using LINQ.DomainLayer.DTO.Entities;
using LINQ.DomainLayer.DTO.Responses;
using Microsoft.AspNetCore.Mvc;

namespace LINQ.WebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class RegionController : ControllerBase
    {
        // Instantiate the Service
        private readonly IRegionService _service;

        public RegionController(IRegionService service)
        {
            _service = service;
        }

        // GET: api/Region/Get/1
        [HttpGet("{RegionID}")]
        public Response<RegionEntity> Get(int RegionID)
        {
            return _service.Get(RegionID);
        }

        // GET: api/Region/GetAll
        [HttpGet]
        public Response<IList<RegionEntity>> GetAll()
        {
            return _service.GetAll();
        }

        // POST api/Region/Insert
        [HttpPost]
        public Response<int> Insert([FromBody] RegionEntity entity)
        {
            return _service.Insert(entity);
        }

        // PUT api/Region/Update
        [HttpPut]
        public Response<int> Update([FromBody] RegionEntity entity)
        {
            return _service.Update(entity);
        }

        // DELETE api/Region/Delete/1
        [HttpDelete("{RegionID}")]
        public Response<int> Delete(int RegionID)
        {
            return _service.Delete(RegionID);
        }
    }
}