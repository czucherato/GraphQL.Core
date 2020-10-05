using GraphQL.Types;
using GraphQL.Core.API.Models;

namespace GraphQL.Core.API.GraphQL
{
    public class MessageType : ObjectGraphType<Message>
    {
        public MessageType()
        {
            Name = "Message";
            Field(x => x.Id, type: typeof(IdGraphType)).Description("Message id");
            Field(x => x.Title).Description("Message title");
            Field(x => x.Content).Description("Message content");
            Field(x => x.Type).Description("Message type");
        }
    }
}