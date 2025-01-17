using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class TournamentModel
    {
        /// <summary>
        /// Represents the of this specific tournament.
        /// </summary>
        public string TournamentName { get; set; }

        /// <summary>
        /// Represent monetary amount to able participate in this specific tournament.
        /// </summary>
        public decimal EntryFee { get; set; }

        /// <summary>
        /// Represents a list of teams playing in this specific tournament.
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();

        /// <summary>
        /// Represents a list of prizez for this specific tournament.
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();

        /// <summary>
        /// Represents a list of a list containing the rounds for this specific tournaments.
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();
    }
}
