using GraphQL.SystemTextJson;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace GraphQL.Core.API.GraphQL
{
    public class GraphQLQuery
    {
        public string OperationName { get; set; }

        public string NamedQuery { get; set; }

        public string Query { get; set; }

        [JsonConverter(typeof(ObjectDictionaryConverter))]
        public Dictionary<string, object> Variables
        {
            get; set;
        }
    }
}