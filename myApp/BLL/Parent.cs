using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Parent
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string password { get; set; } // עבור ה JWT
        public int? parentID { get; set; } // הורה יכול להיות גם ילד וגם אבא בפני עצמו

        public List<Parent> Children = new List<Parent>();

        public Parent()
        {
            
        }
    }
}
