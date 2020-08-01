using System;

namespace MeetNChat.Shared.Entities
{
    public class ChatMessage
    {
        public Guid Id { get; set; }

        public Guid ChatId { get; set; }

        public Chat Chat { get; set; }

        public Guid SenderId { get; set; }

        public ApplicationUser Sender { get; set; }

        public string Content { get; set; }

        public DateTime TimeStamp { get; set; }

    }
}
