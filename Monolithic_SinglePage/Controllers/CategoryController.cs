using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Monolithic_SinglePage.Models.ViewModel;
using Monolithic_SinglePage.Models.DomainModels.DTO.EF;

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
        public CategoryViewModel Ref_CategoryViewModel { get; set; }
        #endregion

        #region [- Category() -]
        public ActionResult Category()
        {
            return View();
        }
        #endregion

        #region [- Create -]
        [HttpPost]
        [ValidateAntiForgeryToken]
        [AllowAnonymous]
        public ActionResult Create(Category ref_Category)
        {
            if (ModelState.IsValid)
            {
                return Json(new { message = "Success" }, JsonRequestBehavior.AllowGet);

            }
            else
            {
                return Json(new { ModelState_IsValid = "False" }, JsonRequestBehavior.AllowGet);
            }
        } 
        #endregion
    }
}