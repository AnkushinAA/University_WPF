using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_WPF.Model
{
    public class Adress: Model
    {
        public string City { get; set; }
        public string Street { get; set; }
        public int Home { get; set; }
       
        public Adress() { }

    }
}
