using System.Collections.Generic;
using System.Drawing;

namespace LogViewer.Config
{
	public class AppConfig
	{
		public AppConfig()
		{
			DbConns = new List<DbConn>();
		}

		public bool MRUSortAsc { get; set; }
		public int TimerIntervalMs { get; set; }
		public bool AutoRefresh { get; set; }
		public List<DbConn> DbConns { get; set; }

		public Point WindowPosition { get; set; }	
		public Size WindowSize { get; set; }

		public List<int> ColWidths { get; set; } = new List<int>();
	}
}
