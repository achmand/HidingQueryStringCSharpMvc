using System.Web.Mvc;
using HidingQueryString.Models;

namespace HidingQueryString.Controllers
{
    // This is not secure, the main goal is to obfuscate the value passed in the query string
    public sealed class HideMeController : Controller
    {
        [HttpGet]
        public ActionResult GetStringList(StringListModel stringListModel)
        {
            var stringList = new StringListModel();
            return View(stringList);
        }

        [HttpGet]
        public ActionResult ShowValue(string value)
        {
            if (value == null)
            {
                return View("GetStringList" , new StringListModel());
            }
            var decodedValue = EncodeDecode.Decode(value);
            if (decodedValue == string.Empty)
            {
                return View("GetStringList", new StringListModel());
            }
            ViewBag.Decoded = decodedValue;
            return View();
        }
    }
}