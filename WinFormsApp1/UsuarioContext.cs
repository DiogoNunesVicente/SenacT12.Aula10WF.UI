using Microsoft.EntityFrameworkCore;

namespace WinFormsApp1
{
    // visivel classe nome: UsuarioContext
    // Criar uma classe que herdas as caracterista de um BD
    public class UsuarioContext : DbContext
    {
        // coleção de usuarios do banco de dados
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=usuarios.db");
            base.OnConfiguring(optionsBuilder);
        }
    }
}