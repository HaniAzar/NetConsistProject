using myApp.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Child1
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int PaerntID { get; set; }

        public List<Child1> child = new List<Child1>();

        public Child1()
        {

        }
     
      

        
    }
}
