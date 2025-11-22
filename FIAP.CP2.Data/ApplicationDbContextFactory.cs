using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace FIAP.CP2.Data
{
    public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();

            // Coloque sua connection string REAL do Oracle aqui
            optionsBuilder.UseOracle(
                "User Id=SEU_USER;Password=SUA_SENHA;Data Source=oracle.fiap.com.br:1521/ORCL;"
            );

            return new ApplicationDbContext(optionsBuilder.Options);
        }
    }
}
