using MarfazahFashion.Models;
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

        public ActionResult New()
        {
            var curtainTypes = _context.CurtainTypes.ToList();
            var viewModel = new CurtainFormViewModel()
            {
                CurtainTypes = curtainTypes
            };
            return View("CurtainForm", viewModel);
        }

        public ActionResult Edit(int id)
        {
            var curtain = _context.Curtains.SingleOrDefault(c => c.Id == id);
            if (curtain == null)
                return HttpNotFound();
            var viewModel = new CurtainFormViewModel(curtain)
            {
                CurtainTypes = _context.CurtainTypes.ToList()
            };
            return View("CurtainForm", viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Curtain curtain)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new CurtainFormViewModel(curtain)
                {
                    CurtainTypes = _context.CurtainTypes.ToList()
                };
                return View("CurtainForm", viewModel);
            }
            if (curtain.Id == 0)
                _context.Curtains.Add(curtain);
            else
            {
                var curtainInDb = _context.Curtains.Single(c => c.Id == curtain.Id);
                curtainInDb.Name = curtain.Name;
                curtainInDb.CurtainTypeId = curtain.CurtainTypeId;
                curtainInDb.Price = curtain.Price;
                curtainInDb.NumberInStock = curtain.NumberInStock;
            }
            _context.SaveChanges();
            return RedirectToAction("Index", "Curtains");
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