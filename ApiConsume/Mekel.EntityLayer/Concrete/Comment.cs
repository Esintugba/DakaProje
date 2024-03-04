using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mekel.EntityLayer.Concrete
{
    public class Comment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Job { get; set; }
        public string ImageUrl { get; set; }
        public string Email { get; set; }
        public int BlogId { get; set; }
        public virtual Blog Blog { get; set; }
    }
}
