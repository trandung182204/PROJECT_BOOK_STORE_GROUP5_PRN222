﻿using System;
using System.Collections.Generic;

namespace PROJECT_BOOK_STORE_GROUP5_PRN222.Models;

public partial class Payment
{
    public long Id { get; set; }

    public long OrderId { get; set; }

    public string PaymentMethod { get; set; } = null!;

    public decimal Amount { get; set; }

    public string Status { get; set; } = null!;

    public string? TransactionId { get; set; }

    public DateTime? PaidAt { get; set; }

    public virtual Order Order { get; set; } = null!;
}
