using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BinsAPI.Models
{
    public class RubbishBin
    {
        public DateTime CollectionDate { get; set; }

        public bool IsGreen { get; set; }

        public bool IsBlue { get; set; }

        public bool IsBlack => true;
    }
}