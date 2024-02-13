using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    internal interface IDataConnection
    {

        /// Anyone that implements this interface is a DataConnection
        /// whether it is a SQL connection or a text file connection
        /// or even a MySQL connection

        ///Specifying what methods, properties and items need to be here.
        ///

        PrizeModel CreatePrize(PrizeModel model);

    }
}
