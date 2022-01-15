using _1920_QuanLyDiemCachLy.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _1920_QuanLyDiemCachLy.Controllers
{
    public class DiemCachLyController : Controller
    {
        StoreContext context = new StoreContext("server=127.0.0.1;user id=root;password=;port=3306;database=db_framework_dcl;");
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult EnterDCL()
        {
            return View();
        }
        public IActionResult InsertDCL(DiemCachLy dcl)
        {
            int count = context.InsertDCL(dcl);
            if (count > 0) ViewData["ThongBao"] = "Insert successfully";
            else ViewData["ThongBao"] = "Something wrong";
            return View();
        }
        public IActionResult ComboBoxDCL()
        {
            return View(context.ComboBoxDCL());
        }
    }
}


