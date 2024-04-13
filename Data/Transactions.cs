using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinancialOrganizer.Data;

public class Transactions {
    [Key]
    public int TransactionId { get; set; }

    [Required]
    [StringLength(50, ErrorMessage = "Product name cannot exceed 50 characters.")]
    public string? ProductName { get; set; }

    [Required]
    public decimal Amount { get; set; }

    [Required]
    public Categories? Category { get; set; }

    [Required]
    public PaymentMethods? PaymentMethod { get; set; }

    [Required]
    public DateTime PurchaseDateAndTime { get; set; }

    [Required]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public DateTime CreatedDateAndTime { get; set; }
}