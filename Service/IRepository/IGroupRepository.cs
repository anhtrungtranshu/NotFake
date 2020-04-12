using DAO.Models;

namespace Service.IRepository
{
    public interface IGroupRepository : IRepositoryBase<Group>
    {
        Group Get(int FilmId, int CreatorId);
    }
}