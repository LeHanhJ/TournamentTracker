using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.DataAccess;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public static IDataConnection Connection { get; private set; }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.



        public static void InitializeConnections(DatabaseType db)
        {

            if (db == DatabaseType.Sql)
            {
                // TODO - Set up the sql connector properly
                SQLConnector sql = new SQLConnector();
                Connection = sql;
            }

            else if (db == DatabaseType.TextFile)
            {
                // TODO - create the text connection
                TextConnector txt = new TextConnector();
                Connection = txt;
            }

        }

        public static string CnnString(string name)
        {
            ///Go to app.config and get the connection string from look for Tournaments name
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
            

        }

    }

}
