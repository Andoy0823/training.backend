namespace Yousource.Api.Extensions.Order
{
    using System.Collections.Generic;
    using System.Linq;
    using Yousource.Api.Messages;
    using Yousource.Api.Messages.Orders.Requests;
    using Yousource.Api.Models.Orders;
    using Yousource.Infrastructure.Messages.Orders.Requests;
    using Yousource.Infrastructure.Messages.Orders.Responses;
    using Yousource.Infrastructure.Models.Orders;

    public static class OrderExtensions
    {
        public static CreateOrderRequest AsRequest(this AddOrderWebRequest request)
        {
            var result = new CreateOrderRequest
            {
                CustomerName = request.CustomerName,
                CustomerEmail = request.CustomerEmail,
                RecipientName = request.RecipientName,
                RecipientEmail = request.RecipientEmail,
                StoreName = request.StoreName,
                VoucherPrice = request.VoucherPrice,
                Dedication = request.Dedication
            };

            return result;
        }

        public static WebResponse AsWebResponse(this CreateOrderResponse response)
        {
            var result = new WebResponse
            {
                Message = response.Message,
                ErrorCode = response.ErrorCode,
                StatusCode = response.StatusCode
            };

            return result;
        }

        public static WebResponse<IEnumerable<OrderWebModel>> AsWebResponse(this GetOrdersResponse response)
        {
            var result = new WebResponse<IEnumerable<OrderWebModel>>(response.Data?.AsWebModel())
            {
                Message = response.Message,
                ErrorCode = response.ErrorCode,
                StatusCode = response.StatusCode
            };

            return result;
        }

        public static OrderWebModel AsWebModel(this Order model)
        {
            return new OrderWebModel
            {
                OrderID = model.OrderID,
                CustomerName = model.CustomerName,
                CustomerEmail = model.CustomerEmail,
                RecipientName = model.RecipientName,
                RecipientEmail = model.RecipientEmail,
                StoreName = model.StoreName,
                VoucherPrice = model.VoucherPrice,
                Dedication = model.Dedication,
                OrderDate = model.OrderDate
            };
        }

        public static IEnumerable<OrderWebModel> AsWebModel(this IEnumerable<Order> models)
        {
            return models.Select(entity => entity.AsWebModel());
        }
    }
}
