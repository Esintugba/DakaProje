using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mekel.EntityLayer.Concrete
{
    public class Blog
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public string Description { get; set; }
        public string BlogImage { get; set; }
        public DateTime Date { get; set; }
        
    }
}
