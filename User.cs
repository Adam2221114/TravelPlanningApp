using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

public class User
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int UserId { get; set; }  // 系统生成的唯一ID

    [Required]
    [StringLength(50, MinimumLength = 4)]
    public string UserAccount { get; set; }  // 用户自己输入的唯一登录账户

    [Required]
    [StringLength(50, MinimumLength = 6)]
    public string Password { get; set; }

    [Required]
    [Phone]
    public string PhoneNumber { get; set; }

    [Required]
    [EmailAddress]
    public string Email { get; set; }

    [StringLength(50)]
    public string Nickname { get; set; } 
}







