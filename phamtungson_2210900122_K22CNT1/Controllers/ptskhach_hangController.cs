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
    public class ptskhach_hangController : Controller
    {
        private phamtungson_2210900122_K22CNT1Entities db = new phamtungson_2210900122_K22CNT1Entities();

        // GET: ptskhach_hang
        public ActionResult Index()
        {
            return View(db.khach_hang.ToList());
        }

        // GET: ptskhach_hang/Details/5
        public ActionResult Details(string ma_kh)
        {
            if (string.IsNullOrEmpty(ma_kh))
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            khach_hang khach_hang = db.khach_hang.Find(ma_kh);
            if (khach_hang == null)
            {
                return HttpNotFound();
            }
            return View(khach_hang);
        }

        // GET: ptskhach_hang/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ptskhach_hang/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ma_kh,ten_DN,ho_ten,ngay_sinh,gioi_tinh,mat_khau,diachi,sdt")] khach_hang khach_hang)
        {
            if (ModelState.IsValid)
            {
                db.khach_hang.Add(khach_hang);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(khach_hang);
        }

        // GET: ptskhach_hang/Edit/5
        public ActionResult Edit(string ma_kh)
        {
            if (string.IsNullOrEmpty(ma_kh))
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            khach_hang khach_hang = db.khach_hang.Find(ma_kh);
            if (khach_hang == null)
            {
                return HttpNotFound();
            }
            return View(khach_hang);
        }

        // POST: ptskhach_hang/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ma_kh,ten_DN,ho_ten,ngay_sinh,gioi_tinh,mat_khau,diachi,sdt")] khach_hang khach_hang)
        {
            if (ModelState.IsValid)
            {
                db.Entry(khach_hang).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(khach_hang);
        }

        // GET: ptskhach_hang/Delete/5
        public ActionResult Delete(string ma_kh)
        {
            if (string.IsNullOrEmpty(ma_kh))
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            khach_hang khach_hang = db.khach_hang.Find(ma_kh);
            if (khach_hang == null)
            {
                return HttpNotFound();
            }
            return View(khach_hang);
        }

        // POST: ptskhach_hang/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string ma_kh)
        {
            khach_hang khach_hang = db.khach_hang.Find(ma_kh);
            if (khach_hang != null)
            {
                db.khach_hang.Remove(khach_hang);
                db.SaveChanges();
            }
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
