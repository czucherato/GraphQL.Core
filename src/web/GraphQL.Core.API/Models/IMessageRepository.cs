using System;
using System.Linq;
using System.Collections.Generic;

namespace GraphQL.Core.API.Models
{
    public interface IMessageRepository
    {
        IEnumerable<Message> Fetch(MessageFilter filter);
    }

    public class MessageFilter
    {
        public Guid Id { get; set; }

        public string MessageType { get; set; }
    }

    public class MessageRepository : IMessageRepository
    {
        public IEnumerable<Message> Fetch(MessageFilter filter)
        {
            //return FetchData().Where(x => x.Id == filter.Id && x.Type == filter.MessageType).ToList();
            return FetchData().Where(x =>  x.Type == filter.MessageType).ToList();
            //return FetchData();
        }

        private IEnumerable<Message> FetchData() => new List<Message>
        {
            new Message
            {
                Id = Guid.NewGuid(),
                Title = "Message 1",
                Content = "Content 1",
                Type = "Type 1"
            },
            new Message
            {
                Id = Guid.NewGuid(),
                Title = "Message 2",
                Content = "Content 2",
                Type = "Type 2"
            },
            new Message
            {
                Id = Guid.NewGuid(),
                Title = "Message 3",
                Content = "Content 3",
                Type = "Type 3"
            },
            new Message
            {
                Id = Guid.NewGuid(),
                Title = "Message 4",
                Content = "Content 4",
                Type = "Type 4"
            },
            new Message
            {
                Id = Guid.NewGuid(),
                Title = "Message 5",
                Content = "Content 5",
                Type = "Type 6"
            },
            new Message
            {
                Id = Guid.NewGuid(),
                Title = "Message 6",
                Content = "Content 6",
                Type = "Type 6"
            },
        };
    }
}