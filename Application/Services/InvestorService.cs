using Domain.Entities;
using Domain.Interfaces.Repositories;

namespace Application.Services;

public class InvestorService(IBaseRepository<Investor> investorRepository) : IBaseService<Investor>
{
    public async Task<Investor> GetAsync(Guid id, CancellationToken token = default)
    {
        return await investorRepository.GetAsync(id, token);
    }

    public async Task<IEnumerable<Investor>> GetAllAsync(CancellationToken token = default)
    {
        return await investorRepository.GetAllAsync(token);
    }

    public async Task<Investor> CreateAsync(Investor entity, CancellationToken token = default)
    {
        return await investorRepository.CreateAsync(entity, token);
    }

    public Task<bool> UpdateAsync(Investor entity, CancellationToken token = default)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteAsync(Guid id, CancellationToken token = default)
    {
        throw new NotImplementedException();
    }
}