using System;
using GraphQL.Types;
using GraphQL.Utilities;
using GraphQL.Core.API.GraphQL;

namespace GraphQL.Core.API.Schemas
{
    public class MessageSchema : Schema
    {
        public MessageSchema(IServiceProvider serviceProvider)
            : base(serviceProvider)
        {
            Query = serviceProvider.GetRequiredService<MessageQuery>();
        }
    }
}