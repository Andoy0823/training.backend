namespace Yousource.Infrastructure.Messages.Orders.Responses
{
    using System.Collections.Generic;
    using System.Net;
    using System.Runtime.Serialization;
    using Yousource.Infrastructure.Messages;
    using Yousource.Infrastructure.Models.Orders;

    public class GetOrdersResponse : Response
    {
        [DataMember]
        public IEnumerable<Order> Data { get; set; }
    }
}
