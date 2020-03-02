using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    class MatchupModel
    {
        /// <summary>
        /// Represents the total amount of teams in the tournament
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();
        /// <summary>
        /// Represents the team that won the round
        /// </summary>
        public TeamModel Winner { get; set; }

        public int MatchupRound { get; set; }
    }
}
