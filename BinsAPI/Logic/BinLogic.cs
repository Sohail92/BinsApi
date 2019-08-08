using BinsAPI.Models;
using System;
using System.Collections.Generic;

namespace BinsAPI.Logic
{
    internal class BinLogic : IBinLogic
    {
        public RubbishBin FindClosestBinCollection(List<RubbishBin> binCollections)
        {
            // Get todays date in the correct time zone
            DateTime currentDateTime = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, TimeZoneInfo.FindSystemTimeZoneById("GMT Standard Time"));

            // Look through possible bin collections for the closest.
            foreach (RubbishBin binIteration in binCollections)
                if ((binIteration.CollectionDate - currentDateTime).TotalDays <= 7)
                    return binIteration;

            // If we never found a bin collection then return a new RubbishBin object.
            return new RubbishBin();
        }

        public string FormatBinCollectionString(RubbishBin closestBinCollection)
        {
            string formattedBinCollectionOutput = string.Empty;

            if (closestBinCollection.CollectionDate != DateTime.MinValue)
            {
                formattedBinCollectionOutput = $"The closest bin collection is {closestBinCollection.CollectionDate.ToString("dd/MM/yyyy")} it is the black bin";
                if (closestBinCollection.IsBlue)
                    formattedBinCollectionOutput += (" and the blue bin.");
                else if (closestBinCollection.IsGreen)
                    formattedBinCollectionOutput += (" and the green bin.");
            }
            else
            {
                formattedBinCollectionOutput = "BinMan doesn't know when your next collection is, consider updating the software to the latest version.";
            }

            return formattedBinCollectionOutput;
        }
    }
}