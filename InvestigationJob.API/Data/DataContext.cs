using InvestigationJob.API.Entities.Interface;
using InvestigationJob.API.Entities.Service;
using Microsoft.EntityFrameworkCore;

namespace InvestigationJob.API.Data;

public class DataContext : DbContext
{
    public DbSet<IUsuario> Usuarios { get; set; }
    public DbSet<ITelefone> Telefones { get; set; }
    public DbSet<INomeCompleto> NomesCompletos { get; set; }
    public DbSet<IImage> Imagens { get; set; }
    public DbSet<IEndereco> Enderecos { get; set; }
    public DbSet<ICpf> Cpfs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseSqlServer("Server=SQLEXPRESS;Database=Investigation Job;Integrated Security=SSPI");
    }
}