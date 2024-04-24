using Domain.Entities;
using Domain.Interfaces.Repositories;

namespace Application.Services;

public class AddressService(IBaseRepository<Address> addressRepository) : IBaseService<Address>
{
    public Task<Address> GetAsync(Guid id, CancellationToken token = default)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Address>> GetAllAsync(CancellationToken token = default)
    {
        throw new NotImplementedException();
    }

    public async Task<Address> CreateAsync(Address entity, CancellationToken token = default)
    {
        return await addressRepository.CreateAsync(entity, token);
    }

    public Task<bool> UpdateAsync(Address entity, CancellationToken token = default)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteAsync(Guid id, CancellationToken token = default)
    {
        throw new NotImplementedException();
    }
}