using DemoAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DemoAPI.Controllers
{
    public class PeopleController : ApiController
    {
        // GET: api/People
        List<Person> people = new List<Person>();

        public PeopleController()
        {
            people.Add ( new Person { FirstName = "Vlad", LastName = "Berezin", Id = 1});
            people.Add(new Person { FirstName = "Alyona", LastName = "Varankina", Id = 2 });
            people.Add(new Person { FirstName = "Clark", LastName = "Kent", Id = 3   });
        }

        public List<Person> Get()
        {
            return people;
        }

        // GET: api/People/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/People
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/People/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/People/5
        public void Delete(int id)
        {
        }
    }
}
