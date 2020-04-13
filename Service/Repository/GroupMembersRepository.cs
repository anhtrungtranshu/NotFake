using System.Collections.Generic;
using System.Linq;
using DAO;
using DAO.Models;
using Service.IRepository;

namespace Service.Repository
{
    public class GroupMembersRepository : RepositoryBase<GroupMembers>, IGroupMembersRepository
    {
        public GroupMembersRepository(NotFakeContext context) : base(context) { }

        public List<GroupMembers> GetGroupMembers(Group group)
        {
            return context.GroupMembers.Where(gm => gm.Group == group).ToList();
        }
    }
}