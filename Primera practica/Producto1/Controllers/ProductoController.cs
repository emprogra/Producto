namespace Producto1.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        [HttpGet]
        public int Get([FromHeader] string palabra)
        {
            int contador = 0;
            for (int i = 0; i <= palabra.Length - 1; i++)
            {
                if ((palabra[i].ToString().ToLower() == "a") || (palabra[i].ToString().ToLower() == "e") || (palabra[i].ToString().ToLower() == "i") || (palabra[i].ToString().ToLower() == "o") || (palabra[i].ToString().ToLower() == "u"))
                {
                    contador++;

                }
            }
            return contador;

        }
        [HttpGet]
        [Route("GetA")]
        public int GetA([FromHeader] string palabra)
        {
            int contador = 0;
            for (int i = 0; i <= palabra.Length - 1; i++)
            {
                if ((palabra[i].ToString().ToUpper() == "A"))
                {
                    contador++;
                }

            }
            return contador;
        }
        [HttpGet]
        [Route("GetB")]
        public int GetB([FromHeader] string palabra)
        {
            int contador = 0;
            for(int i=0;i<=palabra.Length-1;i++)
            {
                if((palabra[i].ToString().ToLower()!="a")&&(palabra[i].ToString().ToLower()!="e")&&(palabra[i].ToString().ToLower()!="i")&&(palabra[i].ToString().ToLower()!="o")&&(palabra[i].ToString().ToLower()!="u"))
                {
                    contador++;
                }
            }
            return contador;
        }
    }
}
