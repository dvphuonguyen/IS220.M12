using _1920_QuanLyDiemCachLy.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _1920_QuanLyDiemCachLy.Controllers
{
    public class CongNhanController : Controller
    {
        StoreContext context = new StoreContext("server=127.0.0.1;user id=root;password=;port=3306;database=db_framework_dcl;");
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult NhapSL()
        {
            return View();
        }
        public IActionResult LietKeSL(int soLan)
        {
            return View(context.LietKeSL(soLan));
        }
        public IActionResult LietKeCN(string MaDiemCachLy)
        {
            return View(context.LietKeCN(MaDiemCachLy));
        }
        public IActionResult ViewCN(string MaCongNhan)
        {
            return View(context.ViewCN(MaCongNhan));
        }
        public IActionResult DeleteCN(string MaCongNhan)
        {
            int count = context.DeleteCN(MaCongNhan);
            if (count > 0) ViewData["ThongBao"] = "Delete successfully";
            else ViewData["ThongBao"] = "Something wrong";
            return View();
        }
        public IActionResult UpdateCN(CongNhan cn)
        {
            int count = context.UpdateCN(cn);
            if (count > 0) ViewData["ThongBao"] = "Update successfully";
            else ViewData["ThongBao"] = "Something wrong";
            return View();
        }
    }
}
