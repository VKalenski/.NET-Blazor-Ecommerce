#region Usings
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
#endregion

namespace BlazorEcommerce.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        #region Fields
        private readonly IPaymentService _paymentService;
        #endregion

        #region Ctor
        public PaymentController(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }
        #endregion

        #region POST
        [HttpPost("checkout"), Authorize]
        public async Task<ActionResult<string>> CreateCheckoutSession()
        {
            var session = await _paymentService.CreateCheckoutSession();
            return Ok(session.Url);
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<bool>>> FulfillOrder()
        {
            var response = await _paymentService.FulfillOrder(Request);
            if (!response.Success)
                return BadRequest(response.Message);

            return Ok(response);
        }
        #endregion
    }
}