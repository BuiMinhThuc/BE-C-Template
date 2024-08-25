namespace QLKS_v1.Entities
{
    public class ComfirmEmail : BaseEntity
    {
        public int UserId { get; set; }
        public User? User { get; set; }
        public DateTime RequiredDateTime { get; set; }
        public DateTime ExpiredDateTime { get; set; }
        public string ConfirmCode { get; set; }
        public bool IsConfirm { get; set; } = false;
    }
}
