using Microsoft.EntityFrameworkCore;

namespace Atividade_API_Restaurante.Properties.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<Restaurante> TB_RESTAURANTE { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ApiRestaurante>().HasData
            (
        new Restaurante() { Id = 1, Nome = "Ari do caldo", Telefone = 999999999, Endereco = "Bernardo Fonseca 446", Nota = 9, Tipo = TipoRestauranteEnum.Caseira },
        new Restaurante() { Id = 2, Nome = "Macaronada da Nona", Telefone = 999999999, Endereco = "Amambai 500", Nota = 5, Tipo = TipoRestauranteEnum.Italiana },
        new Restaurante() { Id = 3, Nome = "Rei do Beirute", Telefone = 999999999, Endereco = "Sezefredo Fagundes 446", Nota = 9, Tipo = TipoRestauranteEnum.Arabe },
        new Restaurante() { Id = 4, Nome = "Quintal da vila", Telefone = 999999999, Endereco = "Sezefredo Fagundes 446", Nota = 9, Tipo = TipoRestauranteEnum.Caseira },
        new Restaurante() { Id = 5, Nome = "Divina Panqueca", Telefone = 999999999, Endereco = "Sezefredo Fagundes 446", Nota = 9, Tipo = TipoRestauranteEnum.Arabe },
        new Restaurante() { Id = 3, Nome = "Combo na caixa", Telefone = 999999999, Endereco = "Sezefredo Fagundes 446", Nota = 9, Tipo = TipoRestauranteEnum.Lanches }

            );
        }
    }
}