﻿using Cargo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace Cargo.Controllers
{
    public class DEF_CLIENT_STATUSController : Controller
    {
        // GET: DEF_CLIENT_STATUS
        public ActionResult Index()
        {
            IEnumerable<CAR_DEF_CLIENT_STATUS> ClientStatusList;
            HttpResponseMessage response = GlobalVariable.WebApiClient.GetAsync("CAR_DEF_CLIENT_STATUS").Result;
            ClientStatusList = response.Content.ReadAsAsync<IEnumerable<CAR_DEF_CLIENT_STATUS>>().Result;
            return View(ClientStatusList);
        }

        public ActionResult AddOrEdit(int id = 0)
        {
            if (id == 0)
                return View(new CAR_DEF_CLIENT_STATUS());
            else
            {
                HttpResponseMessage response = GlobalVariable.WebApiClient.GetAsync("CAR_DEF_CLIENT_STATUS/" + id.ToString()).Result;
                return View(response.Content.ReadAsAsync<CAR_DEF_CLIENT_STATUS>().Result);
            }
        }
        [HttpPost]
        public ActionResult AddOrEdit(CAR_DEF_CLIENT_STATUS defClientstatus)
        {

            if (defClientstatus.CODE == 0)
            {
                HttpResponseMessage response = GlobalVariable.WebApiClient.PostAsJsonAsync("CAR_DEF_CLIENT_STATUS", defClientstatus).Result;

            }
            else
            {
                HttpResponseMessage response = GlobalVariable.WebApiClient.PutAsJsonAsync("CAR_DEF_CLIENT_STATUS/" + defClientstatus.CODE, defClientstatus).Result;
            }
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            HttpResponseMessage response = GlobalVariable.WebApiClient.DeleteAsync("CAR_DEF_CLIENT_STATUS/" + id.ToString()).Result;
            return RedirectToAction("Index");
        }
    }
}