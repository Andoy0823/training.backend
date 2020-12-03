namespace Yousource.Infrastructure.Messages.Orders.Requests
{
    using System.Runtime.Serialization;

    [DataContract]
    public class CreateOrderRequest
    {
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
    }
}
