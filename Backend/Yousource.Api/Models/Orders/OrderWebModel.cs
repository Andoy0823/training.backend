// <auto-generate />

namespace Yousource.Api.Models.Orders
{
    using System;
    using Newtonsoft.Json;

    public class OrderWebModel
    {
        [JsonProperty("orderID")]
        public Guid OrderID { get; set; }

        [JsonProperty("customerName")]
        public string CustomerName { get; set; }

        [JsonProperty("customerEmail")]
        public string CustomerEmail { get; set; }

        [JsonProperty("recipientName")]
        public string RecipientName { get; set; }

        [JsonProperty("recipientEmail")]
        public string RecipientEmail { get; set; }

        [JsonProperty("storeName")]
        public string StoreName { get; set; }

        [JsonProperty("voucherPrice")]
        public float VoucherPrice { get; set; }

        [JsonProperty("dedication")]
        public string Dedication { get; set; }

        [JsonProperty("orderDate")]
        public DateTime OrderDate { get; set; }
    }
}
