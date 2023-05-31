using DateTimeLocalisation.Models;

namespace DateTimeLocalisation.Services
{
    public interface IOrderService
    {
        Task<bool> CreateNewOrder(CreateNewDateTimeModel model);

        Task<OrderModel> GetOrder(int orderId);
    }
}