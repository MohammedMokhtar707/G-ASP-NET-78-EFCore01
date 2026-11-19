using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Assignment01EFCore_1_.Entities;

[Table("BookTable", Schema = "dbo")]
internal class Book // BookTable [Data Annotation has the priority on conventions]
{
    [Key]
    public int BID { get; set; } // BID INT [PK] Identity(1,1)


    [Required]
    [MaxLength(100)]
    public string Title { get; set; } //Title VARCHAR(100) NOTNULL(Mandatory)


    [Required]
    [StringLength(25,MinimumLength =10,ErrorMessage = "ISBNNumber must be between 10,25 chars")]
    public string ISBNNumber { get; set; } // ISBNNumber VARCHAR(25) NOTNULL(Mandatory)
                                           // Only the MaxLength(25) that will be mapped to db 
                                           // MinLength and ErrMSG --> App validation

    [Column("BookPrice")]
    [Precision(10,2)]
    public decimal Price { get; set; } //BookPrice DECIMAL(10,2) NOTNULL(Mandatory)


    public int NumberOfPages { get; set; }  // NumberOfPages INT NOTNULL(Mandatory)
    public int PublicationYear { get; set; } // PublicationYear INT NOTNULL(Mandatory)
    public bool BookInStock { get; set; } // BookInStock BIT NOTNULL(Mandatory)

}
