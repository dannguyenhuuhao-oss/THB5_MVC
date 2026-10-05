using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Thực_hành_buổi_05___MVC_cơ_bản.Controllers
{
    public class QuanLySachController : Controller
    {
        // GET: QuanLySach
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ThemSanPham()
        {
            return View();
        }
        public ActionResult DanhSach()
        {
            return View();
        }

        public ActionResult SuaThongTinSanPham()
        {
            return View();
        }
    }
}