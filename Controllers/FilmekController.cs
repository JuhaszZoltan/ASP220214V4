using ASP220214V4.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP220214V4.Controllers
{
    public class FilmekController : Controller
    {
        #region context shit
        private ApplicationDbContext _context;
        public FilmekController() =>
            _context = new ApplicationDbContext();
        protected override void Dispose(bool disposing) =>
            _context.Dispose();
        #endregion
        public ActionResult Index()
        {
            var kapcs = _context.FilmMufajKapcsolo
                .Include(k => k.Film)
                .Include(k => k.Mufaj);

            var viewModelList = new List<FilmViewModel>();

            foreach (var fm in kapcs)
            {
                if (!viewModelList.Any(x => x.Film.Id == fm.FilmId))
                {
                    viewModelList.Add(new FilmViewModel
                    {
                        Film = fm.Film,
                        Mufajok = new List<Mufaj>(),
                    });
                }
                viewModelList.Single(x => x.Film.Id == fm.FilmId).Mufajok.Add(fm.Mufaj);
            }
            return View(viewModelList);
        }

        public ActionResult Reszletek(int id)
        {
            return View();
        }

        public ActionResult Kategoriak(int? id)
        {
            if (id is null) return View();
            else
            {
                return View(id);
            }
        }
    }
}