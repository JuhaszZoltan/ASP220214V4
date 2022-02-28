using ASP220214V4.Models;
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
        public IEnumerable<Ugyfel> UgyfelekListaja()
        {
            return _context.Ugyfelek.ToList();
        }

        //GET -> /api/ugyfelek/{id}
        [HttpGet]
        public Ugyfel EgyBizonyosUgyfel(int id)
        {
            var ugyfel = _context.Ugyfelek.SingleOrDefault(u => u.Id == id);
            if (ugyfel is null)
                throw new HttpResponseException(HttpStatusCode.NotFound);
            return ugyfel;
        }

        //POST -> /api/ugyfelek
        [HttpPost]
        public Ugyfel UjUgyfelRogzitese(Ugyfel ugyfel)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            _context.Ugyfelek.Add(ugyfel);
            _context.SaveChanges();

            return ugyfel;
        }

        //PUT -> /api/ugyfelek/{id}
        [HttpPut]
        public void UgyfelAdatainakFrissitese(int id, Ugyfel ugyfel)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var ugyfelInDb = _context.Ugyfelek.SingleOrDefault(u => u.Id == id);

            if (ugyfelInDb is null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            ugyfelInDb.Nev = ugyfel.Nev;
            ugyfelInDb.SzuletesiDatum = ugyfel.SzuletesiDatum;
            ugyfelInDb.HirlevelFeliratkozas = ugyfel.HirlevelFeliratkozas;
            ugyfelInDb.ElofizetesTipusId = ugyfel.ElofizetesTipusId;

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
