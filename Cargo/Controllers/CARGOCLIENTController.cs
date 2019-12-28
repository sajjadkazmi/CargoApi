using Cargo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace Cargo.Controllers
{
    public class CARGOCLIENTController : Controller
    {
        // GET: CARGOCLIENT
        public ActionResult Index(int ? search)
        {
            if (search == null)
            {
                IEnumerable<mvcCargoModel> CargoList;
                HttpResponseMessage response = GlobalVariable.WebApiClient.GetAsync("CARGOCLIENT").Result;
                CargoList = response.Content.ReadAsAsync<IEnumerable<mvcCargoModel>>().Result;
                return View(CargoList);
            }
            else
            {


                IEnumerable<mvcCargoModel> CargoList;
                HttpResponseMessage response = GlobalVariable.WebApiClient.GetAsync("CARGOCLIENT").Result;
                CargoList = response.Content.ReadAsAsync<IEnumerable<mvcCargoModel>>().Result;
                //var NewList = CargoList.Where(x => x.PARTY_CODE == search || search == null).Select(b => new { b.PARTY_CODE, b.NAME }).ToList();
                var NewList = CargoList.Where(s => s.PARTY_CODE == search)
                              .Select(s => s);
                return View(NewList);
            }
        }
        public ActionResult AddOrEdit(int id = 0)
        {
            //Binding DropDowns
            IEnumerable<CAR_DEF_ACC_MGR> Acc_Mgr_List;
            HttpResponseMessage res = GlobalVariable.WebApiClient.GetAsync("CAR_DEF_ACC_MGR").Result;
            Acc_Mgr_List = res.Content.ReadAsAsync<IEnumerable<CAR_DEF_ACC_MGR>>().Result;
            ViewBag.Mgrlist = new SelectList(Acc_Mgr_List, "CODE", "NAME");

            IEnumerable<CAR_DEF_BUS_TYPE> BusType_List;
            HttpResponseMessage ress = GlobalVariable.WebApiClient.GetAsync("CAR_DEF_BUS_TYPE").Result;
            BusType_List = ress.Content.ReadAsAsync<IEnumerable<CAR_DEF_BUS_TYPE>>().Result;
            ViewBag.BusTypelist = new SelectList(BusType_List, "CODE", "DESC");


            IEnumerable<CAR_DEF_CLIENT_TYPE> ClientType_List;
            HttpResponseMessage resss = GlobalVariable.WebApiClient.GetAsync("CAR_DEF_CLIENT_TYPE").Result;
            ClientType_List = resss.Content.ReadAsAsync<IEnumerable<CAR_DEF_CLIENT_TYPE>>().Result;
            ViewBag.ClientTypelist = new SelectList(ClientType_List, "CODE", "DESC");
            
            if (id == 0)
                return View(new mvcCargoModel());
            else
            {
                HttpResponseMessage response = GlobalVariable.WebApiClient.GetAsync("CARGOCLIENT/" + id.ToString()).Result;
                //return View(response.Content.ReadAsAsync<IEnumerable<mvcEmployeeModel>>().Result);
                return View(response.Content.ReadAsAsync<mvcCargoModel>().Result);
            }
        }
        [HttpPost]
        public ActionResult AddOrEdit(mvcCargoModel car)
        {
         
            if (car.PARTY_CODE == 0)
            {
                HttpResponseMessage response = GlobalVariable.WebApiClient.PostAsJsonAsync("CARGOCLIENT", car).Result;

            }
            else
            {
                HttpResponseMessage response = GlobalVariable.WebApiClient.PutAsJsonAsync("CARGOCLIENT/" + car.PARTY_CODE, car).Result;
            }
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            HttpResponseMessage response = GlobalVariable.WebApiClient.DeleteAsync("CARGOCLIENT/"+id.ToString()).Result;
            return RedirectToAction("Index");
        }
    }
}