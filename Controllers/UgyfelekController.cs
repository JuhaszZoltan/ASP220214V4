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

        public ActionResult UjUgyfel()
        {
            var elofizetesTipusok = _context.ElofizetesTipusok.ToList();
            var viewModel = new UjUgyfelViewModel
            {
                ElofizetesTipusok = elofizetesTipusok,
            };
            return View(viewModel);
        }
    }
}