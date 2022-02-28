using ASP220214V4.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP220214V4.Controllers
{
    public class UgyfelekController : Controller
    {
        #region context shit
        private ApplicationDbContext _context;
        public UgyfelekController() =>
            _context = new ApplicationDbContext();
        protected override void Dispose(bool disposing) =>
            _context.Dispose();
        #endregion

        // GET: Ugyfelek
        public ActionResult Index()
        {
            var ugyfelek = _context.Ugyfelek.Include(u => u.ElofizetesTipus).ToList();
            return View(ugyfelek);
        }
        public ActionResult Reszletek(int id)
        {
            var ugyfel = _context
                .Ugyfelek
                .Include(u => u.ElofizetesTipus)
                .SingleOrDefault(u => u.Id == id);

            if (ugyfel is null) return HttpNotFound();
            else return View(ugyfel);
        }

        public ActionResult UgyfelForm()
        {
            var viewModel = new UgyfelFormViewModel
            {
                Ugyfel = new Ugyfel() { Id = 0, HirlevelFeliratkozas = true },
                ElofizetesTipusok = _context.ElofizetesTipusok.ToList(),
            };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Mentes(Ugyfel ugyfel)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new UgyfelFormViewModel()
                {
                    Ugyfel = ugyfel,
                    ElofizetesTipusok = _context.ElofizetesTipusok.ToList(),
                };

                return View("UgyfelForm", viewModel);
            }


            if (ugyfel.Id == 0)
            {
                _context.Ugyfelek.Add(ugyfel);
            }
            else
            {
                var ugyfelInDb = _context.Ugyfelek.Single(u => u.Id == ugyfel.Id);

                ugyfelInDb.Nev = ugyfel.Nev;
                ugyfelInDb.SzuletesiDatum = ugyfel.SzuletesiDatum;
                ugyfelInDb.ElofizetesTipusId = ugyfel.ElofizetesTipusId;
                ugyfelInDb.HirlevelFeliratkozas = ugyfel.HirlevelFeliratkozas;
            }
            _context.SaveChanges();
            return RedirectToAction("Index", "Ugyfelek");
        }

        public ActionResult Szerkesztes(int id)
        {
            var ugyfel = _context.Ugyfelek.SingleOrDefault(u => u.Id == id);
            var elofizetesTipusok = _context.ElofizetesTipusok.ToList();
            if (ugyfel is null) return HttpNotFound();
            else
            {
                var viewModel = new UgyfelFormViewModel()
                {
                    Ugyfel = ugyfel,
                    ElofizetesTipusok = elofizetesTipusok,
                };
                return View("UgyfelForm", viewModel);
            }
        }
    }
}