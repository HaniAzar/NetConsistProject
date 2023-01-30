using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http.Results;
using Newtonsoft.Json;

namespace BLL
{
    public class Parent1
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int? parentID { get; set; } // הורה יכול להיות גם ילד וגם אבא בפני עצמו

        public List<Parent1> Children = new List<Parent1>();

        /// <summary>
        /// בונה ריקה
        /// </summary>
        public Parent1()
        {
            
        }

        //string convertJson(string jsontxt)
        //{
        //    List<Parent> listJson = JsonConvert.DeserializeObject<List<Parent>>(jsontxt);
        //    listJson = logicaJson(listJson, listJson[0].parentID);
        //    return JsonConvert.SerializeObject(listJson);
        //}
        ///// <summary>
        /////  פונקציה רקורסיבית שממירה את ה JSON  
        /////  היא מקבלת רשימה וID של אבא ובודקת אם זה שווה 
        /////  אם כן היא מכניסה אותו כילד לאב
        ///// </summary>
        //List<Parent> logicaJson(List<Parent> listParent, int? parentId)
        //{
        //    var listOfParent = new List<Parent>();

        //    foreach (var prnt in listParent.Where(p => p.parentID == parentId))
        //    {
        //        prnt.Children = logicaJson(listParent, prnt.ID);
        //        listOfParent.Add(prnt);
        //    }
        //    return listOfParent;
        //}



    }
}
