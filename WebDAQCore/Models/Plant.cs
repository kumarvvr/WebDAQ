using System.Text.Json;

namespace WebDAQCore.Models;

public class Plant
{
    public Guid id { get; set; }
    public string name { get; set; }
    public string description { get; set; }
    public JsonDocument parameters { get; set; }
}

public record NewPlantRecord
{
    public string Name { get; set; }
    public string Description { get; set; }
}

public record UpdatePlantRecord
{
    public Guid id { get; init; }
    public string Name { get; set; }
    public string Description { get; set; }

    public JsonDocument parameters { get; set; }
}

