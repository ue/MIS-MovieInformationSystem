﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FilmSistemi.Areas.Admin.Controllers
{
    public class HomeAdminController : Controller
    {
        // GET: Admin/Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult FilmEkle()
        {
            return View();
        }
        public ActionResult Users()
        {
            return View();
        }
        public ActionResult Haberler()
        {
            return View();
        }
        public ActionResult HaberEkle()
        {
            return View();
        }
        public ActionResult HaberSil()
        {
            return View();
        }
        public ActionResult HaberDuzenle()
        {
            return View();
        }
    }
}