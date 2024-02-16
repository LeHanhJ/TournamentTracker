using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class PrizeModel
    {
        /// <summary>
        /// Unique identifier for the prize
        /// </summary>
        public int Id { get; set; }


        /// <summary>
        /// The place number of the prize given
        /// </summary>
        public int PlaceNumber { get; set; }

        //The place name of the prize given (first, second, third, etc)
        public string? PlaceName { get; set; }

        /// <summary>
        /// The prize amount the participant will recieve
        /// </summary>
        public decimal PrizeAmount { get; set; }

        /// <summary>
        /// The percentage of the prize that will go to the winner
        /// </summary>
        public double PrizePercentage { get; set; }
    }
}
