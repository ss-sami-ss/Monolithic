using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Monolithic_SinglePage.Models.DomainModels.DTO.EF;
using System.Data.Entity;

namespace Monolithic_SinglePage.Models.DomainModels.POCO
{
    public class CategoryRepository
    {
        #region [- ctor -]
        public CategoryRepository()
        {

        }
        #endregion

        #region [- Tasks -]

        #region [- SelectAll() -]
        public List<Models.DomainModels.DTO.EF.Category> SelectAll()
        {
            using (var context = new Models.DomainModels.DTO.EF.Sam_StoreEntities())
            {
                try
                {
                    var q = context.Category.ToList();
                    return q;
                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {
                    if (context != null)
                    {
                        context.Dispose();
                    }
                }
            }
        }
        #endregion

        #region [- InsertInto(Category ref_Category) -]
        public void InsertInto(Category ref_Category)
        {
            using (var context = new Models.DomainModels.DTO.EF.Sam_StoreEntities())
            {
                try
                {
                    context.Category.Add(ref_Category);
                    context.SaveChanges();
                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {
                    if (context != null)
                    {
                        context.Dispose();
                    }
                }
            }
        }
        #endregion

        #region [- FindCategory(int? id) -]
        public Category FindCategory(int? id)
        {
            using (var context = new Models.DomainModels.DTO.EF.Sam_StoreEntities())
            {
                try
                {
                    var q = context.Category.Find(id);
                    return q;
                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {
                    if (context != null)
                    {
                        context.Dispose();
                    }
                }
            }
        }
        #endregion

        #region [- Update(Category ref_Category) -]
        public void Update(Category ref_Category)
        {
            using (var context = new Models.DomainModels.DTO.EF.Sam_StoreEntities())
            {
                try
                {
                    context.Entry(ref_Category).State = EntityState.Modified;
                    context.SaveChanges();
                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {
                    if (context != null)
                    {
                        context.Dispose();
                    }
                }
            }
        }
        #endregion

        #region [- Delete(int? id) -]
        public void Delete(int? id)
        {
            using (var context = new Sam_StoreEntities())
            {
                try
                {
                    var q = context.Category.Find(id);
                    context.Category.Remove(q);
                    context.SaveChanges();
                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {
                    if (context != null)
                    {
                        context.Dispose();
                    }
                }
            }
        } 
        #endregion


        #endregion
    }
}