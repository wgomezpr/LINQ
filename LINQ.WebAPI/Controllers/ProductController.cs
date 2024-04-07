using LINQ.ApplicationLayer.Services.ProductService;
using LINQ.DomainLayer.DTO.Entities;
using LINQ.DomainLayer.DTO.Responses;
using Microsoft.AspNetCore.Mvc;

namespace LINQ.WebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        // Instantiate the Service
        private readonly IProductService _service;

        public ProductController(IProductService service)
        {
            _service = service;
        }

        // GET: api/Product/Get/1
        [HttpGet("{ProductID}")]
        public Response<ProductEntity> Get(int ProductID)
        {
            return _service.Get(ProductID);
        }

        // GET: api/Product/GetAll
        [HttpGet]
        public Response<IList<ProductEntity>> GetAll()
        {
            return _service.GetAll();
        }

        // POST api/Product/Insert
        [HttpPost]
        public Response<int> Insert([FromBody] ProductEntity entity)
        {
            return _service.Insert(entity);
        }

        // PUT api/Product/Update
        [HttpPut]
        public Response<int> Update([FromBody] ProductEntity entity)
        {
            return _service.Update(entity);
        }

        // DELETE api/Product/Delete/1
        [HttpDelete("{ProductID}")]
        public Response<int> Delete(int ProductID)
        {
            return _service.Delete(ProductID);
        }
    }
}