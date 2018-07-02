using AGAServerBackend.Context;
using AGAServerBackend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AGAServerBackend.Controllers
{
    public class DailyPartController : Controller
    {
        // GET: DailyPart
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public JsonResult Add(DailyPart dailyPart)
        {
            using (var context = new ApplicationDataContext())
            {
                if (ModelState.IsValid)
                {
                    try
                    {
                        return Json(dailyPart, JsonRequestBehavior.AllowGet);
                    }
                    catch (Exception error)
                    {
                        return Json(error.Message);
                    }
                }
                return Json(dailyPart);
            }
            //var errors = ModelState.Keys.Where(k => ModelState[k].Errors.Count > 0)
            //.Select(k => new { propertyName = k, errorMessage = ModelState[k].Errors[0].ErrorMessage });
            //return Json(Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState));
            //return Json(ModelState.Values.SelectMany(v => v.Errors));
            //var modelStateErrors = this.ModelState.Keys.SelectMany(key => this.ModelState[key].Errors);
            //var modelStateErrors = this.ModelState.Keys.Select(k => new { propertyName = k, errorMessage = ModelState[k].Errors });

        }

    }
}