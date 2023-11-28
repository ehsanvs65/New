using System.ComponentModel.DataAnnotations;
namespace firstapp.Models.Entities
{
    public class Users
    {
        public int Id { get; set; }
        [EmailAddress(ErrorMessage = "ایمیل را به درستی وارد کنید")]
        [Required(ErrorMessage = "لطفا ایمیل را وارد کنید")]

        public string Email { get; set; }
    }
}
