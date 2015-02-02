using System;
using System.Collections.Generic;

namespace Neo4jClient.Execution
{
    internal interface IExecutionPolicy
    {
        void AfterExecution(IDictionary<string, object> executionMetadata, object executionContext);
        string SerializeRequest(object toSerialize);
        Uri BaseEndpoint { get; }
        Uri AddPath(Uri startUri, object startReference);
    }
}