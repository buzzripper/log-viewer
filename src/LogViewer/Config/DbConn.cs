using System;

namespace LogViewer.Config;

public class DbConn
{
	public Guid Id { get; set; }
	public string Name { get; set; }
	public string ConnString { get; set; }
	public bool IsDefault { get; set; }

	public override string ToString()
	{
		return Name;
	}
}