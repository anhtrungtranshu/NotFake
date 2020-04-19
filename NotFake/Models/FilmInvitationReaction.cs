namespace NotFake.Models
{
    public class FilmInvitationReaction
    {
        public int invitationId { get; set; }
        public string invitedUserEmail { get; set; }
        public bool isAccepted { get; set; }
    }
}