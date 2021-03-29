using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    public class TeamModel
    {
        /// <summary>
        /// Represents a list of the different members that are part of the team
        /// </summary>
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();
        /// <summary>
        /// Represent a team member within the team
        /// </summary>
        public string TeamName { get; set; }
    }
}
