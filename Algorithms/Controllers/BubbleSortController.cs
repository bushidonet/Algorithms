using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Algorithms.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BubbleSortController: ControllerBase
    {
        /// <summary>
        /// Sort Bubble Compara y intercambia elementos adyacentes si están en el orden incorrecto.
        /// Este algoritmo tiene una complejidad de O(n²), por lo que es ineficiente para listas grandes.
        /// </summary>
        /// <param name="id">ID del usuario</param>
        /// <returns>Detalles del usuario.</returns>
        /// <response code="200">Devuelve los detalles del usuario.</response>
        /// <response code="404">Si el usuario no se encuentra.</response>
        [HttpPost(Name = "BubbleSort")]
        public ActionResult Post([FromBody] List<int> numbers)
        {
            if (numbers == null || numbers.Count == 0)
            {
                return BadRequest("La lista no puede estar vacía.");
            }
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();  // Iniciar el contador
            // Aplicar el algoritmo Bubble Sort
            for (int i = 0; i < numbers.Count - 1; i++)
            {
                for (int j = 0; j < numbers.Count - i - 1; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        // Intercambiar los elementos
                        int temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                    }
                }
            }

            stopwatch.Stop();  // Detener el contador

            // Tiempo transcurrido en milisegundos
            long tiempoProceso = stopwatch.ElapsedMilliseconds;

            // Crear la respuesta
            var response = new
            {
                NumerosOrdenados = numbers,
                TiempoProcesamientoMs = tiempoProceso
            };

            // Retornar la lista ordenada
            return Ok(response);
        }

    }
}
