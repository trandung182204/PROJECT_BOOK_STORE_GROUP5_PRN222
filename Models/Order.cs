using System;
using System.Collections.Generic;

namespace PROJECT_BOOK_STORE_GROUP5_PRN222.Models;

public partial class Order
{
    public long Id { get; set; }

    public string? UserId { get; set; }

    public string? OrderStatus { get; set; }

    public string? PaymentStatus { get; set; }

    public string? PaymentMethod { get; set; }

    public string? ShippingAddress { get; set; }

    public decimal? ShippingFee { get; set; }

    public decimal TotalAmount { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public string? PaymentMethod1 { get; set; }

    public string? PaymentStatus1 { get; set; }

    public string? TransactionId { get; set; }

    public DateTime? PaymentDate { get; set; }

    public string? ShippingAddress1 { get; set; }

    public string? Note { get; set; }

    public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

    public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();

    public virtual AspNetUser? User { get; set; }
}
