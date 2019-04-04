using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebMobile.ViewModel
{
    public class MobileViewModel
    {
        public string Name { get; set; }
        public int BrandId { get; set; }
        public DateTime? ProductionDate { get; set; }
        public int? Weight { get; set; }
        public bool Otg { get; set; }
        public int? UserId { get; set; }
        public string BrandName { get; set; }
        public string DateText { get; set; }
    }
}