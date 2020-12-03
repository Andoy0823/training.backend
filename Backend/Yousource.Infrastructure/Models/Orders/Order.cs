namespace Yousource.Infrastructure.Models.Orders
{
    using System;
    using System.Runtime.Serialization;

    [DataContract]
    public class Order
    {
        [DataMember]
        public Guid OrderID { get; set; }

        [DataMember]
        public string CustomerName { get; set; }

        [DataMember]
        public string CustomerEmail { get; set; }

        [DataMember]
        public string RecipientName { get; set; }

        [DataMember]
        public string RecipientEmail { get; set; }

        [DataMember]
        public string StoreName { get; set; }

        [DataMember]
        public float VoucherPrice { get; set; }

        [DataMember]
        public string Dedication { get; set; }

        [DataMember]
        public DateTime OrderDate { get; set; }
    }
}
