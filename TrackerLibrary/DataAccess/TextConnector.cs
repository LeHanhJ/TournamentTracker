using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;
using TrackerLibrary.DataAccess.TextHelpers;

namespace TrackerLibrary.DataAccess
{

    public class TextConnector : IDataConnection
    {

        private const string PrizesFile = "PrizeModels.csv";

        // TODO - Wire up the CreatePrize for text files

        /// <summary>
        /// Setting up the connection to text files
        /// We will store each model in its own text file (FullFilePath and LoadFile from TextConnectionProcessor)
        /// > Instead of storing to the file name, we'll store to a path to where all the files go in one folder path (see constant above)
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {

            /// Load the text file of prizes and convert the text to a List<PrizeModel> 
            List<PrizeModel> prizes = PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModels();

            /// Find the max ID
            int currentId = prizes.OrderByDescending(x => x.Id).First().Id + 1;
            model.Id = currentId;

            /// Add new record with the new ID (max +1) to the list
            prizes.Add(model);


        }
    }
}
