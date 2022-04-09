using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    public class SqlConnector : IDataConnection
    {
        // Saves new prixe to the database
        //TODO - Make the CreatePrize method actually save to the database
        public PrizeModel CreatePrize(PrizeModel model)
        {
            model.ID = 1;

            return model;
        }
    }
}
