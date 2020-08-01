using MeetNChat.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeetNChat.Server.Models
{
    public class FriendModel
    {
        public ApplicationUser User { get; set; }

        public bool IsFriends { get; set; }
    }
}
