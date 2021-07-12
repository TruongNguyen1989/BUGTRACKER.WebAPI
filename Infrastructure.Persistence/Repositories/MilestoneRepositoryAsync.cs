using Application.Interfaces.Repositories;
using Domain.Entities;
using Infrastructure.Persistence.Contexts;
using Infrastructure.Persistence.Repository;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence.Repositories
{
    public class MilestoneRepositoryAsync :  GenericRepositoryAsync<Milestone>, IMilestoneRepositoryAsync
    {
        private readonly DbSet<Milestone> _milestone;

        public MilestoneRepositoryAsync(ApplicationDbContext dbContext) : base(dbContext)
        {
            _milestone = dbContext.Set<Milestone>();
        }
    }
}
