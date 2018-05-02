using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyncTool.model
{
    class Companies
    {

        public string CompanyName { get; set; }
        public string DatabaseName { get; set; }
        public string Guid { get; set; }
        public string Path { get; set; }
        public string SchemaVersion { get; set; }
        public string ServerName { get; set; }

        public Companies()
        {
            
        }

        public Companies(string companyName, string databaseName, string guid, string path, string schemaVersion, string serverName)
        {
            CompanyName = companyName;
            DatabaseName = databaseName;
            Guid = guid;
            Path = path;
            SchemaVersion = schemaVersion;
            ServerName = serverName;

        }

    }
}

