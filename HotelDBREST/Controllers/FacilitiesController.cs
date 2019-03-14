using System;
using System.Collections.Generic;
using System.Web.Http;
using HotelDBREST.DBUtil;
using ModelLib.model;

namespace HotelDBREST.Controllers
{
    public class FacilitiesController : ApiController
    {
        private static IManage<Facilities> manager = new ManageFacilities();

        // GET: api/Guests
        public IEnumerable<Facilities> Get()
        {
            return manager.Get();
        }

        // GET: api/Guests/5
        public Facilities Get(int id)
        {
            return manager.Get(id);
        }

        // POST: api/Guests
        public bool Post([FromBody]Facilities facility)
        {
            return manager.Post(facility);
        }

        // PUT: api/Guests/5
        public bool Put(int id, [FromBody]Facilities facility)
        {
            return manager.Put(id, facility);
        }

        // DELETE: api/Guests/5
        public bool Delete(int id)
        {
            return manager.Delete(id);
        }
    }
}