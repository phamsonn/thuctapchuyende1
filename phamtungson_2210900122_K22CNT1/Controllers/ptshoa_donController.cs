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
    public class ptshoa_donController : Controller
    {
        private phamtungson_2210900122_K22CNT1Entities db = new phamtungson_2210900122_K22CNT1Entities();

        // GET: ptshoa_don
        public ActionResult Index()
        {
            var hoa_don = db.hoa_don.Include(h => h.khach_hang);
            return View(hoa_don.ToList());
        }

        // GET: ptshoa_don/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            hoa_don hoa_don = db.hoa_don.Find(id);
            if (hoa_don == null)
            {
                return HttpNotFound();
            }
            return View(hoa_don);
        }

        // GET: ptshoa_don/Create
        public ActionResult Create()
        {
            ViewBag.ma_kh = new SelectList(db.khach_hang, "ma_kh", "ten_DN");
            return View();
        }

        // POST: ptshoa_don/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ma_hd,ngay_laphd,ngay_giao_hang,dc_giao_hang,ma_kh")] hoa_don hoa_don)
        {
            if (ModelState.IsValid)
            {
                db.hoa_don.Add(hoa_don);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ma_kh = new SelectList(db.khach_hang, "ma_kh", "ten_DN", hoa_don.ma_kh);
            return View(hoa_don);
        }

        // GET: ptshoa_don/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            hoa_don hoa_don = db.hoa_don.Find(id);
            if (hoa_don == null)
            {
                return HttpNotFound();
            }
            ViewBag.ma_kh = new SelectList(db.khach_hang, "ma_kh", "ten_DN", hoa_don.ma_kh);
            return View(hoa_don);
        }

        // POST: ptshoa_don/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ma_hd,ngay_laphd,ngay_giao_hang,dc_giao_hang,ma_kh")] hoa_don hoa_don)
        {
            if (ModelState.IsValid)
            {
                db.Entry(hoa_don).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ma_kh = new SelectList(db.khach_hang, "ma_kh", "ten_DN", hoa_don.ma_kh);
            return View(hoa_don);
        }

        // GET: ptshoa_don/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            hoa_don hoa_don = db.hoa_don.Find(id);
            if (hoa_don == null)
            {
                return HttpNotFound();
            }
            return View(hoa_don);
        }

        // POST: ptshoa_don/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            hoa_don hoa_don = db.hoa_don.Find(id);
            db.hoa_don.Remove(hoa_don);
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
