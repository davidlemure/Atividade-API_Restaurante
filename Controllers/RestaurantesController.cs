using ApiRestaurante.Models;
using Microsoft.AspNetCore.Mvc;
using Atividade_API_Restaurante.Models.Enuns;

namespace ApiRestaurante.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    
    public class RestaurantesController : ControllerBase 
    {
        private static List<Restaurante> restaurante = new List<Restaurante>()
    
        {
        new Restaurante() { Id = 1, Nome = "Ari do caldo", Telefone = 999999999, Endereco = "Bernardo Fonseca 446", Nota = 9, Tipo=TipoRestauranteEnum.Caseira},
        new Restaurante() { Id = 2, Nome = "Macaronada da Nona", Telefone = 999999999, Endereco = "Amambai 500", Nota = 5, Tipo=TipoRestauranteEnum.Italiana},
        new Restaurante() { Id = 3, Nome = "Rei do Beirute", Telefone = 999999999, Endereco = "Sezefredo Fagundes 446", Nota = 9, Tipo=TipoRestauranteEnum.Arabe},
        new Restaurante() { Id = 4, Nome = "Quintal da vila", Telefone = 999999999, Endereco = "Sezefredo Fagundes 446", Nota = 9, Tipo=TipoRestauranteEnum.Caseira},
        new Restaurante() { Id = 5, Nome = "Divina Panqueca", Telefone = 999999999, Endereco = "Sezefredo Fagundes 446", Nota = 9, Tipo=TipoRestauranteEnum.Arabe},
        new Restaurante() { Id = 3, Nome = "Combo na caixa", Telefone = 999999999, Endereco = "Sezefredo Fagundes 446", Nota = 9, Tipo=TipoRestauranteEnum.Lanches}

        };

        [HttpGet("Get")]
        public IActionResult GetFirst()
        {
            Restaurante p = restaurante[0];
            return Ok(p);
        }

        [HttpGet("GetAll")]
        public IActionResult Get()
        {
            return Ok(restaurante);
        }

        [HttpPost]
        public IActionResult AddRestaurante(Restaurante novoRestaurante)
        {
            restaurante.Add(novoRestaurante);
            return Ok(restaurante);
        }

        [HttpGet("GetOrdenado")]

        public IActionResult GetOrdem()
        {
            List<Restaurante> listaFinal = restaurante.OrderBy(p => p.Nota).ToList();
            return Ok(listaFinal);
        }        

        [HttpGet("GetByNota/{nota}")]

        public IActionResult Get(int nota)
        {
            List<Restaurante> listaFinal = restaurante.FindAll(p => p.Nota == nota);
            return Ok(listaFinal);
        }    

        [HttpPut]

        public IActionResult UpdateRestaurantes(Restaurante p)
        {
            Restaurante restauranteAlterado = restaurante.Find(rest => rest.Id == p.Id);
            restauranteAlterado.Nome = p.Nome;
            restauranteAlterado.Telefone = p.Telefone;
            restauranteAlterado.Endereco = p.Endereco;
            restauranteAlterado.Nota = p.Nota;

            return Ok(restaurante);
        }    

        [HttpGet("GetByEnum/{enumId}")]

        public IActionResult GetByEnum(int enumId)
        {
            TipoRestauranteEnum enumDigitado = (TipoRestauranteEnum)enumId;

            List<Restaurante> listaBusca = restaurante.FindAll(p => p.Tipo == enumDigitado);

            return Ok (listaBusca);
        }
    }

    


}