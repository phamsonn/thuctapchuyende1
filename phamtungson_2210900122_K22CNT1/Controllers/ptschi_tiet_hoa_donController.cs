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
    public class ptschi_tiet_hoa_donController : Controller
    {
        private phamtungson_2210900122_K22CNT1Entities db = new phamtungson_2210900122_K22CNT1Entities();

        // GET: ptschi_tiet_hoa_don
        public ActionResult Index()
        {
            var chi_tiet_hoa_don = db.chi_tiet_hoa_don.Include(c => c.hoa_don).Include(c => c.size).Include(c => c.san_pham);
            return View(chi_tiet_hoa_don.ToList());
        }

        // GET: ptschi_tiet_hoa_don/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            chi_tiet_hoa_don chi_tiet_hoa_don = db.chi_tiet_hoa_don.Find(id);
            if (chi_tiet_hoa_don == null)
            {
                return HttpNotFound();
            }
            return View(chi_tiet_hoa_don);
        }

        // GET: ptschi_tiet_hoa_don/Create
        public ActionResult Create()
        {
            ViewBag.ma_hd = new SelectList(db.hoa_don, "ma_hd", "dc_giao_hang");
            ViewBag.ma_size = new SelectList(db.sizes, "ma_size", "size1");
            ViewBag.ma_sp = new SelectList(db.san_pham, "ma_sp", "ten_sp");
            return View();
        }

        // POST: ptschi_tiet_hoa_don/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ma_hd,ma_sp,ma_size,so_luong,don_gia,thanh_tien")] chi_tiet_hoa_don chi_tiet_hoa_don)
        {
            if (ModelState.IsValid)
            {
                db.chi_tiet_hoa_don.Add(chi_tiet_hoa_don);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ma_hd = new SelectList(db.hoa_don, "ma_hd", "dc_giao_hang", chi_tiet_hoa_don.ma_hd);
            ViewBag.ma_size = new SelectList(db.sizes, "ma_size", "size1", chi_tiet_hoa_don.ma_size);
            ViewBag.ma_sp = new SelectList(db.san_pham, "ma_sp", "ten_sp", chi_tiet_hoa_don.ma_sp);
            return View(chi_tiet_hoa_don);
        }

        // GET: ptschi_tiet_hoa_don/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            chi_tiet_hoa_don chi_tiet_hoa_don = db.chi_tiet_hoa_don.Find(id);
            if (chi_tiet_hoa_don == null)
            {
                return HttpNotFound();
            }
            ViewBag.ma_hd = new SelectList(db.hoa_don, "ma_hd", "dc_giao_hang", chi_tiet_hoa_don.ma_hd);
            ViewBag.ma_size = new SelectList(db.sizes, "ma_size", "size1", chi_tiet_hoa_don.ma_size);
            ViewBag.ma_sp = new SelectList(db.san_pham, "ma_sp", "ten_sp", chi_tiet_hoa_don.ma_sp);
            return View(chi_tiet_hoa_don);
        }

        // POST: ptschi_tiet_hoa_don/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ma_hd,ma_sp,ma_size,so_luong,don_gia,thanh_tien")] chi_tiet_hoa_don chi_tiet_hoa_don)
        {
            if (ModelState.IsValid)
            {
                db.Entry(chi_tiet_hoa_don).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ma_hd = new SelectList(db.hoa_don, "ma_hd", "dc_giao_hang", chi_tiet_hoa_don.ma_hd);
            ViewBag.ma_size = new SelectList(db.sizes, "ma_size", "size1", chi_tiet_hoa_don.ma_size);
            ViewBag.ma_sp = new SelectList(db.san_pham, "ma_sp", "ten_sp", chi_tiet_hoa_don.ma_sp);
            return View(chi_tiet_hoa_don);
        }

        // GET: ptschi_tiet_hoa_don/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            chi_tiet_hoa_don chi_tiet_hoa_don = db.chi_tiet_hoa_don.Find(id);
            if (chi_tiet_hoa_don == null)
            {
                return HttpNotFound();
            }
            return View(chi_tiet_hoa_don);
        }

        // POST: ptschi_tiet_hoa_don/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            chi_tiet_hoa_don chi_tiet_hoa_don = db.chi_tiet_hoa_don.Find(id);
            db.chi_tiet_hoa_don.Remove(chi_tiet_hoa_don);
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
