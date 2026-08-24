using System;
using System.Collections.Generic;
using System.Text;

namespace AIWhatsAppAssistant.Domain.Entities;

public class Business
{
    public long BusinessId { get; set; }

    public string BusinessName { get; set; } = string.Empty;

    public string? WhatsAppPhoneNumberId { get; set; }

    public string? WhatsAppBusinessAccountId { get; set; }

    public string? SystemPrompt { get; set; }

    public bool IsActive { get; set; }

    public DateTime CreatedDate { get; set; }
}