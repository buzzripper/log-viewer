using System;

namespace ProData.Infrastructure.LogViewer
{
	public class LogItem
	{
		public Guid RowId { get; set; }
		public DateTime TimeStamp { get; set; }
		public int LevelValue { get; set; }
		public string ApplicationName { get; set; }
		public string UserName { get; set; }
        public string SourceContext { get; set; }
		public string SourceClass { get; set; }
		public string CorrelationId { get; set; }
		public string Message { get; set; }
		public string Exception { get; set; }

		public bool HasException { get; set; }
		public bool ExceptionWasLoaded { get; set; }
	}
}
