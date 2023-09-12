#region Usings
using Stripe.Checkout;
#endregion

namespace BlazorEcommerceExtend.Server.Services.PaymentService
{
    public interface IPaymentService
    {
        Task<Session> CreateCheckoutSession();
        Task<ServiceResponse<bool>> FulfillOrder(HttpRequest request);
    }
}