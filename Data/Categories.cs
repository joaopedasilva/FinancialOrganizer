using System.ComponentModel.DataAnnotations;

namespace FinancialOrganizer.Data;

public class Categories
{
    [Key]
    public int CategoryId { get; set; }

    [Required]
    [StringLength(25, ErrorMessage = "Product name cannot exceed 25 characters.")]
    public string? CategoryName { get; set; }

    [Required]
    public string? AmountLimit { get; set; }
}