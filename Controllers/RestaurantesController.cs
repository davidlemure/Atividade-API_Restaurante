using ApiRestaurante.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApiRestaurante.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    
    public class RestaurantesController : ControllerBase 
    {
        private static List<Restaurante> restaurantes = new List<Restaurante>()
    
        {
        new Restaurante() { Id = 1, Nome = "Ari do caldo", Telefone = 999999999, Endereco = "Bernardo Fonseca 446", Nota = 9},
        new Restaurante() { Id = 2, Nome = "Ari do suco", Telefone = 999999999, Endereco = "Bernardo Fonseca 446", Nota = 5},

        };

        [HttpGet("Get")]
        public IActionResult GetFirst()
        {
            Restaurante p = restaurantes[0];
            return Ok(p);
        }

        [HttpGet("GetAll")]
        public IActionResult Get()
        {
            return Ok(restaurantes);
        }

        [HttpPost]
        public IActionResult AddRestaurante(Restaurante novoRestaurante)
        {
            restaurantes.Add(novoRestaurante);
            return Ok(restaurantes);
        }

        [HttpGet("GetOrdenado")]

        public IActionResult GetOrdem()
        {
            List<Restaurante> listaFinal = restaurantes.OrderBy(p => p.Nota).ToList();
            return Ok(listaFinal);
        }        

        [HttpGet("GetByNota/{nota}")]

        public IActionResult Get(int nota)
        {
            List<Restaurante> listaFinal = restaurantes.FindAll(p => p.Nota == nota);
            return Ok(listaFinal);
        }    

        [HttpPut]

        public IActionResult UpdateRestaurantes(Restaurante p)
        {
            Restaurante restaurantesAlterado = restaurantes.Find(rest => rest.Id == p.Id);
            restaurantesAlterado = p.Nome;
            restaurantesAlterado = p.Telefone;
            restaurantesAlterado = p.Endereco;
            restaurantesAlterado = p.Nota;

            return Ok(restaurantes);
        }    
    }

    


}