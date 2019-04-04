using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebMobile.Models.db;
using WebMobile.ViewModel;
using System.Data.Entity;
namespace WebMobile.Models
{
    public class MobileModels
    {
        public List<MobileViewModel> GetMobile()
        {
            MobileSystemEntities db = new MobileSystemEntities();
            
           var MobileEntity = db.Mobiles.ToList();
           var MobileView = ConvertMobileToViewModel(MobileEntity);
            return MobileView;

        }


        public List<BrandViewModel> GetBrand()
        {
            MobileSystemEntities db = new MobileSystemEntities();
            var brand = db.Brands.ToList();

            var brandViewList = ConvertBrandToViewModel(brand);
            return brandViewList;
        }

         public List<BrandViewModel> ConvertBrandToViewModel(List<Brand> BrandEntity )
        {
            List<BrandViewModel> brandViewList = new List<BrandViewModel>();
            foreach (var item in BrandEntity)
            {
                BrandViewModel brandViewModel = new BrandViewModel();

                brandViewModel.BrandName = item.BrandName;
                brandViewModel.Id = item.Id;

                brandViewList.Add(brandViewModel);
            }
            return brandViewList;
        }

        public List<MobileViewModel> ConvertMobileToViewModel(List<Mobile> MobileEntity)
        {
            List<MobileViewModel> brandViewList = new List<MobileViewModel>();
            foreach (var item in MobileEntity)
            {
                MobileViewModel MobileVM = new MobileViewModel();
                
                MobileVM.Name = item.Name;
                MobileVM.ProductionDate = item.ProductionDate;
                MobileVM.BrandId = item.BrandId;
                MobileVM.Weight = item.Weight;
                MobileVM.Otg = item.Otg.HasValue == false ? false : item.Otg.Value;
                MobileVM.BrandName = item.Brand.BrandName;

                brandViewList.Add(MobileVM);
            }
            return brandViewList;
        }

        public void InsertMobile(Mobile AMobile)
        {
            MobileSystemEntities db = new MobileSystemEntities();
            db.Mobiles.Add(AMobile);
            db.SaveChanges();
        }

        public Mobile ConvertMobileViewToMobile(MobileViewModel MobileVM)
        {
            Mobile AMobile = new Mobile();

            AMobile.Name = MobileVM.Name;
            AMobile.ProductionDate = MobileVM.ProductionDate;
            AMobile.BrandId = MobileVM.BrandId;
            AMobile.Weight = MobileVM.Weight;
            AMobile.Otg = MobileVM.Otg;

            return AMobile;
        }
    }
}