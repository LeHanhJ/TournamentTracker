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
        private const string db = "Tournaments";

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
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
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

            /// <summary>
            ///  Click da button and create da person
            /// </summary>
            /// <param name="model"></param>
            /// <returns></returns>
        public PersonModel CreatePerson(PersonModel model)
        {
            /// Connects the CreatePerson method to the database to write to
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                /// Specifying how to add inputs entered by user in the model to the database
                var p = new DynamicParameters();
                p.Add("@FirstName", model.FirstName);
                p.Add("@LastName", model.LastName);
                p.Add("@EmailAddress", model.EmailAddress);
                p.Add("@CellphoneNumber", model.PhoneNumber);
                p.Add("@id", 0, DbType.Int32, direction: ParameterDirection.Output);

                /// Inserts the information into the table
                connection.Execute("dbo.spPeople_Insert", p, commandType: CommandType.StoredProcedure);
                /// The Id class is populated by the current Id number in the table
                model.Id = p.Get<int>("@id");

                return model;

            }
        }

            /// <summary>
            ///  Grabbing all the information from the populated table
            /// </summary>
            /// <returns></returns>
        public List<PersonModel> GetPerson_All()
        {
            /// the output is of type List<PersonModel>
            List<PersonModel> output;


            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                /// Querying the "dbo.spPeople_GetAll" stored procedure connected
                /// to the database (db) and sorts it in a list.
                /// 
                output = connection.Query<PersonModel>("dbo.spPeople_GetAll").ToList();
            }

            /// Returns the output, which is the Query we grabbed
            return output;
        }


    }
}
