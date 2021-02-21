using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;

namespace Liazon.Common.LogViewer.Data
{
	[Serializable]
	public class LogViewerData
	{
		#region Fields

		private string _windowPlacementStr;
		private string _detailWindowPlacementStr;

		#endregion

		#region Constructor

		public LogViewerData()
		{
			this.DbConns = new List<DbConn>();
			this.TimerInterval = 3000;
		}

		#endregion

		[XmlAttribute]
		public string MRUConnStringName { get; set; }

		[XmlAttribute]
		public bool MRUSortAsc { get; set; }

		[XmlAttribute]
		public int TimerInterval { get; set; }

		[XmlAttribute]
		public bool AutoRefresh { get; set; }

		[XmlArray("DbConns")]
		[XmlArrayItem("DbConn", typeof(DbConn))]
		public List<DbConn> DbConns { get; set; }

		[XmlElement("WindowPlacement")]
		public XmlCDataSection WindowPlacement
		{
			get {
				XmlDocument doc = new XmlDocument();
				return doc.CreateCDataSection(_windowPlacementStr);
			}
			set {
				_windowPlacementStr = value.Value;
			}
		}

		public string GetWindowPlacementStr()
		{
			return _windowPlacementStr;
		}

		public void SetWindowPlacementStr(string windowPlacementStr)
		{
			_windowPlacementStr = windowPlacementStr;
		}

		[XmlElement("DetailWindowPlacement")]
		public XmlCDataSection DetailWindowPlacement
		{
			get {
				XmlDocument doc = new XmlDocument();
				return doc.CreateCDataSection(_detailWindowPlacementStr);
			}
			set {
				_detailWindowPlacementStr = value.Value;
			}
		}

		public string GetDetailWindowPlacementStr()
		{
			return _detailWindowPlacementStr;
		}

		public void SetDetailWindowPlacementStr(string detailWindowPlacementStr)
		{
			_detailWindowPlacementStr = detailWindowPlacementStr;
		}
	}
}
