using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Monolithic_SinglePage.Models.DomainModels.POCO;
using Monolithic_SinglePage.Models.DomainModels.DTO.EF;

namespace Monolithic_SinglePage.Models.ViewModel
{
    public class ProductViewModel
    {

        #region [- cotr -]
        public ProductViewModel()
        {
            Ref_ProductRepository = new ProductRepository();
        }
        #endregion

        #region [- Props -]

        #region [- Props For Class -]

        public ProductRepository Ref_ProductRepository { get; set; }
       

        #endregion

        #region [- Props For Models -]

        public int Id { get; set; }
        public int? Code { get; set; }
        public int? CategoryRef { get; set; }
        public string Title { get; set; }
        public int? UnitPrice { get; set; }
        public int? Quantity { get; set; }

        #endregion
        #endregion

        #region [- Methods -]

        #region [- Get_Product() -]
        public List<Product> Get_Product()
        {
            var q = Ref_ProductRepository.SelectAll();
            return q;
        }
        #endregion

        #region [- Post_Product(ProductViewModel ref_ProductViewModel) -]
        public void Post_Product(ProductViewModel ref_ProductViewModel)
        {
            Product ref_Product = new Product();
            ref_ProductViewModel.Code = ref_Product.Code;
            ref_ProductViewModel.Title = ref_Product.Title;
            ref_ProductViewModel.CategoryRef = ref_Product.CategoryRef;
            ref_ProductViewModel.Quantity = ref_Product.Quantity;
            ref_ProductViewModel.UnitPrice = ref_Product.UnitPrice;
            Ref_ProductRepository.InsertInto(ref_Product);
        }
        #endregion

        #region [- Find_Product(int? id) -]
        public ProductViewModel Find_Product(int? id)
        {
            var ref_Product = Ref_ProductRepository.FindProduct(id);
            ProductViewModel ref_ProductViewModel = new ProductViewModel();
            ref_ProductViewModel.Id = ref_Product.Id;
            ref_ProductViewModel.Code = ref_Product.Code;
            ref_ProductViewModel.Title = ref_Product.Title;
            ref_ProductViewModel.CategoryRef = ref_Product.CategoryRef;
            ref_ProductViewModel.Quantity = ref_Product.Quantity;
            ref_ProductViewModel.UnitPrice = ref_Product.UnitPrice;
            return ref_ProductViewModel;
        }
        #endregion

        #region [- Put_Prodcut(ProductViewModel ref_ProductViewModel) -]
        public void Put_Prodcut(ProductViewModel ref_ProductViewModel)
        {
            Product ref_Product = new Product();
            ref_ProductViewModel.Id = ref_Product.Id;
            ref_ProductViewModel.Code = ref_Product.Code;
            ref_ProductViewModel.Title = ref_Product.Title;
            ref_ProductViewModel.CategoryRef = ref_Product.CategoryRef;
            ref_ProductViewModel.Quantity = ref_Product.Quantity;
            ref_ProductViewModel.UnitPrice = ref_Product.UnitPrice;
            Ref_ProductRepository.Update(ref_Product);

        }
        #endregion

        #region [- Delete_Product(int? id) -]
        public void Delete_Product(int? id)
        {
            Ref_ProductRepository.Delete(id);
        }
        #endregion


        #endregion
    }
}