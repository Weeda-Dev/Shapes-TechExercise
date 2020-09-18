using Shapes.Constants;
using Shapes.Interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace Shapes.Strategies
{
    public class GetItemJsonWebAPIStrategy : IGetItemJsonWebAPIStrategy
    {
        public string GetJsonItemWebURL()
        {
            return ConfigurationManager.AppSettings[AppsettingKeysConstants.JSON_ITEM_API_URL_KEY];
        }
    }
}