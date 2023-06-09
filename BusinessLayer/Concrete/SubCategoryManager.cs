﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class SubCategoryManager : ISubCategoryService
    {
        ISubCategoryDal _subCategoryDal;
        public SubCategoryManager(ISubCategoryDal subCategoryDal)
        {
            _subCategoryDal = subCategoryDal;
        }
        public void TAdd(SubCategory t)
        {
            _subCategoryDal.Insert(t);
        }

        public void TDelete(SubCategory t)
        {
            _subCategoryDal.Delete(t);
        }

        public SubCategory TGetByID(int id)
        {
            return _subCategoryDal.GetByID(id);
        }

        public List<SubCategory> TGetList()
        {
            return _subCategoryDal.GetList();
        }
        public List<SubCategory> GetSubCategoryListWithMain()
        {
            return _subCategoryDal.SubCategoriesListByMain();
        }
        public List<SubCategory> TGetList(int id)
        {
            return _subCategoryDal.GetList(x => x.MainCategoryID == id);
        }

        public void TUpdate(SubCategory t)
        {
            _subCategoryDal.Update(t);
        }
    }
}
