using Mekel.DataAccessLayer.Abstract;
using Mekel.DataAccessLayer.Concrete;
using Mekel.DataAccessLayer.Repositories;
using Mekel.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mekel.DataAccessLayer.EntityFramework
{
    public class EfBlogDal:GenericRepository<Blog>,IBlogDal
    {
        public EfBlogDal(Context context) :base(context) { 
        }
        
    }
}
