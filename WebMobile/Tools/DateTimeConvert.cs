using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebMobile.ViewModel;

namespace WebMobile.Tools
{
    public class DateTimeConvert
    {
        public string ConvertDateTimeToString(DateTime? Date)
        {

            string date = "";
            if (Date.HasValue == true)
            {
                string Month = "";
                string Day = "";
                if (Date.Value.Month < 10)
                {
                    Month = "0" + Date.Value.Month.ToString();
                }
                else
                {
                    Month = Date.Value.Month.ToString();
                }
                if (Date.Value.Day < 10)
                {
                    Day = "0" + Date.Value.Day.ToString();
                }
                else
                {
                    Day = Date.Value.Day.ToString();
                }

                date = Date.Value.Year.ToString() + "-" +
                       Month + "-" + Day;

            }
            return date;
        }
    }
}