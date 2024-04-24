using Domain.Entities;
using Domain.Interfaces.Repositories;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class InvestorRepository(ApplicationDbContext context)
    : BaseRepository<Investor>(context), IBaseRepository<Investor>
{
    private readonly DbSet<Investor> _dbSet = context.Set<Investor>();

    public new async Task<IEnumerable<Investor>> GetAllAsync(CancellationToken token = default)
    {
        return await _dbSet.Include(x => x.Address).ToListAsync(token);
    }
}