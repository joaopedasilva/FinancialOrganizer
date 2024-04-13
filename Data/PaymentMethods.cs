using System.ComponentModel.DataAnnotations;

namespace FinancialOrganizer.Data;

public class PaymentMethods
{
    [Key]
    public int PaymentMethodId { get; set; }

    [Required]
    public string? PaymentMethodType { get; set; }

    [Required]
    public string? PaymentMethodIssuer { get; set; }
}