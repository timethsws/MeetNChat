using System;
using System.Collections.Generic;
using System.Text;

namespace MeetNChat.Shared.Entities
{
    public class FriendRecord
    {
        /// <summary>
        /// Identifier
        /// </summary>
        public Guid Id { get; set; }

        // User
        public Guid UserId { get; set; }
        public ApplicationUser User { get; set; }

        // Friend
        public Guid FriendId { get; set; }
        public ApplicationUser Friend { get; set; }
    }
}
