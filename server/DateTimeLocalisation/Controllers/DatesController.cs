using System.Threading.Tasks;
using DateTimeLocalisation.Models;
using DateTimeLocalisation.Services;
using Microsoft.AspNetCore.Mvc;

namespace DateTimeLocalisation.Controllers
{
    /// <summary>
    ///     Dates for orders
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class DatesController : ControllerBase
    {
        private readonly IOrderService _orderService;

        public DatesController(IOrderService orderService)
        {
            _orderService = orderService;
        }


        /// <summary>
        ///     Create a new test datetime entry
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Post(CreateNewDateTimeModel model)
        {
            await _orderService.CreateNewOrder(model);
            return Ok();
        }

        /// <summary>
        ///     Get all orders
        /// </summary>
        /// <returns></returns>
        [HttpGet("getall")]
        public async Task<IActionResult> GetAll()
        {
            return Ok();
        }

        /// <summary>
        ///     Get an order by id
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns></returns>
        [HttpGet("get/{orderId}")]
        public async Task<IActionResult> GetById(int orderId)
        {
            return Ok();
        }
    }
}