using Labb3Api.Models;

namespace Labb3Api.Services
{
    public interface IUser
    {
        Task<IEnumerable<User>> GetAll();

        Task<List<Interests>> GetUserInterests(int id);

        Task<List<Links>> GetUserLinks(int id);

        Task<UserConnection> UserNewInterest(UserConnection newEntity);

        Task<Links> AddLink(string newLink, int id, int interestsID, int LinkID);


    }
}
