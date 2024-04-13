using System.ComponentModel.DataAnnotations;

namespace FinancialOrganizer.Data;

public class Categories
{
    [Key]
    public int CategoryId { get; set; }

    [Required]
    public string? CategoryName { get; set; }

    [Required]
    public string? AmountLimit { get; set; }
}