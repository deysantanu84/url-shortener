using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebRole1.Data
{
    public class UrlItem
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        public string ShortUrlStub { get; set; }
        public string OriginalUrl { get; set; }
    }
}