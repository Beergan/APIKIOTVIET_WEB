using System.ComponentModel.DataAnnotations.Schema;

[Table("pp_Kiot_AccessToken")]
public class pp_Kiot_AccessToken : EntityBase
{
    public string Token { get; set; }
}