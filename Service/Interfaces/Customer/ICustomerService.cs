using Service.DTOs.Costumer;
using Service.DTOs.TravelPackege;
using Service.Helpers;

namespace Service.Interfaces.Customer;

public interface ICustomerService
{
    Task<CustomerResultDTO> CreateAsync(CustomerResultDTO result);
    Task<CustomerResultDTO> UpdateAsync(CustomerResultDTO result);
    Task<CustomerResultDTO> GetByIdAsync(long id);
    Task<bool> DeleteAsync(long id);

    Task<Responce<IEnumerable<CustomerResultDTO>>> GetAllAsync();
}
