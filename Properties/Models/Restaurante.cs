namespace ApiRestaurante.Models
{
    public class Restaurante
    {
        public int Id { get; set; }

        public  string Nome { get; set; }

        public int Telefone { get; set; }
        public  string Endereco { get; set; }
        public int Nota { get; set; }
    }
}