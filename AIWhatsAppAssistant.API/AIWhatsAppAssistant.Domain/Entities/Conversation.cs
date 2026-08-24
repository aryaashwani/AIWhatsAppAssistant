using System;
using System.Collections.Generic;
using System.Text;

namespace AIWhatsAppAssistant.Domain.Entities;

public class Conversation
{
    public long ConversationId { get; set; }

    public long BusinessId { get; set; }

    public long CustomerId { get; set; }

    public string Status { get; set; } = "AI";

    public DateTime CreatedDate { get; set; }

    public DateTime? LastMessageDate { get; set; }

    public DateTime? ClosedDate { get; set; }
}
