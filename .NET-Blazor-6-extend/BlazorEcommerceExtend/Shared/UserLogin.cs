#region Usings
using System.ComponentModel.DataAnnotations;
#endregion

namespace BlazorEcommerceExtend.Shared
{
    public class UserLogin
    {
        [Required]
        public string Email { get; set; } = string.Empty;
        [Required]
        public string Password { get; set; } = string.Empty;
    }
}