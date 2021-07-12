using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageContest.Domain.Entities
{
    public class ContestVote
    {
        public int Id { get; set; }
        public virtual Contest Parent { get; set; }
        public int ParentId { get; set; }
        public virtual ContestOption VotedFor { get; set; }
        public int VoteForId { get; set; }
        public string ReferenceString { get; set; }
    }
}
