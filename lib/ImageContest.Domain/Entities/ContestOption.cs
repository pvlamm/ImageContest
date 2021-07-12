using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageContest.Domain.Entities
{
    public class ContestOption
    {
        public int Id { get; set; }
        public virtual Contest Parent { get; set; }
        public int ParentId { get; set; }
        public virtual ImageSet ContestImageSet { get; set; }
        public int ContestImageSetId { get; set; }
        
    }
}
