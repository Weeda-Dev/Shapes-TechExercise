using Microsoft.Ajax.Utilities;
using Newtonsoft.Json;
using Shapes.Helpers;
using Shapes.Interfaces;
using Shapes.Models;
using Shapes.Strategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Shapes.Controllers
{
    public class HomeController : Controller
    {
        private readonly IExtractItemDataStrategy _extractData;
        public HomeController()
        {
            _extractData = new ExtractItemDataFromJsonWebAPIStrategy();
        }
        public ActionResult Index()
        {
            IEnumerable<Item> items = _extractData.GetAllDeserializedItems();

            if (items != null)
            {
                return View(items);
            }
            else
            {
                return new EmptyResult();
            }
        }

        public ActionResult Details(string itemName)
        {
            if (!itemName.IsNullOrWhiteSpace()) {
                IEnumerable<Item> items = _extractData.GetAllDeserializedItems();
                Item matchItemByName = items.Where(x => x.name.ToLower().Equals(itemName.ToLower())).FirstOrDefault();

                return PartialView("_Details", matchItemByName);
            }
            else
            {
                return new EmptyResult();
            }
        }
    }
}