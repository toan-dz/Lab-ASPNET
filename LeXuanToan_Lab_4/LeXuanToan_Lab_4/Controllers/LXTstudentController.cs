using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LeXuanToan_Lab_4.Controllers
{
    /// <summary>
    /// Author: Lê Xuân Toàn 
    /// Class : K22CNT2
    /// </summary>
    public class LXTstudentController : Controller
    {
        // GET: LXTstudent
        public ActionResult Index()
        {
            ViewBag.name = "Lê Xuân Toàn ";
            ViewData["Birthday"] = "31/03/2004";
            TempData["Phone"] = "0842806904";
            return View();
        }
        public ActionResult Details()
        {
            string lxtStr = "";
            lxtStr += "<h3> Họ và Tên: Lê Xuân Toàn </h3>";
            lxtStr += "<p> mã số : 2210900069";
            lxtStr += "<p>Địa chỉ mail : ltoan5861@gmail.com";
            ViewBag.Details = lxtStr;
            return View("chiTiet");
        }
        public ActionResult NgonNgurzor()
        {
            string[] names = { "a", "b", "c" };
            ViewBag.names = names;
            return View("");

        }
        public ActionResult AddnewStudent()
        {

            return View("");

        }
        public ActionResult AddnewStudent(FormCollection form)
        {
            string fullname = form["fullName"];
            string masv = form["maSV"];
            string taikhoan = form["taikhoan"];
            string MatKhau = form["MatKhau"];
            string lxtStr = "<h3>" +fullname +"</h3>";
            lxtStr += "<p>" + masv;
            lxtStr += "<p>" + taikhoan;
            lxtStr += "<p>" + MatKhau;
            ViewBag.info = lxtStr;
            return View("Ketqua");

        }
    }
}