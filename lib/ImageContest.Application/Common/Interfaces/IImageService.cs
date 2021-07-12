using ImageContest.Application.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageContest.Application.Common.Interfaces
{
    public interface IImageService
    {
        Task<ActiveContestDto> GetActiveContestAsync();
        Task<ContestRegisterVoteResponseDto> RegisterVoteAsync(ContestRegisterVoteDto contestRegisterVoteDto);
        Task<RegisterContestResponseDto> RegisterContestDtoAsync(RegisterContestDto registerContestDto);
    }
}
