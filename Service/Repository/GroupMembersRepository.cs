using DAO;
using DAO.Models;
using Service.IRepository;

namespace Service.Repository
{
    public class GroupMembersRepository : RepositoryBase<GroupMembers>, IGroupMembersRepository
    {
        public GroupMembersRepository(NotFakeContext context) : base(context) { }
    }
}