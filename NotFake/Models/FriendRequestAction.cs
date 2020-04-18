namespace NotFake.Models
{
    public class FriendRequestAction
    {
        public string invitedUserEmail { get; set; }
        public string invitingUserEmail { get; set; }
        public bool isAccepted { get; set; }
    }
}
