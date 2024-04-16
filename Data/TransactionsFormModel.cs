using System.ComponentModel.DataAnnotations;

namespace FinancialOrganizer.Data;

public class TransactionsFormModel
{
    [Required]
    [StringLength(50, ErrorMessage = "Product name cannot exceed 50 characters.")]
    public string? ProductOrService { get; set; }

    [Required]
    public string? Price { get; set; }

    [Required]
    public DateTime DateAndTime { get; set; }

    [Required]
    [StringLength(25, ErrorMessage = "Product name cannot exceed 25 characters.")]
    public string? CategoryName { get; set; }

    [Required]
    [StringLength(25, ErrorMessage = "Product name cannot exceed 25 characters.")]
    public string? PaymentMethod { get; set; }
}