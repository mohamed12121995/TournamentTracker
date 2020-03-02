using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    class MatchupEntryModel
    {
        /// <summary>
        /// Represents one team in the matchup
        /// </summary>
        public TeamModel TeamCompeting { get; set; }
        /// <summary>
        /// Represents the score for this particular team
        /// </summary>
        public Double Score { get; set; }
        public MatchupModel ParentMatchup { get; set; }
    }
}
