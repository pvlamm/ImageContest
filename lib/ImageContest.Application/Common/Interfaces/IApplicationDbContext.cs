using ImageContest.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ImageContest.Application.Common.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<Root> Roots { get; set; }
        DbSet<ImageFolder> ImageFolders { get; set; }
        DbSet<ImageSet> ImageSets { get; set; }
        DbSet<Contest> Contests { get; set; }
        DbSet<ContestOption> ContestOptions { get; set; }
        DbSet<ContestVote> ContestVotes { get; set; }

        IModel Model { get; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
        Task BeginTransactionAsync();
        Task CommitTransactionAsync();
        void RollbackTransaction();
    }
}
