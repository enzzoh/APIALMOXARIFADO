using ApiAlmoxarifado.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiAlmoxarifado.Infraestrutura
{
    public class ConexaoSQL : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
            =>
              optionBuilder.UseSqlServer(
                  @"Server=sql.bsite.net\MSSQL2016;" +
                  "Database=niuguin_;" +
                  "User id=niuguin_;" +
                  "Password=cmfs110110"


              );

        public DbSet<Produto> Produto { get; set; }
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Departamento> Departamento { get; set; }
        public DbSet<Funcionario> Funcionario { get; set; }
        public DbSet<CategoriaMotivo> CategoriaMotivo { get; set; }
        public DbSet<MotivoSaida> MotivoSaida { get; set; }
        public DbSet<Requisicao> Requisicao { get; set; }
        
    }
}
