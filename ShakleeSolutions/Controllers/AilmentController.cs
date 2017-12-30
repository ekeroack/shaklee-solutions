using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ShakleeSolutions.Models;
using ShakleeSolutions.Models.ViewModels;

namespace ShakleeSolutions.Controllers
{
    public class AilmentController : Controller
    {
        private ClientContext db = new ClientContext();

        // GET: /Ailment/
        public ActionResult Index()
        {
            return View(db.Ailments.OrderBy(c => c.Desc).ToList());
        }

        // GET: /Ailment/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ailment ailment = db.Ailments.Include(x => x.Solutions).SingleOrDefault(x => x.Id == id);
            if (ailment == null)
            {
                return HttpNotFound();
            }
            return View(ailment);
        }

        // GET: /Ailment/Create
        public ActionResult Create()
        {
            return View(new CreateAilmentViewModel());
        }

        // POST: /Ailment/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CreateAilmentViewModel model)
        {
            if (ModelState.IsValid)
            {
                var ailment = new Ailment();
                ailment.Desc = model.Desc;
                ailment.Solutions = new List<Solution>();

                var solutions = db.Solutions.ToList();

                foreach (var solution in solutions)
                {
                    if (model.SelectedSolutionIds != null && model.SelectedSolutionIds.Contains(solution.Id))
                    {
                        ailment.Solutions.Add(solution);   
                    }
                }

                db.Ailments.Add(ailment);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(model);
        }

        // GET: /Ailment/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ailment ailment = db.Ailments.Include(x => x.Solutions).SingleOrDefault(x => x.Id == id);

            if (ailment == null)
            {
                return HttpNotFound();
            }
            return View(new CreateAilmentViewModel(ailment));
        }

        // POST: /Ailment/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(CreateAilmentViewModel model)
        {
            if (ModelState.IsValid)
            {
                var ailment = db.Ailments.Include(x => x.Solutions).Single(u => u.Id == model.Id);
                ailment.Desc = model.Desc;
                
                if (model.SelectedSolutionIds == null)
                {
                    //clear out?
                }
                else
                {
                    var solutions = db.Solutions.ToList();

                    foreach (var solution in solutions)
                    {
                        if (model.SelectedSolutionIds.Contains(solution.Id))
                        {
                            if (!ailment.Solutions.Contains(solution))
                            {
                                ailment.Solutions.Add(solution);
                            }
                        }
                        else if (ailment.Solutions.Contains(solution))
                        {
                            ailment.Solutions.Remove(solution);
                        }
                    }
                }

                db.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(model);
        }

        // GET: /Ailment/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ailment ailment = db.Ailments.Find(id);
            if (ailment == null)
            {
                return HttpNotFound();
            }
            return View(ailment);
        }

        // POST: /Ailment/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Ailment ailment = db.Ailments.Find(id);
            db.Ailments.Remove(ailment);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
