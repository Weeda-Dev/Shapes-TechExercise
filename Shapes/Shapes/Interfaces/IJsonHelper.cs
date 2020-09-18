using Shapes.Models;
using System.Collections.Generic;
using System.Net;

namespace Shapes.Interfaces
{
    public interface IJsonHelper
    {
        IEnumerable<Item> DeserializeJsonStringToTypeItem(string itemJsonString);
        string DownloadJsonStringByWebClient(WebClient webClient);
    }
}