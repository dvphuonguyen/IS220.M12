using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DangVuPhuongUyen_19520345.Models;

namespace DangVuPhuongUyen_19520345.Controllers
{
    public class SanPhamController : Controller
    {
        StoreContext context = new StoreContext("server=127.0.0.1;user id=root;password=;port=3306;database=db_qlbh;");
        // GET: SanPhamController
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Details(int id)
        {
            return View();
        }
        public ActionResult EnterSP()
        {
            return View();
        }
        public ActionResult InsertSP(SanPham sanPham)
        {
            int count;
            count = context.InsertSP(sanPham);

            if (count > 0)
                ViewData["ThongBao"] = "Insert thành công";
            else
                ViewData["ThongBao"] = "Insert không thành công";
            return View();
        }

        public ActionResult LietKeNSP()
        {
            return View();
        }

        public ActionResult LietKeCacSP(int SoSP)
        {
            return View(context.LietKeCacSP(SoSP));
        }

    }
}
