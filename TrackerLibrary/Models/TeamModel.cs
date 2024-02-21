using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class TeamModel
    {
        /// <summary>
        /// Represents a list of teammembers in a team... in the tournament.
        /// </summary>
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();

        /// <summary>
        /// The team name of the participating team
        /// </summary>
        public string? TeamName { get; set; }
    }
}
