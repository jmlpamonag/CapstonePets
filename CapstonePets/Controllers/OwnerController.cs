using CapstonePets.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CapstonePets.Controllers
{
    public class OwnerController : Controller
    {
        [HttpGet]
        public ActionResult Create()
        {
            //TO DO: These are just hard coded data
            OwnerModel ownerModel = new OwnerModel();

            ownerModel.StateList = new List<StateModel>()
            {
                new StateModel(){intStateID=1,strState="OH"},
                new StateModel(){intStateID=2,strState="KY"}
            };

            ownerModel.GenderList = new List<GenderModel>()
            {
                new GenderModel(){intGenderID=1,strGender="Female"},
                new GenderModel(){intGenderID=2,strGender="Male"}
            };

            return View(ownerModel);
        }

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
