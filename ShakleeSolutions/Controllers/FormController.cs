using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ShakleeSolutions.Models;
using ShakleeSolutions.Models.ViewModels;

namespace ShakleeSolutions.Controllers
{
    public class FormController : Controller
    {
        private ClientContext db = new ClientContext();

        // GET: Form
        public ActionResult ViewForms(int? clientId)
        {
            if (clientId == null)
            {
                return RedirectToAction("Index", "Client");
            }

            return View(new ViewFormsViewModel((int)clientId));
        }

        // GET: /Ailment/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Form form = db.Forms.Include("Ailments").SingleOrDefault(x => x.Id == id);
            
            if (form == null)
            {
                return HttpNotFound();
            }
            return View(form);
        }
        // GET: /Ailment/Details/5
        public ActionResult SolutionsForForm(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Form form = db.Forms.Include("Ailments").SingleOrDefault(x => x.Id == id);

            if (form == null)
            {
                return HttpNotFound();
            }

            var viewModel = new SolutionsForFormViewModel(form);

            //In ViewModel
            //Foreach ailment selected in the form
            //Add solution and a count of the number of times that solution has popped up
            //Once done, sort solutions by count and list them out



            return View(viewModel);
        }
        // GET: /Client/Create
        public ActionResult AddForm(int clientId)
        {
            return View(new AddFormViewModel(clientId));
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddForm(AddFormViewModel model)
        {
            if (ModelState.IsValid)
            {
                var form = new Form();
                form.ClientId = model.ClientId;
                form.Date = model.Date;
                form.Ailments = new List<Ailment>();

                var ailments = db.Ailments.ToList();

                foreach (var ailment in ailments)
                {
                    if (model.SelectedAilmentIds != null && model.SelectedAilmentIds.Contains(ailment.Id))
                    {
                        form.Ailments.Add(ailment);
                    }
                }

                db.Forms.Add(form);
                db.SaveChanges();
                return RedirectToAction("ViewForms", new {clientId = model.ClientId});
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
            Form ailment = db.Forms.Include("Ailments").SingleOrDefault(x => x.Id == id);

            if (ailment == null)
            {
                return HttpNotFound();
            }
            return View(new AddFormViewModel(ailment));
        }

        // POST: /Ailment/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(AddFormViewModel model)
        {
            if (ModelState.IsValid)
            {
                var form = db.Forms.Include("Ailments").Single(u => u.Id == model.Id);

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
                            if (!form.Ailments.Contains(ailment))
                            {
                                form.Ailments.Add(ailment);
                            }
                        }
                        else if (form.Ailments.Contains(ailment))
                        {
                            form.Ailments.Remove(ailment);
                        }
                    }
                }

                db.SaveChanges();

                return RedirectToAction("ViewForms", new { clientId = model.ClientId });
            }

            return View(model);
        }

        // GET: /Client/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Form form = db.Forms.Find(id);
            if (form == null)
            {
                return HttpNotFound();
            }
            return View(form);
        }

        // POST: /Client/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Form form = db.Forms.Find(id);
            db.Forms.Remove(form);
            db.SaveChanges();
            return RedirectToAction("ViewForms", new {clientId = form.ClientId});
        }
    }
}