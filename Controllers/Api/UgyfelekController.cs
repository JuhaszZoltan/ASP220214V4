using ASP220214V4.Dtos;
using ASP220214V4.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
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
        public IEnumerable<UgyfelDto> UgyfelekListaja()
        {
            return _context.Ugyfelek.ToList().Select(Mapper.Map<Ugyfel, UgyfelDto>);
        }

        //GET -> /api/ugyfelek/{id}
        [HttpGet]
        public UgyfelDto EgyBizonyosUgyfel(int id)
        {
            var ugyfel = _context.Ugyfelek.SingleOrDefault(u => u.Id == id);
            if (ugyfel is null)
                throw new HttpResponseException(HttpStatusCode.NotFound);
            return Mapper.Map<Ugyfel, UgyfelDto>(ugyfel);
        }

        //POST -> /api/ugyfelek
        [HttpPost]
        public UgyfelDto UjUgyfelRogzitese(UgyfelDto ugyfelDto)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            var ugyfel = Mapper.Map<UgyfelDto, Ugyfel>(ugyfelDto);
            _context.Ugyfelek.Add(ugyfel);
            _context.SaveChanges();

            ugyfelDto.Id = ugyfel.Id;

            return ugyfelDto;
        }

        //PUT -> /api/ugyfelek/{id}
        [HttpPut]
        public void UgyfelAdatainakFrissitese(int id, UgyfelDto ugyfelDto)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var ugyfelInDb = _context.Ugyfelek.SingleOrDefault(u => u.Id == id);

            if (ugyfelInDb is null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            Mapper.Map(ugyfelDto, ugyfelInDb);

            _context.SaveChanges();
        }

        //DELET -> /api/ugyfelek/{id}
        [HttpDelete]
        public void UgyfelTorlese(int id)
        {
            var ugyfelInDb = _context.Ugyfelek.SingleOrDefault(u => u.Id == id);
            if (ugyfelInDb is null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            _context.Ugyfelek.Remove(ugyfelInDb);
            _context.SaveChanges();
        }
    }
}
