using Microsoft.AspNetCore.Mvc;

namespace Algorithms.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InsertSort : ControllerBase
    {

        [HttpPost(Name = "InsertSort")]
        public ActionResult Post([FromBody] int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int key = array[i];  // El elemento que vamos a insertar.
                int j = i - 1;  // El índice del último elemento ordenado.

                // Mover los elementos de array[0..i-1], que son mayores que key,
                // a una posición adelante de su posición actual.
                while (j >= 0 && array[j] > key)
                {
                    array[j + 1] = array[j];
                    j--;
                }
                // Insertar el key en la posición correcta
                array[j + 1] = key;
            }
            return Ok(array);
        }
    }
}
