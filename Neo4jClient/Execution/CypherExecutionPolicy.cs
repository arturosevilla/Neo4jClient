using System;
using System.Collections.Generic;
using System.Linq;
using Neo4jClient.ApiModels.Cypher;
using Neo4jClient.Cypher;

namespace Neo4jClient.Execution
{
    /// <summary>
    /// Describes the behavior for a cypher execution.
    /// </summary>
    internal class CypherExecutionPolicy : GraphClientBasedExecutionPolicy
    {
        public CypherExecutionPolicy(IGraphClient client) : base(client)
        {
        }

        public override Uri BaseEndpoint
        {
            get
            {
                return Client.CypherEndpoint;
            }
        }

        public override string SerializeRequest(object toSerialize)
        {
            var query = toSerialize as CypherQuery;
            if (query == null)
            {
                throw new InvalidOperationException(
                    "Unsupported operation: Attempting to serialize something that was not a query.");
            }

            return Client.Serializer.Serialize(new CypherApiQuery(query));
        }

        public override void AfterExecution(IDictionary<string, object> executionMetadata, object executionContext)
        {
            
        }

    }
}
