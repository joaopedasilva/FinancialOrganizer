using System.ComponentModel.DataAnnotations;

namespace FinancialOrganizer.Data;

public class TransactionsFormModel
{
    [Required]
    [StringLength(50, ErrorMessage = "Product name cannot exceed 50 characters.")]
    public string? ProductOrService { get; set; }

    [Required]
    public decimal Price { get; set; }

    [Required]
    public DateTime DateAndTime { get; set; }

    [Required]
    public int CategoryId { get; set; }

    [Required]
    public int PaymentMethodId { get; set; }
}