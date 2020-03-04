using DAO;
using Service.IRepository;
using Service.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service
{
    public class NotFakeService : INotFakeService
    {
        public NotFakeService()
        {
            NotFakeContext context = new NotFakeContext();
            User = new UserRepository(context);
        }
        IUserRepository User { get; set; }

    }
}
