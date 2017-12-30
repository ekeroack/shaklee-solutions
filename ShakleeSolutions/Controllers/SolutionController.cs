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
    public class SolutionController : Controller
    {
        private ClientContext db = new ClientContext();

        // GET: /Solution/
        public ActionResult Index()
        {
            var solutions = db.Solutions.Include(c => c.Ailments).OrderBy(c => c.Desc).ToList();

            var solutionViewModels = from c in solutions select new SolutionViewModel(c); 

            return View(solutionViewModels.ToList());
        }

        // GET: /Solution/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Solution solution = db.Solutions.Include(c => c.Ailments).SingleOrDefault(x => x.Id == id);
            
            if (solution == null)
            {
                return HttpNotFound();
            }
            return View(solution);
        }

        // GET: /Solution/Create
        public ActionResult Create()
        {
            return View(new CreateSolutionViewModel());
        }

        // POST: /Solution/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CreateSolutionViewModel model)
        {
            if (ModelState.IsValid)
            {
                var solution = new Solution();
                solution.Desc = model.Desc;
                solution.Ailments = new List<Ailment>();

                var ailments = db.Ailments.ToList();

                foreach (var ailment in ailments)
                {
                    if (model.SelectedAilmentIds != null && model.SelectedAilmentIds.Contains(ailment.Id))
                    {
                        solution.Ailments.Add(ailment);
                    }
                }

                db.Solutions.Add(solution);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(model);
        }

        // GET: /Solution/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Solution solution = db.Solutions.Include(x => x.Ailments).SingleOrDefault(x => x.Id == id);
            if (solution == null)
            {
                return HttpNotFound();
            }
            return View(new CreateSolutionViewModel(solution));
        }

        // POST: /Solution/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(CreateSolutionViewModel model)
        {
            if (ModelState.IsValid)
            {
                var solution = db.Solutions.Include(x => x.Ailments).Single(u => u.Id == model.Id);
                solution.Desc = model.Desc;

                if (model.SelectedAilmentIds == null)
                {
                    //clear out?
                }
                else
                {
                    var ailments = db.Ailments.ToList();

                    foreach (var ailment in ailments)
                    {
                        if (model.SelectedAilmentIds.Contains(ailment.Id))
                        {
                            if (!solution.Ailments.Contains(ailment))
                            {
                                solution.Ailments.Add(ailment);
                            }
                        }
                        else if (solution.Ailments.Contains(ailment))
                        {
                            solution.Ailments.Remove(ailment);
                        }
                    }
                }
                
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(model);
        }

        // GET: /Solution/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Solution solution = db.Solutions.Find(id);
            if (solution == null)
            {
                return HttpNotFound();
            }
            return View(solution);
        }

        // POST: /Solution/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Solution solution = db.Solutions.Find(id);
            db.Solutions.Remove(solution);
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
