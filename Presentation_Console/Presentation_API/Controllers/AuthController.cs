using BLL.Entities;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Presentation_API.Controllers
{
    public class AuthController : ApiController
    {
        [Route("api/login")]
        [HttpPost]
        public HttpResponseMessage Authenticate(LoginModel user)
        {

            var data = AuthService.Authenticate(user.Uname, user.Pass);
            if(data != null)
            {
                return Request.CreateResponse(HttpStatusCode.OK,data);
            }
            return Request.CreateResponse(HttpStatusCode.OK, new { msg = "Invalid User" });
        }
    }
}
