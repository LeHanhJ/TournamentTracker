using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    internal class MatchupModel
    {
        /// <summary>
        /// Represents the number of entries for the matchup in the tournament
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();

        /// <summary>
        /// Represents the winner of the matchup
        /// </summary>
        public TeamModel? Winner { get; set; }

        /// <summary>
        /// Represents what number round we are in, in the matchup
        /// </summary>
        public int MatchupRound { get; set; }
    }
}
