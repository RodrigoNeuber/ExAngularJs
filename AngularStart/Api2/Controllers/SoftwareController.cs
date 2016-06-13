using Api2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Api2.Controllers
{
    public class SoftwareController : ApiController
    {
        static List<Software> _listaDeSoftware = new List<Software>
        {
            new Software {Id = 1, Name = "IOS 9.3", Year = 2016, Url = "http://blogs-images.forbes.com/gordonkelly/files/2016/02/Screenshot-2016-02-25-at-18.04.31.png", },
            new Software {Id = 2, Name = "OSX ", Year = 2016, Url = "http://www.tonymacx86.com/attachments/screen-shot-2014-06-02-at-3-09-51-pm-png.94799/", },
            new Software {Id = 3, Name = "WatchOS 2", Year = 2016, Url = "http://applewatchoholic.net/wp-content/uploads/2015/12/watchOS2.jpg", }
        };

        public IHttpActionResult Get()
        {
            return Ok(_listaDeSoftware);
        }

        public IHttpActionResult Get(int id)
        {
            var software = _listaDeSoftware.Find(x => x.Id == id);
            return Ok(software);
        }

        // POST: api/Product
        public IHttpActionResult Post([FromBody] Software software)
        {
            _listaDeSoftware.Add(software);
            return Ok();
        }

        // PUT: api/Product/5
        public void Put(int id, [FromBody]string value)
        {

        }

        // DELETE: api/Product/5
        public void Delete(int id)
        {

        }
    }
}
