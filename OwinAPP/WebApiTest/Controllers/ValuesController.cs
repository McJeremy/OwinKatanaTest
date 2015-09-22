﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace WebApiTest.Controllers
{
    public class ValuesController:ApiController
    {
        public List<string> Get()
        {
            return new List<string>() { "abc", "efg" };
        }

        [HttpGet]
        public string Get(string strID)
        {
            return "get by id";
        }
        
        public void Post([FromBody]string value)
        {
        }
        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }
        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}