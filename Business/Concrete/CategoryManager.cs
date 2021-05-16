using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;
        //categorymanager olarak dataaccess katmanına bağlıyım ama çokta bağlı değilim sadece kurallarıma uy yeter
        //zayıf bağlı çünkü interface üzerinden bağlı!
        //bu bağlılığı constractor injection ile yapıyorum
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public List<Category> GetAll()
        {
            //iş kodlarım olcak varsa tabi
            return _categoryDal.GetAll();
        }

        //Select * from Categories where CategoryId = 3
        public Category GetById(int categoryId)
        {
            return _categoryDal.Get(c=>c.CategoryId==categoryId);
        }
    }
}
