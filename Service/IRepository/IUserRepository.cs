using DAO.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.IRepository
{
    public interface IUserRepository : IRepositoryBase<User>
    {
        User GetByEmail(string email);
        bool IsCorrectPassword(string email, string password);
        int UpdatePassword(string email, string password);
    }
}
