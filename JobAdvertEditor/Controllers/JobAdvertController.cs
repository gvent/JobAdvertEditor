using System;
using System.Collections.Generic;
using System.Web.Http;
using Umbraco.Core.Models;
using Umbraco.Web;
using Umbraco.Web.Models;
using Umbraco.Web.Mvc;
using Umbraco.Web.WebApi;

namespace JobAdvertEditor.Controllers
{
    public class JobAdvertController : UmbracoApiController
    {
        // GET api/<controller>
        [HttpGet]
        [ActionName("GetToken")]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
        [System.Web.Http.AcceptVerbs("GET", "POST")]
        [System.Web.Http.HttpGet]
        public IEnumerable<string> find()
        {
            var page = Umbraco.Content(1063);
            var theName = page.title;
            return new string[] { theName, "value2" };
  
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}