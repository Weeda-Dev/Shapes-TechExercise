using Newtonsoft.Json;
using Shapes.Helpers;
using Shapes.Interfaces;
using Shapes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;

namespace Shapes.Strategies
{
    public class ExtractItemDataFromJsonWebAPIStrategy : IExtractItemDataStrategy
    {
        private readonly IJsonHelper _jsonHelper;
        public ExtractItemDataFromJsonWebAPIStrategy()
        {
            _jsonHelper = new JsonHelper();
        }

        public IEnumerable<Item> GetAllDeserializedItems()
        {
            IEnumerable<Item> itemDeserialized;
            using (var webClient = new WebClient())
            {
                string itemJsonString = _jsonHelper.DownloadJsonStringByWebClient(webClient);
                itemDeserialized = _jsonHelper.DeserializeJsonStringToTypeItem(itemJsonString);
            }

            return itemDeserialized;
        }

    }
}