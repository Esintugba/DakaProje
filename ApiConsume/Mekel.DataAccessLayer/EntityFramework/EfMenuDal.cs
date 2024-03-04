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
    public class EfMenuDal:GenericRepository<Menu>, IMenuDal
    {
        public EfMenuDal(Context context) : base(context) 
        {

        }
    }
}
