using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAPI
{
    //This is just the connection class, here we are making POCOS for the MainUrl, and the APIKey.
    //This allows us to set the URL and the Key in a different folder, it is neater, and safer.
    public class Connection
    {
        [JsonProperty("MainUrl")]
        public string MainUrl { get; set; } = String.Empty;
        [JsonProperty("APIKey")]
        public string APIKey { get; set; } = String.Empty;
    }
}
