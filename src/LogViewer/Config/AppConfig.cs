using LogViewer.Data;
using System.Collections.Generic;
using System.Drawing;

namespace LogViewer.Config
{
	public class AppConfig
	{
		public AppConfig()
		{
			DbConns = new List<DbConn>();
			TimerIntervalSecs = 1500;
		}

		public string MRUConnStringName { get; set; }
		public bool MRUSortAsc { get; set; }
		public int TimerIntervalSecs { get; set; }
		public bool AutoRefresh { get; set; }
		public List<DbConn> DbConns { get; set; }

		public Point WindowPosition { get; set; }	
		public Size WindowSize { get; set; }	
	}
}
