using MarfazahFashion.Models;
using MarfazahFashion.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MarfazahFashion.Controllers
{
    public class CurtainsController : Controller
    {
        List<Curtain> curtains = new List<Curtain>
        {
            new Curtain() {Id = 1, Name = "Eyelet"},
            new Curtain() {Id = 2, Name = "Single Pleat"},
            new Curtain() {Id = 3, Name = "Slot Top"},
            new Curtain() {Id = 4, Name = "Tab Top"},
            new Curtain() {Id = 5, Name = "Pinch Pleat"}
        };

        // GET: Curtains
        public ActionResult Index()
        {
            var viewModel = new IndexCurtainViewModel() { Curtains = curtains };

            return View(viewModel);
        }
    }
}