using System.Text.Json;

namespace WebDAQCore.Models;


public enum ParameterType
{
    NUMBER,
    STRING,
    NUMBERLIST,
    STRINGLIST,
    NUMBERTABLE,
    STRINGTABLE,
    XTABLE,
    CUSTOM
}

/*
* 
* Corresponds to the "templateparameters" table in the database.
* 
*/ 


// Generate documentation for ParameterModel

public class Parameter
{
    public Guid id { get; set; }
    public Guid ref_id { get; set; }
    public string category { get; set; }
    public string name { get; set; }   
    public ParameterType type { get; set; }
    public int index { get; set; }
    public JsonDocument value { get; set; }
}

