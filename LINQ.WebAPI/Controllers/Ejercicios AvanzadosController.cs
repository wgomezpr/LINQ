using LINQ.ApplicationLayer.Services.CategoryService;
using Microsoft.AspNetCore.Mvc;

namespace LINQ.WebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class Ejercicios_AvanzadosController : ControllerBase
    {
        // Instantiate the Service
        private readonly ICategoryService _service;

        public Ejercicios_AvanzadosController(ICategoryService service)
        {
            _service = service;
        }

        //1. Encontrar el segundo número más grande en una lista de enteros.
        [HttpGet]
        public int Ejercicio01()
        {
            IList<int> numeros = new List<int> { 10, 8, 1, 7, 4, 5, 2, 3, 6, 9 };
            var segundonumero = numeros.OrderByDescending(x => x).Skip(1).First();

            return segundonumero;
        }

        //2. Obtener los primeros 5 elementos de una lista, luego omitir los siguientes 3 y tomar los siguientes 2.
        [HttpGet]
        public IList<int> Ejercicio02()
        {
            IList<int> numeros = new List<int> { 10, 8, 1, 7, 4, 5, 2, 3, 6, 9 };
            var segundonumero = numeros.Take(5).Skip(3).Take(2).ToList();

            return segundonumero;
        }
    }
}
