﻿using MarfazahFashion.Models;
using MarfazahFashion.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MarfazahFashion.Controllers
{
    public class CurtainsController : Controller
    {
        public ApplicationDbContext _context { get; set; }
        public CurtainsController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult Action(int id)
        {
            return View();
        }

        // GET: Curtains
        public ActionResult Index()
        {
            var curtains = _context.Curtains.Include(c => c.CurtainType).ToList();

            return View(curtains);
        }

        //GET: Curtains/Detail/id
        public ActionResult Detail(int id)
        {
            var curtain = _context.Curtains.Include(c => c.CurtainType).SingleOrDefault( m => m.Id == id);
            if (curtain == null)
                return HttpNotFound();

            return View(curtain);
        }
    }
}