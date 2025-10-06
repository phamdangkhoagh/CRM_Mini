using System.ComponentModel.DataAnnotations;

namespace CRM_Mini.Models.ViewModels
{
	public class CreateUserViewModel
	{
		[Required, MaxLength(100)]
		public string FirstName {  get; set; }

		[Required, MaxLength(100)]
		public string LastName { get; set; } = string.Empty;

		[Required, EmailAddress]
		public string Email { get; set; } 

		[Required, DataType(DataType.Password)]
		public string Password { get; set; } 

		[Required, DataType(DataType.Password), Compare("Password", ErrorMessage = "Passwords do not match.")]
		public string ConfirmPassword { get; set; }

		[Phone]
		public string PhoneNumber { get; set; }

		[Required]
		public string Role { get; set; }

	}
}