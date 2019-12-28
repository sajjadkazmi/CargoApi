using Cargo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace Cargo.Controllers
{
    public class DEF_CLIENT_TYPEController : Controller
    {
        // GET: DEF_CLIENT_TYPE
        public ActionResult Index()
        {
            IEnumerable<CAR_DEF_CLIENT_TYPE> ClientTypeList;
            HttpResponseMessage response = GlobalVariable.WebApiClient.GetAsync("CAR_DEF_CLIENT_TYPE").Result;
            ClientTypeList = response.Content.ReadAsAsync<IEnumerable<CAR_DEF_CLIENT_TYPE>>().Result;
            return View(ClientTypeList);
        }

        public ActionResult AddOrEdit(int id = 0)
        {
            if (id == 0)
                return View(new CAR_DEF_CLIENT_TYPE());
            else
            {
                HttpResponseMessage response = GlobalVariable.WebApiClient.GetAsync("CAR_DEF_CLIENT_TYPE/" + id.ToString()).Result;
                return View(response.Content.ReadAsAsync<CAR_DEF_CLIENT_TYPE>().Result);
            }
        }
        [HttpPost]
        public ActionResult AddOrEdit(CAR_DEF_CLIENT_TYPE defClient)
        {

            if (defClient.CODE == 0)
            {
                HttpResponseMessage response = GlobalVariable.WebApiClient.PostAsJsonAsync("CAR_DEF_CLIENT_TYPE", defClient).Result;

            }
            else
            {
                HttpResponseMessage response = GlobalVariable.WebApiClient.PutAsJsonAsync("CAR_DEF_CLIENT_TYPE/" + defClient.CODE, defClient).Result;
            }
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            HttpResponseMessage response = GlobalVariable.WebApiClient.DeleteAsync("CAR_DEF_CLIENT_TYPE/" + id.ToString()).Result;
            return RedirectToAction("Index");
        }
    }
}