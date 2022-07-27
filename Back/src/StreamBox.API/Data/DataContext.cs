using Microsoft.EntityFrameworkCore;
using StreamBox.API.Models;

namespace StreamBox.API.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options){ }
        public DbSet <Evento> Eventos { get; set; }
    }
}