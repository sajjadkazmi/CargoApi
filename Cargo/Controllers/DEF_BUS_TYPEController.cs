using Cargo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace Cargo.Controllers
{
    public class DEF_BUS_TYPEController : Controller
    {
        // GET: DEF_BUS_TYPE
        public ActionResult Index()
        {
            IEnumerable<CAR_DEF_BUS_TYPE> BusTypeList;
            HttpResponseMessage response = GlobalVariable.WebApiClient.GetAsync("CAR_DEF_BUS_TYPE").Result;
            BusTypeList = response.Content.ReadAsAsync<IEnumerable<CAR_DEF_BUS_TYPE>>().Result;
            return View(BusTypeList);
        }

        public ActionResult AddOrEdit(int id = 0)
        {
            if (id == 0)
                return View(new CAR_DEF_BUS_TYPE());
            else
            {
                HttpResponseMessage response = GlobalVariable.WebApiClient.GetAsync("CAR_DEF_BUS_TYPE/" + id.ToString()).Result;
                return View(response.Content.ReadAsAsync<CAR_DEF_BUS_TYPE>().Result);
            }
        }
        [HttpPost]
        public ActionResult AddOrEdit(CAR_DEF_BUS_TYPE defClientstatus)
        {

            if (defClientstatus.CODE == 0)
            {
                HttpResponseMessage response = GlobalVariable.WebApiClient.PostAsJsonAsync("CAR_DEF_BUS_TYPE", defClientstatus).Result;

            }
            else
            {
                HttpResponseMessage response = GlobalVariable.WebApiClient.PutAsJsonAsync("CAR_DEF_BUS_TYPE/" + defClientstatus.CODE, defClientstatus).Result;
            }
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            HttpResponseMessage response = GlobalVariable.WebApiClient.DeleteAsync("CAR_DEF_BUS_TYPE/" + id.ToString()).Result;
            return RedirectToAction("Index");
        }
    }
}