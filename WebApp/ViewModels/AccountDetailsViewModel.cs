using System.ComponentModel.DataAnnotations;

namespace WebApp.ViewModels;

public class AccountDetailsViewModel
{
    public AccountBasicInfo? Basic { get; set; }
    public AccountAdressInfo? Adress { get; set; }
}

public class AccountBasicInfo
{

    [Required]
    [Display(Name = "First name", Prompt = "Enter your first name")]
    public string FirstName { get; set; } = null!;

    [Required]
    [Display(Name = "Last name", Prompt = "Enter your last name")]
    public string LastName { get; set; } = null!;

    [Required]
    [Display(Name = "E-mail adress", Prompt = "Enter your e-mail adress")]
    [DataType(DataType.EmailAddress)]
    public string Email { get; set; } = null!;

    [Display(Name = "Phone", Prompt = "Enter your phone")]
    public string? PhoneNumber { get; set; }

    [Display(Name = "Bio", Prompt = "Add a short bio...")]
    public string? Bio {  get; set; }
}

public class AccountAdressInfo
{
    [Required]
    [Display(Name = "Adress line 1", Prompt = "Enter your first adress line")]
    public string AdressLine_1 { get; set; } = null!;
    [Required]
    [Display(Name = "Adress line 2", Prompt = "Enter your second adress line")]
    public string? AdressLine_2 { get; set; }
    [Required]
    [Display(Name = "Postal Code", Prompt = "Enter your postal code")]
    public string PostalCode { get; set; } = null!;
    [Required]
    [Display(Name = "City", Prompt = "Enter your city")]
    public string City { get; set; } = null!;
}
