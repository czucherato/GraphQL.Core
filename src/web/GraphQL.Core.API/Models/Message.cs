using System;

namespace GraphQL.Core.API.Models
{
    public class Message
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public string Type { get; set; }
    }
}