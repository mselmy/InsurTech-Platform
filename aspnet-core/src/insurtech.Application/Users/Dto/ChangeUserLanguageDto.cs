using System.ComponentModel.DataAnnotations;

namespace insurtech.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}