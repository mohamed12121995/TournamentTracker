using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    public class PrizeModel
    {
        /// <summary>
        /// Represents the position of a team in the tournament and the prizeamount
        /// </summary>
        public int PlaceNumber { get; set; }
        public string PlaceName { get; set; }
        public decimal PrizeAmount { get; set; }
        public double PrizePercentage { get; set; }
    }
}
