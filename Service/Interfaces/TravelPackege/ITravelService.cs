using Service.DTOs.TravelPackege;
using Service.Helpers;

namespace Service.Interfaces.TravelPackege;

public interface ITravelService
{
    Task<TravelResultDto> CreateAsync(TravelResultDto result);
    Task<TravelResultDto> UpdateAsync(TravelResultDto result);
    Task<TravelResultDto> GetByIdAsync(long id);
    Task<bool> DeleteAsync (long id);

    Task<Responce<IEnumerable<TravelResultDto>>> GetAllAsync();

}
