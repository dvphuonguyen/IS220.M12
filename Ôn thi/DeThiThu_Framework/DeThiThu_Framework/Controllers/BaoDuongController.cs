using DeThiThu_Framework.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeThiThu_Framework.Controllers
{
    public class BaoDuongController : Controller
    {
        DataContext context = new DataContext("server=127.0.0.1; user id = root; password=; port=3306; database=db_framework_thithu");
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ChonSX()
        {
            return View();
        }
        public IActionResult LietKeBD(string soXe)
        {
            return View(context.LietKeBD(soXe));
        }

        public IActionResult UpdateCVBD(string Id)
        {
            return View(context.LayBD(Id));
        }
        public IActionResult TBUpdate(BaoDuong bd)
        {
            int count = context.TBUpdate(bd);
            if (count > 0) ViewData["ThongBao"] = "Successful";
            else ViewData["ThongBao"] = "Something went wrong";
            return View();
        }
    }
}
