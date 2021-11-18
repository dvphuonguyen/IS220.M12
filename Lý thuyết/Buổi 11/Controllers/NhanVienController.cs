using DangVuPhuongUyen_19520345.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DangVuPhuongUyen_19520345.Controllers
{
    public class NhanVienController : Controller
    {
        StoreContext context = new StoreContext("server=127.0.0.1;user id=root;password=;port=3306;database=db_qlbh;");
        public ActionResult ComboBoxNV()
        {
            return View(context.LietKeNV());
        }
    }
}
