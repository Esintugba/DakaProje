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
    public class GalleryManager : IGalleryService
    {
        private readonly IGalleryDal _galleryDal;

        public GalleryManager(IGalleryDal galleryDal) 
        {
            _galleryDal = galleryDal;
        }
        public void TDelete(Gallery t)
        {
            _galleryDal.Delete(t);
        }

        public Gallery TGetByID(int id)
        {
            return _galleryDal.GetByID(id);
        }

        public List<Gallery> TGetList()
        {
           return _galleryDal.GetList();
        }

        public void TInsert(Gallery t)
        {
           _galleryDal.Insert(t);
        }

        public void TUpdate(Gallery t)
        {
            _galleryDal.Update(t);
        }
    }
}
