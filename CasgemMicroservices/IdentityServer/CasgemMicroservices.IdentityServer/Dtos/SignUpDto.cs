using System.ComponentModel.DataAnnotations;

namespace CasgemMicroservices.IdentityServer.Dtos
{
    public class SignUpDto
    {

        [Required]
        public string NameSurname { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Email { get; set; }
    }
}
