using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    public class TournamentModel
    {
        /// <summary>
        /// Represents the Tournament name
        /// </summary>
        public string TournamentName { get; set; }
        /// <summary>
        /// Represents the Tournament entry fee
        /// </summary>
        public decimal EntryFee { get; set; }
        /// <summary>
        /// Represents the total amount of teams that have entered the tournament
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();
        /// <summary>
        /// Represents a list of teams and their prizes based on the position
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();
        /// <summary>
        /// list of prizes
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();
        /// <summary>
        /// list of matchups within a specific round of the tournament
        /// </summary>

    }
}
