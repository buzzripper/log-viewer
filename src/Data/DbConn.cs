using System;
using System.Xml.Serialization;

namespace Liazon.Common.LogViewer.Data
{
    [Serializable]
    public class DbConn
    {
        [XmlAttribute]
        public string Name { get; set; }
        [XmlAttribute]
        public string ServerName { get; set; }
        [XmlAttribute]
        public string DatabaseName { get; set; }
        [XmlAttribute]
        public bool IsIntegratedSecurity { get; set; }
        [XmlAttribute]
        public string Username { get; set; }
        [XmlAttribute]
        public string Password { get; set; }
		[XmlAttribute]
		public bool IsDefault { get; set; }

		public string ConnectionString
        {
            get
            {
                if (this.IsIntegratedSecurity)
                    return string.Format("Server={0};Database={1};Integrated Security=true;MultipleActiveResultSets=True;App=LogViewer;Connection Timeout=5;",
                        this.ServerName, this.DatabaseName);

                return string.Format("Server={0};Database={1};User Id={2};Password={3};MultipleActiveResultSets=True;App=LogViewer;Connection Timeout=5;",
                    this.ServerName, this.DatabaseName, this.Username, this.Password);
            }
        }

        public DbConn Clone()
        {
            DbConn clone = new DbConn();
            clone.Name = this.Name;
            clone.ServerName = this.ServerName;
            clone.DatabaseName = this.DatabaseName;
            clone.IsIntegratedSecurity = this.IsIntegratedSecurity;
            clone.Username = this.Username;
            clone.Password = this.Password;

            return clone;
        }

        public void Apply(DbConn datasource)
        {
            this.Name = datasource.Name;
            this.ServerName = datasource.ServerName;
            this.DatabaseName = datasource.DatabaseName;
            this.IsIntegratedSecurity = datasource.IsIntegratedSecurity;
            this.Username = datasource.Username;
            this.Password = datasource.Password;
			this.IsDefault = datasource.IsDefault;
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}