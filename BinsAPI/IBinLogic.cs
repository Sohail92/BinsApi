using BinsAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinsAPI
{
    internal interface IBinLogic
    {
        RubbishBin FindClosestBinCollection(List<RubbishBin> binCollections);
        string FormatBinCollectionString(RubbishBin closestBinCollection);
    }
}
