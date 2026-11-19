using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment01EFCore_1_.Entities;
internal class Author //[Authors] --> By Convention [Named at Dbcontext (Dbset)]
{
    [Key]
    public int AuthId { get; set; } // AuthId INT [PK] Identity(1,1)

    [Required]
    [MaxLength(20)]
    public string FirstName { get; set; } //FirstName VARCHAR(20) NOTNULL(Mandatory)


    [Required]
    [StringLength(20,MinimumLength = 3 ,ErrorMessage = "LastName must be between 3 and 20 chars")]
    public string LastName { get; set; } //LastName VARCHAR(20) NOTNULL(Mandatory)
                                         // Only the MaxLength(20) that will be mapped to db 
                                         //  MinLength and ErrMSG --> App validation
    
    [NotMapped]
    public string FullName => $"{FirstName} {LastName}"; //Will not be mapped to db


    [Required]                           
    [MaxLength(50)]
    [DataType(DataType.EmailAddress)]
    public string EmailAddress { get; set; } //EmailAddress VARCHAR(50) NOTNULL(Mandatory)
                                             //[DataType(DataType.EmailAddress)] --> Will not be mapped to db [UI Hint]


    [MaxLength(150)]
    public string ShortBiography { get; set; } //ShortBiography VARCHAR(150) NOTNULL(Mandatory)


    [DataType(DataType.DateTime)]
    public DateTime DateOfBirth { get; set; } //DateOfBirth DATETIME2 NOTNULL(Mandatory)
                                              // [DataType(DataType.DateTime)] --> Will not be mapped to db [UI Hint]

}
