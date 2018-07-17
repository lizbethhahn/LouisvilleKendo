using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using LouisvilleKendo.DAL;
using LouisvilleKendo.Models;

namespace LouisvilleKendo.Controllers
{
    public class ClubMemberController : Controller
    {
        private ClubContext db = new ClubContext();

        // GET: ClubMember
        public ActionResult Index()
        {
            return View(db.ClubMembers.ToList());
        }

        // GET: ClubMember/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ClubMember clubMember = db.ClubMembers.Find(id);
            if (clubMember == null)
            {
                return HttpNotFound();
            }
            return View(clubMember);
        }

        // GET: ClubMember/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ClubMember/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,AuskfId,LastName,FirstName,StartDate,Rank,FederationMember,CurrentMember")] ClubMember clubMember)
        {
            if (ModelState.IsValid)
            {
                db.ClubMembers.Add(clubMember);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(clubMember);
        }

        // GET: ClubMember/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ClubMember clubMember = db.ClubMembers.Find(id);
            if (clubMember == null)
            {
                return HttpNotFound();
            }
            return View(clubMember);
        }

        // POST: ClubMember/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,AuskfId,LastName,FirstName,StartDate,Rank,FederationMember,CurrentMember")] ClubMember clubMember)
        {
            if (ModelState.IsValid)
            {
                db.Entry(clubMember).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(clubMember);
        }

        // GET: ClubMember/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ClubMember clubMember = db.ClubMembers.Find(id);
            if (clubMember == null)
            {
                return HttpNotFound();
            }
            return View(clubMember);
        }

        // POST: ClubMember/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ClubMember clubMember = db.ClubMembers.Find(id);
            db.ClubMembers.Remove(clubMember);
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
