using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mekel.EntityLayer.Concrete
{
    public class BlogYorum
    {
        public IEnumerable<Blog> D1 { get; set; }
        public IEnumerable<Comment> D2 { get; set; }
        public IEnumerable<Blog> D3 { get; set; }
    }
}
