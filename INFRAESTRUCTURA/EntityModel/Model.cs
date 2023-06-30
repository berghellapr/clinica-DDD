using Microsoft.EntityFrameworkCore;

public class Contexto : DbContext
{
    public DbSet<ClienteEntity> Clientes { get; set; }

    public string DbPath { get; }

    public Contexto()
    {
        var folder = Environment.SpecialFolder.LocalApplicationData;
        var path = Environment.GetFolderPath(folder);
        DbPath = System.IO.Path.Join(path, "ClinicaVeterinaria.db");
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlServer($"Data Source={DbPath}");
}

public class ClienteEntity
    {
        public Guid id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set;}
        public string email { get; set;}
    }
