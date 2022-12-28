using System.ComponentModel.DataAnnotations;

namespace UdemyIdentity.ViewModels;
public class UserViewModel
{
    [Required(ErrorMessage="Enter Username")] 
    public string UserName { get; set; } 
    public string PhoneNumber{ get; set; }

    [Required(ErrorMessage ="Enter E-mail")]
    [EmailAddress(ErrorMessage ="Invalid Format")]
    public string Email { get; set; }

    [Required(ErrorMessage ="Enter Password")]
    [DataType(DataType.Password)]
    public string Password { get; set; }
}
