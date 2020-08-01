using MeetNChat.Server.Data;
using MeetNChat.Server.Models;
using MeetNChat.Shared.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeetNChat.Server.Services
{
    public class UserDetailsService
    {
        private readonly ApplicationDbContext dbContext;


        public UserDetailsService(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }


        public async Task<OperationOutput<UserDetails>> AddUserDetails (UserDetails userDetails)
        {
            if (dbContext.UserDetails.Any(ud => ud.UserHandle.Equals(userDetails.UserHandle)))
            {
                return OperationOutput<UserDetails>.Failed("User exisist with the given handle");
            }

            dbContext.UserDetails.Add(userDetails);
            await dbContext.SaveChangesAsync();

            return OperationOutput<UserDetails>.Success(userDetails);
        }


        public bool CheckUserHandle(string userHandle)
        {
            if (dbContext.UserDetails.Any(ud => ud.UserHandle.Equals(userHandle))) 
                return true;
            return false;
        }


        public async Task<OperationOutput<UserDetails>> GetUserByHandle(string userHandle)
        {
            var user = await dbContext.UserDetails.FirstOrDefaultAsync(u => u.UserHandle.Equals(userHandle));
            
            if(user == null)
            {
                return OperationOutput<UserDetails>.Failed("User with handle not found");
            }
            return OperationOutput<UserDetails>.Success(user);
        }
    }
}
