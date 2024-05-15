using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Collections.Specialized;
using Microsoft.Extensions.Configuration;
using System.Runtime.CompilerServices;

namespace WebDAQCore.Configuration;
public static class ConfigManager
{
    private static IConfiguration configuration = null;
    private static void BuildConfig()
    {
        ConfigManager.configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: false)
            .Build();
    }

    public static IConfiguration? GetConfiguration()
    {
        if (configuration == null)
        {
            BuildConfig();
        }
            return configuration;


    }

    public static void ReloadConfig()
    {
        configuration = null;
        BuildConfig();
    }
}
