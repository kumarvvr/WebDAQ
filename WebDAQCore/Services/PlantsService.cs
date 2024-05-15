
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using WebDAQCore.Models;
using WebDAQCore.Infrastructure.Database;


namespace WebDAQCore.Services;

public class PlantsService
{
    private IDbContextFactory<PGSQLContext> DbContextFactory;
    public PlantsService(IDbContextFactory<PGSQLContext> DbContextFactory)
    {
        this.DbContextFactory = DbContextFactory;
    }

    public List<Plant> GetAllPlants()
    {
        using (var context = DbContextFactory.CreateDbContext())
        {
            return context.Plants.ToList();
        }
    }

    public Guid CreateNewPlant(Plant plant)
    {
        // Replace the ID as it should be in control of the system
        Guid id = Guid.NewGuid();
        plant.id = id;

        if (plant.name == null )
            throw new Exception("Plant Name cannot be null");
        else
        {
            using(var context = DbContextFactory.CreateDbContext())
            {
                context.Plants.Add(plant);  
                context.SaveChanges();
                return id;
            }
        }

    }
}
