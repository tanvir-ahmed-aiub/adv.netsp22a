using BLL.Services;
using Presentation_API.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Presentation_API.Controllers
{
    [EnableCors("*", "*", "*")]
    public class StudentController : ApiController
    {

        [Route("api/student/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(int id) {
            var st = StudentService.Get(id);
            return Request.CreateResponse(HttpStatusCode.OK, st);
        }
        
        [Route("api/student/")]
        [HttpGet]
        [AdminAccess]
        public HttpResponseMessage Get()
        {
            var st = StudentService.Get();
            return Request.CreateResponse(HttpStatusCode.OK, st);
        }
        [Route("api/demo")]
        public HttpResponseMessage GetAll() {
           

            return Request.CreateResponse(HttpStatusCode.OK, new { A1 = new int[1, 2], Ob = new { Id = 1, Name = 2 } });
        }
    }
}
