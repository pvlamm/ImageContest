using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageContest.Domain.Entities
{
    public class ImageFolder
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Folder { get; set; }
        public virtual Root Parent { get; set; }
        public int ParentId { get; set; }
        public HashSet<ImageSet> ImageSets { get; set; } = new HashSet<ImageSet>();
    }
}
