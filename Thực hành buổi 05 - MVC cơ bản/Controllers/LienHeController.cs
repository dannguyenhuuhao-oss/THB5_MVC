using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Thực_hành_buổi_05___MVC_cơ_bản.Controllers
{
    public class LienHeController : Controller
    {
        // GET: LienHe
        public ActionResult LienHe()
        {
            return View();
        }
        public ActionResult KetQua()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(
            string chuDe,
            string tieuDe,
            string noiDung,
            string hoTen,
            string email,
            string soDienThoai)
        {
            ViewBag.ChuDe = chuDe;
            ViewBag.TieuDe = tieuDe;
            ViewBag.NoiDung = noiDung;
            ViewBag.HoTen = hoTen;
            ViewBag.Email = email;
            ViewBag.SoDienThoai = soDienThoai;

            return View("KetQua");
        }
    }
}