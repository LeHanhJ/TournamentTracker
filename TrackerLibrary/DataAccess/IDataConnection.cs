using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess
{
    public interface IDataConnection
    {
        
        PrizeModel CreatePrize(PrizeModel model);

        PersonModel CreatePerson(PersonModel model);

        /// <summary>
        /// Gathers all Person's information
        /// </summary>
        /// <returns>
        /// "Get" is used for any select statements that are being referenced back
        /// so it does not have a return value
        /// </returns>
        List<PersonModel> GetPerson_All();


    }
}
