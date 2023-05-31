using DateTimeLocalisation.Models;

namespace DateTimeLocalisation.Data
{
    public class OrderRepository : IOrderRepository
    {
        public Task<bool> CreateOrder(OrderModel order)
        {
            throw new NotImplementedException();
        }

        public Task<OrderModel> GetAllOrders()
        {
            throw new NotImplementedException();
        }
    }
}