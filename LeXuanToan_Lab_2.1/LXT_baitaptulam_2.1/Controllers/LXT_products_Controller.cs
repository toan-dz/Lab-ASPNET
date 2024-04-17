using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LXT_baitaptulam_2._1.Controllers
{
    public class ProductController : Controller
    {
        private dynamic songPath;

        public ActionResult Details(string songName, string songPath)
        {
            ViewBag.SongName = songName;
            return View();
        } 
        public ActionResult ShowProduct()
        {
            return View();
        }
        // GET: Action sửa sản phẩm
        public ActionResult EditProduct(int? productId)
        {
            ViewBag.SongPath = songPath;
            return View();
        }
        //GET: Action chi tiết sản phẩm
        public ActionResult DetailsProduct(string songName, int? productId)
        {
            ViewBag.SongName = songName;
            return View();
        }
        protected void DownloadButton_Click(object sender, EventArgs e)
        {
            string filePath = "/path/to/song.mp3";
            string fileName = "song.mp3";

            Response.ContentType = "audio/mpeg";
            Response.AppendHeader("Content-Disposition", "attachment; filename=" + fileName);
            Response.TransmitFile(Server.MapPath(filePath));
            Response.End();
        }
    }
}