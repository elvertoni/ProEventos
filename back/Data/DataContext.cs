using Microsoft.EntityFrameworkCore;
using proeventos.back.Models;

namespace proeventos.back.Data;

public class AppDataContext : DbContext
{
    public AppDataContext(DbContextOptions<AppDataContext> options) : base(options) { }
    
    //cada classe que quero que vire uma tabela no banco coloco aqui
    public DbSet<Evento> Eventos {get; set;}
}