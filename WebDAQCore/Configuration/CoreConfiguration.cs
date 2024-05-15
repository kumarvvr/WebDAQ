using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Collections.Specialized;
using Microsoft.Extensions.Configuration;

namespace WebDAQCore.Configuration;
public class CoreConfiguration
{
    IConfiguration configuration;
    public CoreConfiguration()
    {
        this.configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: false)
            .Build();
    }

    public IConfiguration GetConfiguration()
    {
        return this.configuration;
    }
}
