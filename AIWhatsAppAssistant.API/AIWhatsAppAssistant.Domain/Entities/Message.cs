using System;
using System.Collections.Generic;
using System.Text;

namespace AIWhatsAppAssistant.Domain.Entities;

public class Message
{
    public long MessageId { get; set; }

    public long ConversationId { get; set; }

    public string? WhatsAppMessageId { get; set; }

    public string Direction { get; set; } = string.Empty;

    public string MessageType { get; set; } = string.Empty;

    public string? MessageText { get; set; }

    public bool AIProcessed { get; set; }

    public DateTime CreatedDate { get; set; }
}