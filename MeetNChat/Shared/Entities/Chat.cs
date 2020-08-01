using System;
using System.Collections.Generic;
using System.Text;

namespace MeetNChat.Shared.Entities
{
    public class Chat
    {
        public Guid Id { get; set; }

        public Guid? ChatDetails { get; set; }

        public virtual HashSet<ChatUser> Users { get; set; }
    }
}
