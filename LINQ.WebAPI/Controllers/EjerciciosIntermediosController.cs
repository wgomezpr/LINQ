using LINQ.ApplicationLayer.Services.CategoryService;
using LINQ.ApplicationLayer.Services.ProductService;
using LINQ.DomainLayer.DTO.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace LINQ.WebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class EjerciciosIntermediosController : ControllerBase
    {
        // Instantiate the Service
        private readonly ICategoryService _categoryService;
        private readonly IProductService _productService;

        public EjerciciosIntermediosController(ICategoryService categoryService, IProductService productService)
        {
            _categoryService = categoryService;
            _productService = productService;
        }

        //1.  Unir dos listas y eliminar duplicados.
        [HttpGet]
        public IList<int> Ejercicio01()
        {
            IList<int> lista1 = new List<int> { 10, 8, 1, 7, 4, 5, 2, 3, 6, 9 };
            IList<int> lista2 = new List<int> { 5, 8, 1, 12, 20, 1000, 25, 88, 78, 33 };

            var union = lista1.Concat(lista2).ToList();
            var sinDuplicados = union.Distinct().ToList().Order().ToList();

            return sinDuplicados;
        }

        //2.  Obtener el promedio de una lista de números decimales.
        [HttpGet]
        public double Ejercicio02()
        {
            IList<int> numeros = new List<int> { 15, 15, 15 };

            return numeros.Average();
        }

        //3.  Ordenar una lista de cadenas alfabéticamente.
        [HttpGet]
        public IList<string> Ejercicio03()
        {
            IList<string> palabras = new List<string> { "E", "C", "D", "B", "A" };

            return palabras.OrderBy(x => x).ToList();
        }

        //4.  Encontrar los elementos comunes entre dos listas.
        [HttpGet]
        public IList<int> Ejercicio04()
        {
            IList<int> lista1 = new List<int> { 10, 8, 1, 7, 4, 5, 2, 3, 6, 9 };
            IList<int> lista2 = new List<int> { 5, 8, 1, 12, 20, 1000, 25, 88, 78, 33 };

            var comunes = lista1.Intersect(lista2).ToList();

            return comunes;
        }

        //5.  Obtener la suma de los valores de una propiedad de una lista de objetos.
        [HttpGet]
        public decimal Ejercicio05()
        {
            decimal suma = 0;
            var res = _productService.GetAll();

            if (res.Status)
            {
                suma = res.Value.Where(x => x.CategoryID == 1 && x.ProductID == 1).ToList().Sum(x => x.UnitPrice);
            }

            return suma;
        }

        //6.  Obtener los elementos que se encuentran en una lista pero no en otra.
        [HttpGet]
        public IList<int> Ejercicio06()
        {
            IList<int> lista1 = new List<int> { 10, 8, 1, 7, 4, 5, 2, 3, 6, 9 };
            IList<int> lista2 = new List<int> { 5, 8, 1, 12, 20, 1000, 25, 88, 78, 33 };

            var comunes = lista1.Except(lista2).ToList();

            return comunes;
        }

        //7.  Filtrar una lista de objetos por múltiples condiciones.
        [HttpGet]
        public IList<CategoryEntity> Ejercicio07()
        {
            IList<CategoryEntity> categorias = new List<CategoryEntity>();
            IList<CategoryEntity> categorias1 = new List<CategoryEntity>();
            var res = _categoryService.GetAll();

            if (res.Status)
            {
                categorias1 = res.Value.Where(x => x.CategoryID == 1 && x.Description.Contains("Soft")).ToList();
            }

            return categorias1;
        }

        //8.  Dividir una lista en grupos de un tamaño específico.
        //[HttpGet]
        //public IList<CategoryEntity> Ejercicio07()
        //{
        //    IList<CategoryEntity> categorias = new List<CategoryEntity>();
        //    //IList<CategoryEntity> categorias1 = new List<CategoryEntity>();
        //    var res = _categoryService.GetAll();

        //    if (res.Status)
        //    {
        //        var categorias1 = res.Value.GroupBy((item, index) => index / 5);
        //    }

        //    return categorias1;
        //}

        //9.  Encontrar el primer y el último elemento de una lista.
        [HttpGet]
        public IList<CategoryEntity> Ejercicio08()
        {
            IList<CategoryEntity> categoriasaux = new List<CategoryEntity>();
            var res = _categoryService.GetAll();

            if (res.Status)
            {
                var primero = res.Value.First();
                var ultimo = res.Value.Last();
                categoriasaux.Add(primero);
                categoriasaux.Add(ultimo);
            }

            return categoriasaux;
        }

        //10. Obtener los elementos que se repiten más de una vez en una lista.
        [HttpGet]
        public IList<int> Ejercicio10()
        {
            IList<int> lista = new List<int> { 10, 8, 1, 7, 4, 5, 2, 3, 1, 1, 10, 2, 10};

            var repetidos = lista.GroupBy(x => x).Where(x => x.Count() > 1).ToList();

            return lista;
        }

        //11. Encontrar el rango de valores(diferencia entre el máximo y el mínimo) en una lista de enteros.
        //12. Obtener los elementos que tienen una propiedad nula en una lista de objetos.
        //13. Combinar dos listas de objetos y seleccionar solo las propiedades comunes.
        //14. Obtener los elementos de una lista que están dentro de un rango específico.
        //15. Verificar si al menos un elemento de una lista cumple una cierta condición.
        //16. Contar la cantidad de elementos distintos en una lista.
        //17. Dividir una lista en dos, una con los elementos pares y otra con los impares.
        //18. Obtener el tercer elemento más grande de una lista de enteros.
        //18. Obtener la suma de los cuadrados de los elementos en una lista.
        //20. Eliminar los elementos duplicados de una lista manteniendo el orden original.
    }
}