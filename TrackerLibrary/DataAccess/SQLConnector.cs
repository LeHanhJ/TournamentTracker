using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess
{
    public class SQLConnector : IDataConnection
    {
        /// TODO - Make the CreatePrize method actually save to the database
        /// <summary>
        /// Saves a new prize to the database
        /// </summary>
        /// <param name="model">The prize information</param>
        /// <returns> The prize information, including the unique identifier. </returns>
        /// \
        public PrizeModel CreatePrize(PrizeModel model)
        {

            //  Making a new connection to the database; using statement so we can pass in one at a time and does not overload processing time
            // We are making a new SQL connection from GlobalConfig, and passing in Tournaments into CnnString() method that we've created
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Tournaments")))
            {
                var p = new DynamicParameters();
                p.Add("@PlaceNumber", model.PlaceNumber);
                p.Add("@PlaceName", model.PlaceName);
                p.Add("@PrizeAmount", model.PrizeAmount);
                p.Add("@PrizePercentage", model.PrizePercentage);
                //id type is an int32, and the direction of the id is output because we are not inputting anything in the id parameter
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                // Run a stored procedure and assume nothing will come back because of EXECUTE (and probably because of NOCOUNT ON?)
                // p is as above where we are passing in all of them (except id, which we are outputting
                // CommandType tells SQLcommand how to interpret the string you pass into it (aka dbo.Prizes_Insert)
                // In this case, it is interpreting it as a stored procedure that can be run over and over again
                connection.Execute("dbo.spPrizes_Insert", p, commandType: CommandType.StoredProcedure);

                model.Id = p.Get<int>("@id");

                return model;

            }
        }

    }
}
