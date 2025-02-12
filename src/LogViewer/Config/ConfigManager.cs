using System;
using System.IO;
using System.Text.Json;

namespace LogViewer.Config;
internal static class ConfigManager
{
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
		return JsonSerializer.Deserialize<AppConfig>(json);
	}

	internal static void SaveAppConfig(AppConfig appConfig)
	{

		var json = JsonSerializer.Serialize(appConfig);
		File.WriteAllText(_configFilepath, json);
	}
}
