using MarfazahFashion.Dtos;
using MarfazahFashion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MarfazahFashion.Controllers.Api
{
    public class NewPurchasesController : ApiController
    {
        public ApplicationDbContext _context;

        public NewPurchasesController()
        {
            _context = new ApplicationDbContext();
        }

        [HttpPost]
        public IHttpActionResult CreateNewPurchase(NewPurchaseDto newPurchase)
        {
            var customer = _context.Customers.Single(c => c.Id == newPurchase.CustomerId);

            var curtains = _context.Curtains.Where(c => newPurchase.CurtainIds.Contains(c.Id)).ToList();

            foreach (var curtain in curtains)
            {
                if (curtain.NumberInStock == 0)
                    return BadRequest("Curtain out of stock");

                curtain.NumberInStock--;
                var purchase = new Purchase()
                {
                    DatePurchased = DateTime.Now,
                    Customer = customer,
                    Curtain = curtain
                };
                
                _context.Purchases.Add(purchase);
            }
            _context.SaveChanges();
            return Ok();
        }
    }
}
