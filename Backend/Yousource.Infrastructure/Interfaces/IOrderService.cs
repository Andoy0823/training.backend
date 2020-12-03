namespace Yousource.Infrastructure.Interfaces
{
    using System.Threading.Tasks;
    using Yousource.Infrastructure.Messages.Orders.Requests;
    using Yousource.Infrastructure.Messages.Orders.Responses;

    public interface IOrderService
    {
        Task<CreateOrderResponse> CreateOrderAsync(CreateOrderRequest request);

        Task<GetOrdersResponse> GetOrdersAsync();
    }
}
