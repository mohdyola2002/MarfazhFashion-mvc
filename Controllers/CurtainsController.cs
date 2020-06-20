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

        // GET: Curtains
        public ActionResult Index()
        {
            if (User.IsInRole(RoleName.CanManageCurtains))
                return View("List");

            return View("ReadOnlyList");
        }

        [Authorize(Roles = RoleName.CanManageCurtains)]
        public ActionResult New()
        {
            var curtainTypes = _context.CurtainTypes.ToList();
            var viewModel = new CurtainFormViewModel()
            {
                CurtainTypes = curtainTypes
            };
            return View("CurtainForm", viewModel);
        }

        [Authorize(Roles = RoleName.CanManageCurtains)]
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

        //GET: Curtains/Detail/id
        public ActionResult Detail(int id)
        {
            return View();
        }
    }
}