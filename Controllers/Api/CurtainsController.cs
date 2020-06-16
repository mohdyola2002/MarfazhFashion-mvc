using AutoMapper;
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
    public class CurtainsController : ApiController
    {
        public ApplicationDbContext _context;

        public CurtainsController()
        {
            _context = new ApplicationDbContext();
        }

        //GET api/curtains
        [HttpGet]
        public IHttpActionResult GetCurtains()
        {

            return Ok(_context.Curtains.ToList().Select(Mapper.Map<Curtain, CurtainDto>));
        }

        //GET api/curtains/1
        [HttpGet]
        public IHttpActionResult GetCurtain(int id)
        {
            var curtain = _context.Curtains.SingleOrDefault(c => c.Id == id);

            if (curtain == null)
                return NotFound();


            return Ok(Mapper.Map<Curtain, CurtainDto>(curtain));
        }

        //POST api/curtains
        [HttpPost]
        public IHttpActionResult CreateCurtain(CurtainDto curtainDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var curtain = Mapper.Map<CurtainDto, Curtain>(curtainDto);
            _context.Curtains.Add(curtain);
            _context.SaveChanges();

            curtainDto.Id = curtain.Id;

            return Created(new Uri(Request.RequestUri + "/" + curtainDto.Id), curtainDto);
        }

        //PUT api/curtains/1
        [HttpPut]
        public IHttpActionResult UpdateCurtain(int id, CurtainDto curtainDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var curtainInDb = _context.Curtains.SingleOrDefault(c => c.Id == id);
            if (curtainInDb == null)
                return NotFound();

            Mapper.Map(curtainDto, curtainInDb);
            _context.SaveChanges();

            return Ok();
        }

        //DELETE api/curtain/1
        [HttpDelete]
        public IHttpActionResult DeleteCurtain(int id)
        {
            var curtainInDb = _context.Curtains.SingleOrDefault(c => c.Id == id);
            if (curtainInDb == null)
                return NotFound();

            _context.Curtains.Remove(curtainInDb);
            _context.SaveChanges();
            return Ok();
        }
    }
}
