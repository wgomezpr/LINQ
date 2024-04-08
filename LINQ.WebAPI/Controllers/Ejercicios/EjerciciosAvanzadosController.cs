using LINQ.ApplicationLayer.Services.CategoryService;
using Microsoft.AspNetCore.Mvc;

namespace LINQ.WebAPI.Controllers.Ejercicios
{
    [Produces("application/json")]
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class EjerciciosAvanzadosController : ControllerBase
    {
        // Instantiate the Service
        private readonly ICategoryService _service;

        public EjerciciosAvanzadosController(ICategoryService service)
        {
            _service = service;
        }

        /// <summary>
        /// 1. Encontrar el segundo número más grande en una lista de enteros.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public int Ejercicio01()
        {
            IList<int> numeros = new List<int> { 10, 8, 1, 7, 4, 5, 2, 3, 6, 9 };
            var segundonumero = numeros.OrderByDescending(x => x).Skip(1).First();

            return segundonumero;
        }

        /// <summary>
        /// 2. Agrupar una lista de objetos por una propiedad y contar cuántos hay en cada grupo.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public int Ejercicio02()
        {
            return Enumerable.Range(1, 1).FirstOrDefault();
        }

        /// <summary>
        /// 3. Obtener los primeros 5 elementos de una lista, luego omitir los siguientes 3 y tomar los siguientes 2.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IList<int> Ejercicio03()
        {
            IList<int> numeros = new List<int> { 10, 8, 1, 7, 4, 5, 2, 3, 6, 9 };
            var segundonumero = numeros.Take(5).Skip(3).Take(2).ToList();
            return segundonumero;
        }

        /// <summary>
        /// 4. Concatenar las cadenas de una lista separadas por un delimitador.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public int Ejercicio04()
        {
            return Enumerable.Range(1, 1).FirstOrDefault();
        }

        /// <summary>
        /// 5. Encontrar la raíz cuadrada de cada número en una lista y descartar los resultados que sean números imaginarios.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public int Ejercicio05()
        {
            return Enumerable.Range(1, 1).FirstOrDefault();
        }

        /// <summary>
        /// 6. Obtener los elementos de una lista que están presentes en un conjunto dado.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public int Ejercicio06()
        {
            return Enumerable.Range(1, 1).FirstOrDefault();
        }

        /// <summary>
        /// 7. Invertir el orden de una lista.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public int Ejercicio07()
        {
            return Enumerable.Range(1, 1).FirstOrDefault();
        }

        /// <summary>
        /// 8. Obtener los elementos que contengan una subcadena específica.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public int Ejercicio08()
        {
            return Enumerable.Range(1, 1).FirstOrDefault();
        }

        /// <summary>
        /// 9. Filtrar una lista de objetos por una lista de valores permitidos en una propiedad.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public int Ejercicio09()
        {
            return Enumerable.Range(1, 1).FirstOrDefault();
        }

        /// <summary>
        /// 10. Combinar múltiples listas en una sola lista sin duplicados.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public int Ejercicio10()
        {
            return Enumerable.Range(1, 1).FirstOrDefault();
        }

        /// <summary>
        /// 11. Encontrar el primer elemento que cumple una condición en una lista de listas.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public int Ejercicio11()
        {
            return Enumerable.Range(1, 1).FirstOrDefault();
        }

        /// <summary>
        /// 12. Obtener los elementos que tienen al menos una propiedad con un valor nulo.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public int Ejercicio12()
        {
            return Enumerable.Range(1, 1).FirstOrDefault();
        }

        /// <summary>
        /// 13. Encontrar la moda (el valor que más se repite) en una lista de enteros.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public int Ejercicio13()
        {
            return Enumerable.Range(1, 1).FirstOrDefault();
        }

        /// <summary>
        /// 14. Obtener los elementos que contengan al menos una vocal en una lista de cadenas.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public int Ejercicio14()
        {
            return Enumerable.Range(1, 1).FirstOrDefault();
        }

        /// <summary>
        /// 15. Eliminar los elementos repetidos consecutivos de una lista.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public int Ejercicio15()
        {
            return Enumerable.Range(1, 1).FirstOrDefault();
        }

        /// <summary>
        /// 16. Encontrar el primer número primo en una lista de enteros.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public int Ejercicio16()
        {
            return Enumerable.Range(1, 1).FirstOrDefault();
        }

        /// <summary>
        /// 17. Obtener el producto de todos los elementos en una lista de números decimales.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public int Ejercicio17()
        {
            return Enumerable.Range(1, 1).FirstOrDefault();
        }

        /// <summary>
        /// 18. Convertir una lista de cadenas a un solo string concatenando todas con un separador.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public int Ejercicio18()
        {
            return Enumerable.Range(1, 1).FirstOrDefault();
        }

        /// <summary>
        /// 19. Obtener los elementos que tengan una propiedad con un valor que cumple una condición específica.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public int Ejercicio19()
        {
            return Enumerable.Range(1, 1).FirstOrDefault();
        }

        /// <summary>
        /// 20. Verificar si una lista está ordenada de forma ascendente.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public int Ejercicio20()
        {
            return Enumerable.Range(1, 1).FirstOrDefault();
        }
    }
}