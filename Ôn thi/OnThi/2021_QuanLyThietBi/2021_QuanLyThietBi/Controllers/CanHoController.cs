using _2021_QuanLyThietBi.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _2021_QuanLyThietBi.Controllers
{
    public class CanHoController : Controller
    {
        StoreContext context = new StoreContext("server=127.0.0.1; user id = root; password=; port=3306; database=db_framework_btth_2");
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult EnterCH()
        {
            return View();
        }
        public IActionResult InsertCH(CanHo ch)
        {
            int count = context.InsertCH(ch);
            if (count > 0) ViewData["ThongBao"] = "Insert successfully";
            else ViewData["ThongBao"] = "Somethig wrong";
            return View();
        }
    }
}
