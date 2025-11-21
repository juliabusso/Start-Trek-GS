using FIAP.CP2.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace CandidatosData
{
    public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionsBuilder.UseOracle("User Id=xx;Password=xx;Data Source=oracle.fiap.com.br:1521/ORCL;");

            return new ApplicationDbContext(optionsBuilder.Options);
        }
    }
}
