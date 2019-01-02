using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StraussDA.FantasyPlayers;

namespace FantasyFootballLineups.Controllers
{
    public class PlayerController : Controller
    {
        private static FantasyPlayerRepo _fRepo = new FantasyPlayerRepo();

        // GET: Player
        public ActionResult Index()
        {
            return View(_fRepo.ListAll());
        }

        // GET: Player/Details/5
        public ActionResult Details(int id)
        {
            return View(_fRepo.GetById(id));
        }

        // GET: Player/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Player/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(FantasyPlayers newPlayer)
        {
            try
            {
                _fRepo.Add(newPlayer);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Player/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_fRepo.GetById(id));
        }

        // POST: Player/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(FantasyPlayers editPlayer)
        {
            try
            {
                _fRepo.Edit(editPlayer);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Player/Delete/5
        public ActionResult Delete(int id)
        {
            return View(_fRepo.GetById(id));
        }

        // POST: Player/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                _fRepo.Delete(id);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}