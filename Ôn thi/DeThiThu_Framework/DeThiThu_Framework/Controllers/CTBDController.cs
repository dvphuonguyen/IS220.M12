using DeThiThu_Framework.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeThiThu_Framework.Controllers
{
    public class CTBDController : Controller
    {

        DataContext context = new DataContext("server=127.0.0.1; user id = root; password=; port=3306; database=db_framework_thithu");
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ViewCVBD(string Id)
        {
            ViewBag.bd = context.LayBD(Id);
            return View(context.ViewCTBD(Id));
        }
        public IActionResult DeleteCVBD(string Id1, string Id2)
        {
            int count = context.DeleteCVBD(Id1, Id2);
            if (count > 0) ViewData["ThongBao"] = "Successful";
            else ViewData["ThongBao"] = "Wrong";
            return View();
        }
    }
}
