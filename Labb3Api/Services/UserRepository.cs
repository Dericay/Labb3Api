using Labb3Api.Data;
using Labb3Api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Immutable;
using System.Linq;
using System.Collections.Generic;

namespace Labb3Api.Services
{
    public class UserRepository : IUser
    {
        private AppDbContext _appDbContext;

        public UserRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<Links> AddLink(string newLink, int id, int interestsID, int LinkID)
        {
            var link = new Links()
            {
                Link = newLink,
                LinkID = LinkID

            };
            var user = new UserConnection()
            {
                UserID = id,
                InterestsID = interestsID,
                LinksID = LinkID
            };
            await _appDbContext.Links.AddAsync(link);
            await _appDbContext.UserConnection.AddAsync(user);
            await _appDbContext.SaveChangesAsync();

            return link;
            
        }

        public async Task<IEnumerable<User>> GetAll()
        {
            return await _appDbContext.Users.ToListAsync();
        }
        public async Task<List<Interests>> GetUserInterests(int id)
        {
           var userConnection = await _appDbContext.UserConnection
                .Include(i => i.Interests)
                .Include(i => i.User)
                .Where(i => i.UserID == id)
                .Select(i => i.Interests)
                .ToListAsync();
            var interests = userConnection.DistinctBy(i => i.InterestsID).ToList();


            return interests;
        }

        public async Task<List<Links>> GetUserLinks(int id)
        {
            var userConnection = await _appDbContext.UserConnection
                .Include(i => i.Links)
                .Where (i => i.UserID == id)
                .Select (i => i.Links)
                .ToListAsync();

            return userConnection;
        }

        public async Task<UserConnection> UserNewInterest(UserConnection newEntity)
        {
           if(newEntity == null)
            {
                return null;
            }
          _appDbContext.UserConnection.Add(newEntity);
            await _appDbContext.SaveChangesAsync();
            return newEntity;
        }
    }

}