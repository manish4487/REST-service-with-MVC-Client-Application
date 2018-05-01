using MVCAPP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace MVCAPP.Controllers
{
    public class VehicleController : Controller
    {
        // GET: Vehicle
        public ActionResult Index()
        {

            IEnumerable<mvcVehicleModel> vehicleList;
            HttpResponseMessage response = Globalvariables.WebapiClient.GetAsync("http://localhost:61074/api/Vehicles").Result;
            vehicleList = response.Content.ReadAsAsync<IEnumerable<mvcVehicleModel>>().Result;

            return View(vehicleList);
        }


        public ActionResult Add(int id = 0)
        {
            return View(new mvcVehicleModel());

        }
        [HttpPost]
        public ActionResult Add(mvcVehicleModel veh)
        {

            HttpResponseMessage response = Globalvariables.WebapiClient.PostAsJsonAsync("http://localhost:61074/api/Vehicles",veh).Result;
            return RedirectToAction("Index");

        }

        public ActionResult Edit(int id=0)
        {
            return View(new mvcVehicleModel());

        }

        [HttpPost]
        public ActionResult Edit(mvcVehicleModel veh)
        {

            HttpResponseMessage response = Globalvariables.WebapiClient.PutAsJsonAsync("http://localhost:61074/api/Vehicles", veh).Result;
            return RedirectToAction("Index");

        }


        public ActionResult Delete(int id)
        {
            HttpResponseMessage response = Globalvariables.WebapiClient.DeleteAsync("http://localhost:61074/api/Vehicles"+id.ToString()).Result;
            TempData["SuccessMesage"] = "Deleted successfully";
            return RedirectToAction("Index");

        }
         
    }


}