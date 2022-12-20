using System.ComponentModel.DataAnnotations;

namespace PustokDb2022.ViewModels
{
    public class ForgotPasswordViewModel
    {
        [MaxLength(100)]
        public string Email { get; set; }
    }
}
