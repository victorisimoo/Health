﻿using Health.Services;
using Health.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;

namespace Health.Controllers {

    public class MedicineController : Controller {
        // GET: Medicine

        public ActionResult Index(){
            //int pageSize = 3;
            //int pageNumber = (page ?? 1);
            return View(Storage.Instance.medicinesReturn);
        }

        // GET: Medicine/Details/5
        public ActionResult Details(int id) {
            return View();
        }

        // GET: Medicine/Create
        public ActionResult Create() {
            return View();
        }

        public ActionResult SearchMedicine(string searchMedicine){
            Medicine medicine = new Medicine();
            return RedirectToAction("Index");
        }

        // POST: Medicine/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection) {
            try {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }catch{
                return View();
            }
        }

        // GET: Medicine/Edit/5
        public ActionResult Edit(int id) {
            return View();
        }

        // POST: Medicine/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection) {
            try {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            } catch {
                return View();
            }
        }

        // GET: Medicine/Delete/5
        public ActionResult Delete(int id) {
            return View();
        }

        // POST: Medicine/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection) {
            try {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            } catch {
                return View();
            }
        }
    }
}
