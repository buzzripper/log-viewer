using System;
using System.Collections.Generic;
using Microsoft.Win32;

namespace ProData.Infrastructure.LogViewer.Data
{
	public class RegRepository
	{
		private const string AppKey = "HKEY_CURRENT_USER\\Software\\Liazon\\LogViewer";

		public LogViewerData Load()
		{
			var logViewerData = new LogViewerData();

			try {
				logViewerData.TimerInterval = (int)Registry.GetValue(AppKey, "TimerInterval", 3000);
				logViewerData.MRUConnStringName = Registry.GetValue(AppKey, "MRUConnStringName", string.Empty).ToString();
				logViewerData.MRUSortAsc = (int)Registry.GetValue(AppKey, "MRUSortAsc", 0) == 1;
				logViewerData.AutoRefresh = (int)Registry.GetValue(AppKey, "AutoRefresh", 0) == 1;
				logViewerData.SetWindowPlacementStr(Registry.GetValue(AppKey, "WindowPlacementStr", string.Empty).ToString());
				logViewerData.SetDetailWindowPlacementStr(Registry.GetValue(AppKey, "DetailWindowPlacementStr", string.Empty).ToString());

				string serializedDbConnsListStr = Registry.GetValue(AppKey, "DbConns", null)?.ToString();
				if (!string.IsNullOrWhiteSpace(serializedDbConnsListStr)) {
					try {
						var serializedDbConnsList = XmlTools.Deserialize<List<string>>(serializedDbConnsListStr);
						foreach (var serDbConnStr in serializedDbConnsList) {
							try {
								logViewerData.DbConns.Add(XmlTools.Deserialize<DbConn>(serDbConnStr));

							} catch (Exception ex) {
								Console.WriteLine($"{ex.GetType().Name} deserializing DbConn str: {ex.Message}");
							}
						}

					} catch (Exception) {
						Console.WriteLine("Error deserializing DbConn");
					}
				}

			} catch (Exception ex) {
				Console.WriteLine($"{ex.GetType().Name} loading data: {ex.Message}");
			}

			return logViewerData;
		}

		public void Save(LogViewerData logViewerData)
		{
			try {
				Registry.SetValue(AppKey, "MRUConnStringName", logViewerData.MRUConnStringName);
				Registry.SetValue(AppKey, "MRUSortAsc", logViewerData.MRUSortAsc ? 1 : 0, RegistryValueKind.DWord);
				Registry.SetValue(AppKey, "TimerInterval", logViewerData.TimerInterval, RegistryValueKind.DWord);
				Registry.SetValue(AppKey, "AutoRefresh", logViewerData.MRUSortAsc ? 1 : 0, RegistryValueKind.DWord);
				Registry.SetValue(AppKey, "WindowPlacementStr", logViewerData.GetWindowPlacementStr());
				Registry.SetValue(AppKey, "DetailWindowPlacementStr", logViewerData.GetDetailWindowPlacementStr());

				var serializedDbConnsList = new List<string>();
				foreach (var dbConn in logViewerData.DbConns) {
					try {
						serializedDbConnsList.Add(XmlTools.Serialize(dbConn));
					} catch (Exception ex) {
						Console.WriteLine($"Error deserializing DbConn: {ex.Message}");
					}
				}

				Registry.SetValue(AppKey, "DbConns", XmlTools.Serialize(serializedDbConnsList));

			} catch (Exception ex) {
				Console.WriteLine($"Error in RegRepository.Save(): {ex.Message}");
			}
		}
	}
}
