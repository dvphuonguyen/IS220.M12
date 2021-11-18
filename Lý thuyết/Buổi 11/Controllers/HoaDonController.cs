using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DangVuPhuongUyen_19520345.Models;

namespace DangVuPhuongUyen_19520345.Controllers
{
    public class HoaDonController : Controller
    {
        StoreContext context = new StoreContext("server=127.0.0.1;user id=root;password=;port=3306;database=db_qlbh;");
        public ActionResult LietKeCacHD(NhanVien nhanVien)
        {
            return View(context.LietKeCacHD(nhanVien.MaNV));
        }
        public ActionResult DeleteHD(string id)
        {
            int count = context.DeleteHD(id);
            if (count > 0)
                ViewData["ThongBao"] = "Xóa thành công";
            else
                ViewData["ThongBao"] = "Xóa không thành công";
            return View();
        }

        public IActionResult ViewHD(string id)
        {
            HoaDon hd = context.ViewHD(id);
            ViewData.Model = hd;
            return View();
        }
    }
}
