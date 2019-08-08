using BinsAPI.Models;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace BinsAPI.Logic.DAL
{
    internal class BinData
    {
        internal List<RubbishBin> GetBinCollections()
        {
            List<RubbishBin> binCollections = new List<RubbishBin>
            {
                // January
                new RubbishBin{CollectionDate = Convert.ToDateTime("03/01/2019", CultureInfo.CreateSpecificCulture("en-GB"))},
                new RubbishBin{CollectionDate = Convert.ToDateTime("09/01/2019", CultureInfo.CreateSpecificCulture("en-GB")), IsBlue = true},
                new RubbishBin{CollectionDate = Convert.ToDateTime("16/01/2019", CultureInfo.CreateSpecificCulture("en-GB"))},
                new RubbishBin{CollectionDate = Convert.ToDateTime("23/01/2019", CultureInfo.CreateSpecificCulture("en-GB")), IsBlue = true},
                new RubbishBin{CollectionDate = Convert.ToDateTime("30/01/2019", CultureInfo.CreateSpecificCulture("en-GB"))},
                // February
                new RubbishBin{CollectionDate = Convert.ToDateTime("06/02/2019", CultureInfo.CreateSpecificCulture("en-GB")), IsBlue = true},
                new RubbishBin{CollectionDate = Convert.ToDateTime("13/02/2019", CultureInfo.CreateSpecificCulture("en-GB"))},
                new RubbishBin{CollectionDate = Convert.ToDateTime("20/02/2019", CultureInfo.CreateSpecificCulture("en-GB")), IsBlue = true},
                new RubbishBin{CollectionDate = Convert.ToDateTime("27/02/2019", CultureInfo.CreateSpecificCulture("en-GB")) },
                // March
                new RubbishBin{CollectionDate = Convert.ToDateTime("06/03/2019", CultureInfo.CreateSpecificCulture("en-GB")), IsBlue = true},
                new RubbishBin{CollectionDate = Convert.ToDateTime("13/03/2019", CultureInfo.CreateSpecificCulture("en-GB"))},
                new RubbishBin{CollectionDate = Convert.ToDateTime("20/03/2019", CultureInfo.CreateSpecificCulture("en-GB")), IsBlue = true},
                new RubbishBin{CollectionDate = Convert.ToDateTime("27/03/2019", CultureInfo.CreateSpecificCulture("en-GB")) },
            };
            return binCollections;
        }
    }
}