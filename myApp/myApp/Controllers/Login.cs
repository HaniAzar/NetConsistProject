using BLL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Claims;
using System.Text;
using System.Web.Http;
using System.Web.Mvc;

namespace myApp.Controllers
{
    public class Login : ApiController
    {


        
        public IHttpActionResult LoginUser([FromBody] Parent user)
        {
            if (user == null)
            {
                return BadRequest("Invalid user request!!!");
            }
            if (user.password == "123")
            {
                
                //return Ok();

            }
            return Unauthorized();
        }


    }
}