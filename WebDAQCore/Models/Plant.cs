using System.Text.Json;

namespace WebDAQCore.Models;

public class Plant
{
    public Guid id { get; set; }
    public string name { get; set; }
    public string description { get; set; }
    public JsonDocument parameters { get; set; }
}
