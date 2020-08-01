using System;
using System.Collections.Generic;
using System.Text;

namespace MeetNChat.Shared.Entities
{
    public class ChatUser
    {
        public Guid Id { get; set; }

        public Guid ChatId { get; set; }

        public Chat Chat { get; set; }

        public Guid UserId { get; set; }

        public ApplicationUser User { get; set; }
    }
}
