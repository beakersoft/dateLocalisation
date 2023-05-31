using DateTimeLocalisation.Models;

namespace DateTimeLocalisation.Data
{
    public interface IOrderRepository
    {
        
        Task<bool> CreateOrder(OrderModel order);

        Task<OrderModel> GetAllOrders();
    }
}