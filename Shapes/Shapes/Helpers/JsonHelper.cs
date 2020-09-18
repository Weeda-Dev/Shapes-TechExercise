using Newtonsoft.Json;
using Shapes.Constants;
using Shapes.Interfaces;
using Shapes.Models;
using Shapes.Strategies;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Web;

namespace Shapes.Helpers
{
    public class JsonHelper : IJsonHelper
    {
        private readonly IGetItemJsonWebAPIStrategy _getJsonWebAPI;

        public JsonHelper()
        {
            _getJsonWebAPI = new GetItemJsonWebAPIStrategy();
        }

        public IEnumerable<Item> DeserializeJsonStringToTypeItem(string itemJsonString)
        {
            return JsonConvert.DeserializeObject<IEnumerable<Item>>(itemJsonString);
        }

        public string DownloadJsonStringByWebClient(WebClient webClient)
        {
            string WebURL_JsonItem = _getJsonWebAPI.GetJsonItemWebURL();
            return webClient.DownloadString(WebURL_JsonItem);
        }
    }
}