#region Usings
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
#endregion

namespace BlazorEcommerceExtend.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class AddressController : ControllerBase
    {
        #region Fields
        private readonly IAddressService _addressService;
        #endregion

        #region Ctor
        public AddressController(IAddressService addressService)
        {
            _addressService = addressService;
        }
        #endregion


        #region GET
        [HttpGet]
        public async Task<ActionResult<ServiceResponse<Address>>> GetAddress()
        {
            return await _addressService.GetAddress();
        }
        #endregion

        #region POST
        [HttpPost]
        public async Task<ActionResult<ServiceResponse<Address>>> AddOrUpdateAddress(Address address)
        {
            return await _addressService.AddOrUpdateAddress(address);
        }
        #endregion
    }
}