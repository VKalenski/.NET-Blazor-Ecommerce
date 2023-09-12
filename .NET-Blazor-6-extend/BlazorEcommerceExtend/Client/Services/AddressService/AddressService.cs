namespace BlazorEcommerceExtend.Client.Services.AddressService
{
    public class AddressService : IAddressService
    {
        #region Fields
        private readonly HttpClient _http;
        #endregion

        #region Ctor
        public AddressService(HttpClient http)
        {
            _http = http;
        }
        #endregion

        public async Task<Address> AddOrUpdateAddress(Address address)
        {
            var response = await _http.PostAsJsonAsync("api/address", address);
            return response.Content
                .ReadFromJsonAsync<ServiceResponse<Address>>().Result.Data;
        }

        public async Task<Address> GetAddress()
        {
            var response = await _http
                .GetFromJsonAsync<ServiceResponse<Address>>("api/address");
            return response.Data;
        }
    }
}