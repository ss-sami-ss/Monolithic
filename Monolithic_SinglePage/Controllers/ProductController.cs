using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Monolithic_SinglePage.Models.ViewModel;

namespace Monolithic_SinglePage.Controllers
{
    public class ProductController : Controller
    {
        #region [- ctor -]
        public ProductController()
        {
            Ref_ProductViewModel = new ProductViewModel();
        }
        #endregion

        #region [- Props -]
        public ProductViewModel Ref_ProductViewModel { get; private set; }
        #endregion

        #region [- Product() -]
        public ActionResult Product()
        {
            return View(Ref_ProductViewModel);
        }
        #endregion

        #region [- Create -]
        [HttpPost]
        //[ValidateAntiForgeryToken]
        [AllowAnonymous]
        //[Route("Create")]
        public ActionResult Create(ProductViewModel ref_ProductViewModel)
        {
            if (ModelState.IsValid)
            {
                Ref_ProductViewModel.Post_Product(ref_ProductViewModel);
                return Json(new { Message = "Success" }, JsonRequestBehavior.AllowGet);

            }
            else
            {
                return Json(new { ModelState_IsValid = "False", JsonRequestBehavior.AllowGet });
            }
        }
        #endregion

        #region [- Edit -]
        [HttpPost]
        // [ValidateAntiForgeryToken]
        [AllowAnonymous]
        //[Route("Edit")]
        public ActionResult Edit(ProductViewModel ref_ProductViewModel)
        {
            if (ModelState.IsValid)
            {
                ref_ProductViewModel.Put_Prodcut(ref_ProductViewModel);
                return Json(new { Message = "Success" }, JsonRequestBehavior.AllowGet);

            }
            else
            {
                return Json(new { ModelState_IsValid = "False", JsonRequestBehavior.AllowGet });
            }
        }
        #endregion

        #region [- Delete -]
        [HttpPost]
        // [ValidateAntiForgeryToken]
        [AllowAnonymous]
        // [Route("Delete")]
        public ActionResult Delete(ProductViewModel ref_ProductViewModel)
        {
            if (ModelState.IsValid)
            {
                ref_ProductViewModel.Delete_Product(ref_ProductViewModel);
                return Json(new { Message = "Success" }, JsonRequestBehavior.AllowGet);

            }
            else
            {
                return Json(new { ModelState_IsValid = "False", JsonRequestBehavior.AllowGet });
            }
        }
        #endregion
    }
}