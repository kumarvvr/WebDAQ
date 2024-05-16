﻿
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

    public Plant? GetPlant(Guid id)
    {
        using (var context = DbContextFactory.CreateDbContext())
        {
            return context.Plants.Find(id);
        }
    }

    public Guid CreateNewPlant(CreatePlantModel _plant)
    {
        // Replace the ID as it should be in control of the system
        Guid id = Guid.NewGuid();

        Plant plant = new Plant();
        plant.id = id;
        plant.name = _plant.Name;
        plant.description = _plant.Description;

        
        using(var context = DbContextFactory.CreateDbContext())
        {
            context.Plants.Add(plant);  
            context.SaveChanges();
            return id;
        }
        

    }
}
