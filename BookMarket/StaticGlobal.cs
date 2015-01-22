using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace BookMarket
{
    public class StaticGlobal
    {
        public string Imgroute = ConfigurationManager.AppSettings["imgroute"];
    }
}