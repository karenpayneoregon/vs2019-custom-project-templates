using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BaseNetCoreClassNewtonsoftProject.Examples.Containers
{
    public class DownloadedData 
    {
        public MusicResults results { get; set; }
    }

    public class MusicResults
    {
        [JsonProperty("opensearch:Query")]
        public OpensearchQuery opensearchQuery { get; set; }
        [JsonProperty("opensearch:totalResults")]
        public string opensearchtotalResults { get; set; }
        [JsonProperty("opensearch:startIndex")]
        public string opensearchstartIndex { get; set; }
        [JsonProperty("opensearch:itemsPerPage")]
        public string opensearchitemsPerPage { get; set; }
        public Trackmatches trackmatches { get; set; }
        public Attr attr { get; set; }
    }

    public class OpensearchQuery
    {
        [JsonProperty("#text")]
        public string text { get; set; }
        public string role { get; set; }
        public string startPage { get; set; }
    }

    public class Trackmatches
    {
        public Track[] track { get; set; }
    }

    public class Track
    {
        public string name { get; set; }
        public string artist { get; set; }
        public string url { get; set; }
        public string streamable { get; set; }
        public string listeners { get; set; }
        public Image[] image { get; set; }
        public string mbid { get; set; }
    }

    public class Image
    {
        public string text { get; set; }
        public string size { get; set; }
    }

    public class Attr
    {
    }
}
