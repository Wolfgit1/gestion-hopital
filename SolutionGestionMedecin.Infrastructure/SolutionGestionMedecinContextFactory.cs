using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using SolutionGestionMedecin.Infrastructure;

public class SolutionGestionMedecinContextFactory : IDesignTimeDbContextFactory<SolutionGestionMedecinContext>
{
    public SolutionGestionMedecinContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<SolutionGestionMedecinContext>();
        optionsBuilder.UseSqlServer(@"Server=.;Database=SolutiongestionmedecinsDB;Trusted_Connection=True;");
        return new SolutionGestionMedecinContext(optionsBuilder.Options);
    }
}
