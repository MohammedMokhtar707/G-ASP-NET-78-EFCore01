using System.ComponentModel.DataAnnotations;
namespace Assignment01EFCore_1_.Entities;
internal class BookCategory // BookCategories --> By Convention [Named at Dbcontext (Dbset)]
{
    [Key]
    public int BCategoryId { get; set; } //BCategoryId INT [PK] Identity(1,1)


    [Required]
    [MaxLength(20)]
    public string Name { get; set; } //Name VARCHAR(20) NOTNULL(Mandatory)


    [StringLength(500,MinimumLength =10,ErrorMessage = "The Description of the book should be between 10 and 500 chars")]
    public string Description { get; set; } //Description VARCHAR(500) NOTNULL(Mandatory)
                                           // Only the MaxLength(500) that will be mapped to db 
                                           // MinLength and ErrMSG --> App validation


    public bool CategoryStatus { get; set; } //CategoryStatus BIT NOTNULL(Mandatory)

}
