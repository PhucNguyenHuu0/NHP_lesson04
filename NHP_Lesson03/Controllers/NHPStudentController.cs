using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NHP_Lesson03.Controllers
{
    /// <summary>
    /// Author: Nguyen Huu Phuc
    /// Class: K22CNT1
    /// </summary>
    public class NHPStudentController : Controller
    {
        // GET: NHPStudent
        public ActionResult Index()
        {
            // Truyen du lieu tu Controller -> View
            ViewBag.fullName = "Nguyen Huu Phuc";
            ViewData["Birthday"] = "10/12/2003";
            TempData["Phone"] = "0398227601";

            return View();
        }

        public ActionResult Details() 
        {
            string NHPstr = "";
            NHPstr += "<h3>Ho va ten: Nguyen Huu Phuc</h3>";
            NHPstr += "<p>Ma so: 22109117</p>";
            NHPstr += "<p>Dia chi mail:nguyenphuc10122003@gmail.com</p>";

            ViewBag.Details = NHPstr;

            return View("chiTiet");
        }

        public ActionResult NgonNguRazor()
        {
            string[] names = { "Nguyen Huu Phuc", "Nguyen Tien Loc", "Vu The Quyen" };
            ViewBag.Names = names;
            return View();
        }

        // HTMLHelper
        // GET: NHPStudent/AddStudent
        public ActionResult AddNewStudent()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddNewStudent(FormCollection form)
        {
            //Lay du lieu tren form
            string fullName = form["fullName"];
            string masv = form["maSV"];
            string tk = form["TaiKhoan"];
            string mk = form["MatKhau"];

            string NHPStr = "<h3>" + fullName + "</h3>";
            NHPStr += "<p>" + masv;
            NHPStr += "<p>" + tk;
            NHPStr += "<p>" + mk;

            ViewBag.info = NHPStr;
            return View("Ketqua");
        }
    }
}