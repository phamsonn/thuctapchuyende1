using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using phamtungson_2210900122_K22CNT1.Models;

namespace phamtungson_2210900122_K22CNT1.Controllers
{
    public class ptssan_phamController : Controller
    {
        private phamtungson_2210900122_K22CNT1Entities db = new phamtungson_2210900122_K22CNT1Entities();

        // GET: ptssan_pham
        public ActionResult Index()
        {
            return View(db.san_pham.ToList());
        }

        // GET: ptssan_pham/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            san_pham san_pham = db.san_pham.Find(id);
            if (san_pham == null)
            {
                return HttpNotFound();
            }
            return View(san_pham);
        }

        // GET: ptssan_pham/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ptssan_pham/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ma_sp,ten_sp,gia_ban,loai_sp,gioi_tinh,anh")] san_pham san_pham)
        {
            if (ModelState.IsValid)
            {
                db.san_pham.Add(san_pham);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(san_pham);
        }

        // GET: ptssan_pham/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            san_pham san_pham = db.san_pham.Find(id);
            if (san_pham == null)
            {
                return HttpNotFound();
            }
            return View(san_pham);
        }

        // POST: ptssan_pham/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ma_sp,ten_sp,gia_ban,loai_sp,gioi_tinh,anh")] san_pham san_pham)
        {
            if (ModelState.IsValid)
            {
                db.Entry(san_pham).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(san_pham);
        }

        // GET: ptssan_pham/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            san_pham san_pham = db.san_pham.Find(id);
            if (san_pham == null)
            {
                return HttpNotFound();
            }
            return View(san_pham);
        }

        // POST: ptssan_pham/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            san_pham san_pham = db.san_pham.Find(id);
            db.san_pham.Remove(san_pham);
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
