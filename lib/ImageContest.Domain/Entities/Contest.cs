using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageContest.Domain.Entities
{
    public class Contest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual Root Parent { get; set; }
        public int ParentId { get; set; }
        public DateTime BeginTime { get; set; }
        public DateTime EndTime { get; set; }
    }
}
