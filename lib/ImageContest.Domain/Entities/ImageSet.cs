using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageContest.Domain.Entities
{
    public class ImageSet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Folder { get; set; }
        public int FileCount { get; set; }
    }
}
