using PROJECT_BOOK_STORE_GROUP5_PRN222.Models;

namespace PROJECT_BOOK_STORE_GROUP5_PRN222.Services
{
    public interface ICheckoutService
    {
        Task<Order> CreateOrderCODAsync(String userId, string address, string note);
        Task<string> CreateVnPayPaymentUrlAsync(String userId);
        //Task<object> HandleVnPayReturnAsync(VnPayReturnRequest request);
        Task<object> GetCheckoutSummaryAsync(String userId);
    }
}
