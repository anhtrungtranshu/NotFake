using DAO.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAO
{
    public class NotFakeContext : DbContext
    {
        public NotFakeContext(DbContextOptions<NotFakeContext> options) : base(options)
        {

        }

        public DbSet<User> User { get; set; }
    }
}
