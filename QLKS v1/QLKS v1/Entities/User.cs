using Microsoft.AspNetCore.Identity;

namespace QLKS_v1.Entities
{
    public class User: BaseEntity
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string? FullName { get; set; }
        public string? NumberPhone {  get; set; }
        public string? UrlAvatar { get; set; }
        public string? Address {  get; set; }
        public int? Point { get; set; } = 0;
        public int? UserStatusId { get; set; } = 1;
        public int? RoleId { get; set; } = 1;
        public bool? IsActice { get; set; } = true;
        public Role Role { get; set; }
        public UserStatus? UserStatus { get; set; }
        public IEnumerable<RefreshToken>? RefreshTokens { get; set; }
        public IEnumerable<ComfirmEmail>? ConfirmEmails { get; set; }
    }
}
