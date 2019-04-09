using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMobile.Models;
using WebMobile.Models.db;
using WebMobile.Tools;
using WebMobile.ViewModel;
using WebMobile.Enum;
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
        [HttpGet]
        public ActionResult UserRegister()
        {
            UserViewModel UserVM = new UserViewModel();
            //Country CountryModel = new Country();

            
            ViewBag.Country = SelectItem();

            return View(UserVM);
        }
        [HttpPost]
        public ActionResult UserRegister(UserViewModel UserView)
        {

            
            if (ModelState.IsValid == true)
            {
                UserModels UserModel = new UserModels();
                var usermodel = UserModel.ConvertUserViewToUserEntity(UserView);

                UserModel.InsertUser(usermodel);
            }

            ViewBag.Country = SelectItem();
            return View(UserView);
        }

        public List<SelectListItem> SelectItem()
        {

            var CountryList = new List<Country>();

            CountryList.Add(new Country { CountryId = 1, CountryName = "iran" });
            CountryList.Add(new Country { CountryId = 2, CountryName = "Turkey" });
            CountryList.Add(new Country { CountryId = 3, CountryName = "Oman" });
            CountryList.Add(new Country { CountryId = 4, CountryName = "Qatar" });
            CountryList.Add(new Country { CountryId = 5, CountryName = "iraq" });

            List<SelectListItem> SelectListItemCountry = new List<SelectListItem>();
            SelectListItemCountry.Add(new SelectListItem() { Value = "0", Text = "Select Item" });
            foreach (var item in CountryList)
            {
                SelectListItem SelectM = new SelectListItem();

                SelectM.Value = item.CountryId.ToString();
                SelectM.Text = item.CountryName;

                //if (UserVM.Country == item.CountryId)
                //{
                //    SelectM.Selected = true;
                //}

                SelectListItemCountry.Add(SelectM);
            }

            

            return SelectListItemCountry;
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
        public ActionResult jQueryW3()
        {
            return View();
        }

    }
}