﻿// <auto-generated />

namespace Yousource.Services.Order.Data.Entities
{
    using System;

    public class OrderEntity
    {
        public Guid OrderID { get; set; }

        public string CustomerName { get; set; }

        public string CustomerEmail { get; set; }

        public string RecipientName { get; set; }

        public string RecipientEmail { get; set; }

        public string StoreName { get; set; }

        public float VoucherPrice { get; set; }

        public string Dedication { get; set; }

        public DateTime OrderDate { get; set; }
    }
}
