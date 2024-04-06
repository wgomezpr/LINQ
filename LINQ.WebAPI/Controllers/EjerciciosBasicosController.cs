using LINQ.ApplicationLayer.Services.CategoryService;
using LINQ.DomainLayer.DTO.Entities;
using Microsoft.AspNetCore.Mvc;

namespace LINQ.WebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class EjerciciosBasicosController : ControllerBase
    {
        // Instantiate the Service
        private readonly ICategoryService _service;

        public EjerciciosBasicosController(ICategoryService service)
        {
            _service = service;
        }

        /// <summary>
        /// 1. Obtener todos los números pares de una lista de enteros.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IList<int> Ejercicio01()
        {
            IList<int> numeros = Enumerable.Range(1, 10).ToList();

            //var numerospares = (from numero in numeros where numero % 2 == 0 select numero).ToList();
            var numerospares = numeros.Where(x => x % 2 == 0).ToList();

            return numerospares;
        }

        /// <summary>
        /// 2. Encontrar la suma de todos los elementos en una lista de enteros.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public int Ejercicio02()
        {
            IList<int> numeros = new List<int> { 10, 20, 100 };
            var suma = numeros.Sum();

            return suma;
        }

        /// <summary>
        /// 3. Filtrar una lista de cadenas para obtener aquellas que empiecen con la letra 'C'.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IList<CategoryEntity> Ejercicio03()
        {
            IList<CategoryEntity> categories = new List<CategoryEntity>();

            var res = _service.GetAll();
            if (res.Status)
            {
                categories = res.Value.Where(x => x.CategoryName.StartsWith("C")).ToList();
            }

            return categories;
        }

        /// <summary>
        /// 4. Encontrar el número más grande en una lista de enteros.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public int Ejercicio04()
        {
            int max = 0;

            var res = _service.GetAll();
            if (res.Status)
            {
                max = res.Value.Max(x => x.CategoryID);
            }

            return max;
        }

        /// <summary>
        /// 5. Obtener la cantidad de elementos en una lista.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public int Ejercicio05()
        {
            int cantidad = 0;

            var res = _service.GetAll();
            if (res.Status)
            {
                cantidad = res.Value.Count();
            }

            return cantidad;
        }

        /// <summary>
        /// 6. Ordenar una lista de enteros en orden ascendente.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IList<int> Ejercicio06()
        {
            IList<int> numeros = new List<int> { 10, 8, 1, 7, 4, 5, 2, 3, 6, 9 };
            var ordenado = numeros.Order().ToList();

            return ordenado;
        }

        /// <summary>
        /// 7. Obtener los elementos distintos de una lista de cadenas.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IList<string> Ejercicio07()
        {
            IList<string> numeros = new List<string> { "Cuaderno", "PC", "Frutas", "Cuaderno", "PC" };
            var ordenado = numeros.Distinct().ToList();

            return ordenado;
        }

        /// <summary>
        /// 8. Filtrar una lista de objetos para obtener aquellos que cumplan cierta condición.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IList<CategoryEntity> Ejercicio08()
        {
            IList<CategoryEntity> categorias = new List<CategoryEntity>();
            var res = _service.GetAll();
            if (res.Status)
            {
                categorias = res.Value.Where(x => x.CategoryName.Contains("e")).ToList();
            }

            return categorias;
        }

        /// <summary>
        /// 9. Obtener el primer elemento de una lista que cumpla cierta condición.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IList<CategoryEntity> Ejercicio09()
        {
            IList<CategoryEntity> categorias = new List<CategoryEntity>();
            var res = _service.GetAll();
            if (res.Status)
            {
                categorias = res.Value.Where(x => x.CategoryName.EndsWith("s")).ToList().Take(1).ToList();
            }

            return categorias;
        }

        /// <summary>
        /// 10. Contar cuántas veces aparece un elemento específico en una lista.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public int Ejercicio10()
        {
            int cantidad = 0;

            var res = _service.GetAll();
            if (res.Status)
            {
                cantidad = res.Value.Where(x => x.CategoryName.EndsWith("s")).ToList().Count();

            }

            return cantidad;
        }

        //11. Encontrar el número más pequeño en una lista de enteros.
        //12. Obtener la concatenación de todas las cadenas en una lista.
        //13. Filtrar una lista de objetos para obtener los que no cumplen una condición.
        //14. Obtener los elementos mayores que un valor dado en una lista de enteros.
        //15. Obtener los elementos de una lista que sean múltiplos de un número dado.
        //16. Verificar si todos los elementos de una lista cumplen una cierta condición.
        //17. Encontrar el índice del primer elemento que cumpla una condición en una lista.
        //18. Obtener los elementos que se repiten exactamente dos veces en una lista.
        //18. Obtener la cantidad de caracteres de cada cadena en una lista de cadenas.
        //20. Obtener los elementos de una lista que contengan una subcadena específica.
    }
}