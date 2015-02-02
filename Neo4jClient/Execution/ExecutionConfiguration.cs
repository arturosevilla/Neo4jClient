using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Neo4jClient.Execution
{

    public class ExecutionConfiguration
    {
        public IHttpClient HttpClient { get; set; }
        public bool UseJsonStreaming { get; set; }
        public string UserAgent { get; set; }
        public IEnumerable<JsonConverter> JsonConverters { get; set; }
        public IContractResolver JsonContractResolver { get; set; }
    }
}