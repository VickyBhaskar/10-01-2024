using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductHandling
{
    public class Product
    {

        public String PName{ get; set; }
        public Double PPrice { get; set; }
        public string PBrand { get; set; }
        public DateTime MfgDate { get; set; }
        public DateTime ExpDate { get; set; }
    }
}
