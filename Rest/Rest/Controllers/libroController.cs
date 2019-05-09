using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Rest.Controllers
{
    public class libroController : ApiController
    {
        libreriaEntities BD = new libreriaEntities();
        // GET: api/libro
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/libro/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/libro
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/libro/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/libro/5
        public void Delete(int id)
        {
        }
    }
}
