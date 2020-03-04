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
        int Id { get; set; }
        string Email { get; set; }
        string Password { get; set; }
        UserRoles Role { get; set; }
        string Fullname { get; set; }
}
}
