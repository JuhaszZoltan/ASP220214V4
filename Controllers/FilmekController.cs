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
                .Include(k => k.Mufaj)
                .ToList();

            var dic = new Dictionary<Film, List<Mufaj>>();
            foreach (var k in kapcs)
            {
                if (!dic.ContainsKey(k.Film))
                {
                    dic.Add(k.Film, new List<Mufaj>());
                }
                dic[k.Film].Add(k.Mufaj);
            }
            var vml = new List<FilmViewModel>();
            foreach (var kvp in dic)
            {
                vml.Add(new FilmViewModel()
                {
                    Film = kvp.Key,
                    Mufajok = kvp.Value,
                });
            }
            return View(vml);
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