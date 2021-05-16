using Core.DataAccess;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    // IProductDal benim veri tabanında productla ilgili yapacağım ekleme, silme... vb işleri içerecek
    public interface IProductDal : IEntityRepository<Product>
    {
    }
}
//refactoring yapıldı