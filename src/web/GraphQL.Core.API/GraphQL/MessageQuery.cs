using System;
using GraphQL.Types;
using GraphQL.Core.API.Models;

namespace GraphQL.Core.API.GraphQL
{
    public class MessageQuery : ObjectGraphType<object>
    {
        public MessageQuery(IMessageRepository messageRepository)
        {
            Field<ListGraphType<MessageType>>("message",
                arguments: new QueryArguments(new QueryArgument[]
                {
                    new QueryArgument<IdGraphType>{ Name="id" },
                    new QueryArgument<StringGraphType>{ Name="type" }
                }),
                resolve: context =>
                {
                    var filter = new MessageFilter
                    {
                        Id = context.GetArgument<Guid>("id"),
                        MessageType = context.GetArgument<string>("type")
                    };

                    return messageRepository.Fetch(filter);
                });
        }
    }
}