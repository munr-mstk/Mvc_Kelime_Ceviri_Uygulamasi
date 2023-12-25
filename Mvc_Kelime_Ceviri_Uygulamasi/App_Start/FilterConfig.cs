using System.Web;
using System.Web.Mvc;

namespace Mvc_Kelime_Ceviri_Uygulamasi
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
