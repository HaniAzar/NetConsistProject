using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.Remoting.Contexts;
using System.Web.Helpers;
using System.Web.Http;
using System.Web.Http.ExceptionHandling;
using BLL;
using Microsoft.Build.Utilities;
using Newtonsoft;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace myApp.Controllers
{
    public class SolutionController : ApiController
    {

        public string jsonText = @"[
            {  'id': 1,   'name': 'david',   'parent': null  },
            {   'id': 2,   'name': 'tom',   'parent': 1  },
            {   'id': 3,   'name': 'tami',   'parent': 1  },
            {   'id': 4,   'name': 'gal',   'parent': 1  },
            {   'id': 5,   'name': 'uri',   'parent': 4  },
            {   'id': 6,   'name': 'uri',   'parent': 3  },  
            {   'id': 7,   'name': 'adi',   'parent': 5  } ]";


        public string RecursiveJson(string jsontext)
        {
            try
            {
                // המרה
                List<Parent> listJson = JsonConvert.DeserializeObject<List<Parent>>(jsontext);
                //האבא הראשי שהוא NULL
                List<Parent> result = listJson.Where(p => p.parentID == null).ToList();
                // מחזירה את הילדים של האבא הראשי וגם מחזירה את הכל הילדים של הילדים
                foreach (var r in result)
                {
                    r.Children = GetChildsForPrnt(r.ID, listJson);
                }
                // המרה בחזרה לJSON
                return JsonConvert.SerializeObject(result);
            }
            catch (Exception)
            {
                EventLog.WriteEntry("Error", "Error Message", EventLogEntryType.Error);//כתיבה ליומן 
                return "Error.";
            }
        }
        /// <summary>
        /// מקבלת רשימה ומזהה של אבא ועוברת על הרשימה ומכניסה לאבא את כל הילדים שלו
        /// </summary>
        public List<Parent> GetChildsForPrnt(int parentId, List<Parent> list)
        {
            var children = list.Where(x => x.parentID == parentId).ToList();
            foreach (var c in children)
            {
                c.Children = GetChildsForPrnt(c.ID, list);
            }
            return children;
        }



    }
}