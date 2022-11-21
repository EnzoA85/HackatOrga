using System;
using System.Collections.Generic;

namespace OrgaHackat.Models
{
    public partial class MessengerMessage
    {
        public long Id { get; set; }
        public string Body { get; set; } = null!;
        public string Headers { get; set; } = null!;
        public string QueueName { get; set; } = null!;
        public DateTime CreatedAt { get; set; }
        public DateTime AvailableAt { get; set; }
        public DateTime? DeliveredAt { get; set; }
    }
}
