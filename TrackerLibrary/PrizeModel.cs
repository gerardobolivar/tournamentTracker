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
        /// Represents the place number for this specific prize.
        /// </summary>
        public int PlaceNumer { get; set; }

        /// <summary>
        /// Represents the name of the place for this specific prize.
        /// </summary>
        public string PlaceName { get; set; }

        /// <summary>
        /// Represents the monetary amount assigned to this prize.
        /// </summary>
        public decimal PrizeAmount { get; set; }

        /// <summary>
        /// Represents a percentage used to calculate the monetary amount for this specific prize.
        /// </summary>
        public double PrizePercentage { get; set; }
    }
}
