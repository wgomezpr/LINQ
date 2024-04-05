using LINQ.ApplicationLayer.Services.CategoryService;
using LINQ.DomainLayer.DTO.Entities;
using LINQ.DomainLayer.DTO.Responses;
using Microsoft.AspNetCore.Mvc;

namespace LINQ.WebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        // Instantiate the Service
        private readonly ICategoryService _service;

        public CategoryController(ICategoryService service)
        {
            _service = service;
        }

        // GET: api/Category/Get/1
        [HttpGet("{Perf_Id}")]
        public Response<CategoryEntity> Get(int Perf_Id)
        {
            return _service.Get(Perf_Id);
        }

        // GET: api/Category/GetAll
        [HttpGet]
        public Response<IList<CategoryEntity>> GetAll()
        {
            return _service.GetAll();
        }

        // POST api/Category/Insert
        [HttpPost]
        public Response<int> Insert([FromBody] CategoryEntity entity)
        {
            return _service.Insert(entity);
        }

        // PUT api/Category/Update
        [HttpPut]
        public Response<int> Update([FromBody] CategoryEntity entity)
        {
            return _service.Update(entity);
        }

        // DELETE api/Category/Delete/1
        [HttpDelete("{Perf_Id}")]
        public Response<int> Delete(int Perf_Id)
        {
            return _service.Delete(Perf_Id);
        }
    }
}