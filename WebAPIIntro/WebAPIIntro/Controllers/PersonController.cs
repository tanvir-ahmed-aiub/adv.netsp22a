using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Script.Serialization;
using WebAPIIntro.Models;

namespace WebAPIIntro.Controllers
{
    [EnableCors("*","*","*")]
    public class PersonController : ApiController
    {
        
        public HttpResponseMessage Get() {
            List<Person> persons = new List<Person>();
            for (int i = 0; i < 10; i++) {
                var p = new Person()
                {
                    Id = i + 1,
                    Name = "Name " + (i + 1)
                };
                persons.Add(p);
            }
            //var data = new JavaScriptSerializer().Serialize(persons);
            return Request.CreateResponse(HttpStatusCode.OK, persons);
            

        }
        public Person Get(int id) {
            List<Person> persons = new List<Person>();
            for (int i = 0; i < 10; i++)
            {
                var p = new Person()
                {
                    Id = i + 1,
                    Name = "Name " + (i + 1)
                };
                persons.Add(p);
            }
            return persons.FirstOrDefault(x => x.Id == id);
        }

        public void Post() { 
        
        }
        public void Put() { 
        }
        public void Patch() { 
        }
        public void Delete() { 
        }
    }
}
