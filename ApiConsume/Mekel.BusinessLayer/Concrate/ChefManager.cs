using Mekel.BusinessLayer.Abstract;
using Mekel.DataAccessLayer.Abstract;
using Mekel.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mekel.BusinessLayer.Concrate
{
    public class ChefManager : IChefService
    {
        private readonly IChefDal _chefDal;

        public ChefManager(IChefDal chefDal)
        {
            _chefDal = chefDal;
        }
        public void TDelete(Chef t)
        {
           _chefDal.Delete(t);
        }

        public Chef TGetByID(int id)
        {
            return _chefDal.GetByID(id);
        }

        public List<Chef> TGetList()
        {
            return _chefDal.GetList();
        }

        public void TInsert(Chef t)
        {
            _chefDal.Insert(t);
        }

        public void TUpdate(Chef t)
        {
            _chefDal.Update(t);
        }
    }
}
