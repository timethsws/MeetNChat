using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MeetNChat.Server.Data;
using MeetNChat.Server.Models;
using MeetNChat.Shared.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MeetNChat.Server.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;
        private readonly UserManager<ApplicationUser> userManager;

        public UserController(ApplicationDbContext dbContext, UserManager<ApplicationUser> userManager)
        {
            this.dbContext = dbContext;
            this.userManager = userManager;
        }

        public async Task<UserDetails> FindUser (string userHandle)
        {
            var userDetails = await dbContext.UserDetails.AsNoTracking().Where(u => u.UserHandle.Equals(userHandle)).FirstOrDefaultAsync();
            if (userDetails == null) return userDetails;

            userDetails.ApplicationUserId = Guid.Empty;
            return userDetails;
        }
    }
}
