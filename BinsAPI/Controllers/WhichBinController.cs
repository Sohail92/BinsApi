using System;
using System.Collections.Generic;
using System.Globalization;
using System.Web.Mvc;
using BinsAPI.Logic;
using BinsAPI.Logic.DAL;
using BinsAPI.Models;

namespace BinsAPI.Controllers
{
    public class WhichBinController : Controller
    {
        private BinLogic binLogic = new BinLogic();
        private BinData binData = new BinData();

        public string Bins()
        {
            // Get all of the possible bin collections
            List<RubbishBin> binCollections = binData.GetBinCollections();
            
            // Get the closest bin collection to today
            RubbishBin closestBinCollection = binLogic.FindClosestBinCollection(binCollections);
            
            // Format return string with info obtained and return
            return binLogic.FormatBinCollectionString(closestBinCollection);
        }
    }
}