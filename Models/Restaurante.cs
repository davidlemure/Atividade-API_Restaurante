using Atividade_API_Restaurante.Models.Enuns;

namespace ApiRestaurante.Models

{
    public class Restaurante
    {
        public int Id { get; set; }

        public string Nome { get; set; } = string.Empty;

        public int Telefone { get; set; }
        public  string Endereco { get; set; } = string.Empty;
        public int Nota { get; set; }

        public TipoRestauranteEnum Tipo { get; set; }
    }
}