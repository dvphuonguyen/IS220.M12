using DeThiThu_Framework.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeThiThu_Framework.Controllers
{
    public class CongViecController : Controller
    {
        DataContext context = new DataContext("server=127.0.0.1; user id = root; password=; port=3306; database=db_framework_thithu");

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult EnterCV()
        {
            return View();
        }
        public IActionResult InsertCV(CongViec cv)
        {
            int count = context.InsertCV(cv);
            if (count > 0) ViewData["ThongBao"] = "Successful";
            else ViewData["ThongBao"] = "Something went wrong";
            return View();
        }
    }
}
