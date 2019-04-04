using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMobile.Models;
using WebMobile.Models.db;
using WebMobile.Tools;
using WebMobile.ViewModel;

namespace WebMobile.Controllers
{
    public class MobilePageController : Controller
    {
        // GET: MobilePage
        //[HttpGet]
        public ActionResult Index()
        {

            ViewBag.esme = "Mohsen jafari";
            
            return View();
        }

        public ActionResult Mobiles()
        {
            MobileModels MobileModel = new MobileModels();
            
            var mobiles =  MobileModel.GetMobile();

            return View(mobiles);
            
        }
        [HttpGet]
        public ActionResult MobileRegister()
        {
            MobileModels MobileModel = new MobileModels();

            var brand = MobileModel.GetBrand();

            ViewBag.brand = brand;
            MobileViewModel MobileVM = new MobileViewModel();

            return View(MobileVM);
        }
        [HttpPost]
        public ActionResult MobileRegister(MobileViewModel MobileView)
        {
            MobileModels MobileModel = new MobileModels();
            var AMobile = MobileModel.ConvertMobileViewToMobile(MobileView);
            

            MobileModel.InsertMobile(AMobile);

            var brand = MobileModel.GetBrand();
            ViewBag.brand = brand;

            DateTimeConvert DateModel = new DateTimeConvert();
            var dateText =DateModel.ConvertDateTimeToString(MobileView.ProductionDate);
            MobileView.DateText = dateText;

            return View(MobileView);
        }
        public ActionResult TestjQuery()
        {
            return View();
        }
        public ActionResult TestjQuery2()
        {
            return View();
        }
        public ActionResult jQueryManipulating()
        {
            return View();
        }

    }
}