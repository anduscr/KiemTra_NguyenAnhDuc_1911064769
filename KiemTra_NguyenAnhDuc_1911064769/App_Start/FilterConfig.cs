using System.Web;
using System.Web.Mvc;

namespace KiemTra_NguyenAnhDuc_1911064769
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
