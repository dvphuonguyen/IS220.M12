using _2021_QuanLyThietBi.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _2021_QuanLyThietBi.Controllers
{
    public class NV_TBController : Controller
    {
        StoreContext context = new StoreContext("server=127.0.0.1; user id = root; password=; port=3306; database=db_framework_btth_2");

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult LietKeNVTB(string MaNhanVien)
        {
            return View(context.LietKeNVTB(MaNhanVien));
        }
        public IActionResult DeleteNVTB(string Id1, string Id2 , string Id3, string Id4 )
        {
            int count = context.DeleteNVTB(Id1, Id2, Id3, Id4);
            if (count > 0) ViewData["ThongBao"] = "Delete successfully";
            else ViewData["ThongBao"] = "Something wrong";
            return View();
        }
        public IActionResult  ViewNVTB(string Id1, string Id2, string Id3, string Id4)
        {
            return View(context.ViewNVTB(Id1, Id2, Id3, Id4));
        }
        public IActionResult UpdateNVTB(NV_TB nvtb)
        {
            int count = context.UpdateNVTB( nvtb);
            if (count > 0) ViewData["ThongBao"] = "Update successfully";
            else ViewData["ThongBao"] = "Something wrong";
            return View();
        }
    }
}
