using DateTimeLocalisation.Data;
using DateTimeLocalisation.Models;

namespace DateTimeLocalisation.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public Task<bool> CreateNewOrder(CreateNewDateTimeModel model)
        {
            throw new NotImplementedException();
        }

        public Task<OrderModel> GetOrder(int orderId)
        {
            throw new NotImplementedException();
        }
    }
}