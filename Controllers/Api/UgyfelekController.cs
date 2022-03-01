using ASP220214V4.Dtos;
using ASP220214V4.Models;
using AutoMapper;
using System;
using System.Linq;
using System.Web.Http;

namespace ASP220214V4.Controllers.Api
{
    public class UgyfelekController : ApiController
    {
        private ApplicationDbContext _context;

        public UgyfelekController()
        {
            _context = new ApplicationDbContext();
        }

        //GET -> /api/ugyfelek
        [HttpGet]
        public IHttpActionResult UgyfelekListaja()
        {
            return Ok(_context.Ugyfelek.ToList().Select(Mapper.Map<Ugyfel, UgyfelDto>));
        }

        //GET -> /api/ugyfelek/{id}
        [HttpGet]
        public IHttpActionResult EgyBizonyosUgyfel(int id)
        {
            var ugyfel = _context.Ugyfelek.SingleOrDefault(u => u.Id == id);
            if (ugyfel is null)
                return NotFound();
            return Ok(Mapper.Map<Ugyfel, UgyfelDto>(ugyfel));
        }

        //POST -> /api/ugyfelek
        [HttpPost]
        public IHttpActionResult UjUgyfelRogzitese(UgyfelDto ugyfelDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var ugyfel = Mapper.Map<UgyfelDto, Ugyfel>(ugyfelDto);
            _context.Ugyfelek.Add(ugyfel);
            _context.SaveChanges();

            ugyfelDto.Id = ugyfel.Id;

            return Created(new Uri(Request.RequestUri + $"/{ugyfel.Id}"), ugyfel);
        }

        //PUT -> /api/ugyfelek/{id}
        [HttpPut]
        public IHttpActionResult UgyfelAdatainakFrissitese(int id, UgyfelDto ugyfelDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var ugyfelInDb = _context.Ugyfelek.SingleOrDefault(u => u.Id == id);

            if (ugyfelInDb is null)
                return NotFound();

            Mapper.Map(ugyfelDto, ugyfelInDb);

            _context.SaveChanges();
            return Ok();
        }

        //DELET -> /api/ugyfelek/{id}
        [HttpDelete]

        public IHttpActionResult UgyfelTorlese(int id)
        {
            var ugyfelInDb = _context.Ugyfelek.SingleOrDefault(u => u.Id == id);
            if (ugyfelInDb is null)
                return NotFound();

            _context.Ugyfelek.Remove(ugyfelInDb);
            _context.SaveChanges();
            return Ok();
        }
    }
}
