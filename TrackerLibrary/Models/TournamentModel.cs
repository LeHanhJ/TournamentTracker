using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class TournamentModel
    {
        /// <summary>
        /// Name of the tournament
        /// </summary>
        public string? TournamentName { get; set; }

        /// <summary>
        /// The entry fee for participants to buy in to
        /// </summary>
        public decimal EntryFee { get; set; }

        /// <summary>
        /// A list of entered teams in the tournament
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();

        /// <summary>
        /// Amount of prizes in the tournament
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();

        /// <summary>
        /// List of rounds in the curent tournament, and a list of those rounds to see what round is next
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();
    }
}
