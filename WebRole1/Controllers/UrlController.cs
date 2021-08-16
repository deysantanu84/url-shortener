using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using WebRole1.Data;

namespace WebRole1.Controllers
{
    public class UrlController : ApiController
    {
        // GET api/url/someurl
        public async Task<string> GetAsync(string shortUrlStub)
        {
            //Return Original Url from the Short Url
            string originalUrl = await UrlDatabase.Instance.QueryUrlItemAsync(shortUrlStub);
            return originalUrl != null ? originalUrl : "";
        }

        // POST api/url
        public async Task<string> PostAsync([FromBody] string originalUrl)
        {
            //Create a Short Url from the Original Url
            string shortStubUrl = await UrlDatabase.Instance.AddItemToContainerAsync(originalUrl);
            return shortStubUrl != null ? shortStubUrl : "";
        }
    }
}