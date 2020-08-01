using System;
using System.Collections.Generic;
using System.Text;

namespace MeetNChat.Shared.Entities
{
    public class UserDetails
    {
        public string UserHandle { get; set; }

        public string DisplayName { get; set; }

        public virtual HashSet<ChatUser> Chats { get; set; }

        public Guid ApplicationUserId { get; set; }

        public ApplicationUser ApplicationUser { get; set; }
    }
}
