using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DAO.Models
{
    public enum UserRoles
    {
        User = 0,
        Admin = 1
    }
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public UserRoles Role { get; set; }
        public string Fullname { get; set; }
}
}
