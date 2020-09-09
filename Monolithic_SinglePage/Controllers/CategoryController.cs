﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Monolithic_SinglePage.Models.ViewModel;


namespace Monolithic_SinglePage.Controllers
{
    public class CategoryController : Controller
    {
        #region [- ctor -]
        public CategoryController()
        {
            Ref_CategoryViewModel = new CategoryViewModel();
        }
        #endregion

        #region [- Props -]
        public CategoryViewModel Ref_CategoryViewModel { get;private set; }
        #endregion

        #region [- Category() -]
        public ActionResult Category()
        {
            return View(Ref_CategoryViewModel);
        }
        #endregion

        #region [- Create -]
        [HttpPost]
        [ValidateAntiForgeryToken]
        [AllowAnonymous]
        [Route("Create")]
        public ActionResult Create(CategoryViewModel     ref_CategoryViewModel)
        {
            if (ModelState.IsValid)
            {
                ref_CategoryViewModel.Post_Category(ref_CategoryViewModel);
                return Json(new { success=true, message = "Success" }, JsonRequestBehavior.AllowGet);

            }
            else
            {
                return Json(new { ModelState_IsValid = "False" }, JsonRequestBehavior.AllowGet);
            }
        } 
        #endregion
    }
}