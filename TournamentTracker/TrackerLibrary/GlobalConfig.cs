using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        /// <summary>
        /// List of IDataConnection allows to connect to multiple data sources
        /// </summary>
        public static List<IDataConnection> Connections { get; private set; } = new List<IDataConnection>();
    
        public static void InitializeConnections(bool database, bool textFiles)
        {// wire up the classes
            if(database)
            {
                // TODO - Set up the SQL connector properly
                SqlConnector sql = new SqlConnector();
                Connections.Add(sql);
            }

            if (textFiles)
            {
                // TODO - Create the text connection
                TextConnection text = new TextConnection();
                Connections.Add(text);
            }

        }
    }
}
