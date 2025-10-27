using Microsoft.Identity.Client;
using System;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace LogViewer.Config;

internal static class ConfigManager
{
    private static JsonSerializerOptions _jsonSerializerOptions = new JsonSerializerOptions { WriteIndented = true };

    private const string cFoldername = "Dyvenix";
    private const string cFileName = "DyvenixLogViewer.config";

    private static readonly string _configFolderpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), cFoldername);
    private static readonly string _configFilepath = Path.Combine(_configFolderpath, cFileName);
    private static bool _isInitialized;

    internal static AppConfig GetAppConfig()
    {
        if (!_isInitialized)
        {
            if (!Directory.Exists(_configFolderpath))
            {
                Directory.CreateDirectory(_configFolderpath);
            }
            _isInitialized = true;
        }

        if (!File.Exists(_configFilepath))
            return new AppConfig();

        var json = File.ReadAllText(_configFilepath);
        var appConfig = JsonSerializer.Deserialize<AppConfig>(json);

        // Legacy config files don't have a empty item with empty guid
        if (appConfig.DbConns.Count == 0 || !appConfig.DbConns.Any(c => c.Id == Guid.Empty))
            appConfig.DbConns.Insert(0, new DbConn() { Id = Guid.Empty, Name = string.Empty });

        // Ensure valid values
        if (appConfig.AutoRefreshTimerIntervalMs < 2000)
            appConfig.AutoRefreshTimerIntervalMs = 2000;
        if (appConfig.AutoRefreshTimeoutTimerIntervalMs < 60000)
            appConfig.AutoRefreshTimeoutTimerIntervalMs = 60000;

        return appConfig;
    }

    internal static void SaveAppConfig(AppConfig appConfig)
    {

        var json = JsonSerializer.Serialize(appConfig, options: _jsonSerializerOptions);
        File.WriteAllText(_configFilepath, json);
    }
}
