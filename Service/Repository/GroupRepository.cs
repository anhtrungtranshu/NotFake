using System.Linq;
using DAO;
using DAO.Models;
using Service.IRepository;

namespace Service.Repository
{
    public class GroupRepository : RepositoryBase<Group>, IGroupRepository
    {
        public GroupRepository(NotFakeContext context) : base(context) { }

        public Group Get(int FilmId, int CreatorId)
        {
            return context.Groups
                        .Where(g => g.CreatorId == CreatorId && g.FilmId == FilmId)
                        .FirstOrDefault();
        }
    }
}