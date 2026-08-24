using System;
using System.Collections.Generic;
using System.Text;

namespace AIWhatsAppAssistant.Domain.Entities;

public class Customer
{
    public long CustomerId { get; set; }

    public long BusinessId { get; set; }

    public string WhatsAppNumber { get; set; } = string.Empty;

    public string? CustomerName { get; set; }

    public bool IsBlocked { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime? LastMessageDate { get; set; }
}
