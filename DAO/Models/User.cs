using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

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
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public UserRoles Role { get; set; }
        public string Fullname { get; set; }
        public List<User> Friends { get; set; }
        public List<Post> PostsToOtherUsers { get; set; }
        public List<Post> PostsFromOtherUsers { get; set; }
        public List<UserFilmInvite> InvitesToOtherUsers { get; set; }
        public List<UserFilmInvite> InvitesFromOtherUsers { get; set; }
    }
}
