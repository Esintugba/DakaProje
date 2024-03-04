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
    public class MenuManager : IMenuService
    {
        private readonly IMenuDal _menuDal;

        public MenuManager( IMenuDal menuDal)
        {
            _menuDal = menuDal;
        }
        public void TDelete(Menu t)
        {
            _menuDal.Delete(t);
        }

        public Menu TGetByID(int id)
        {
            return _menuDal.GetByID(id);
        }

        public List<Menu> TGetList()
        {
            return _menuDal.GetList();
        }

        public void TInsert(Menu t)
        {
           _menuDal.Insert(t);
        }

        public void TUpdate(Menu t)
        {
            _menuDal.Update(t);
        }
    }
}
