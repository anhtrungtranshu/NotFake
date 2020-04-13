using System.Collections.Generic;
using DAO.Models;

namespace Service.IRepository
{
    public interface IGroupMembersRepository : IRepositoryBase<GroupMembers>
    {
        List<GroupMembers> GetGroupMembers(Group group);
    }
}